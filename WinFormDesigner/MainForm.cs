using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

using ICSharpCode.FormsDesigner.Gui;
using ICSharpCode.FormsDesigner.Services;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Reflection;
using System.Collections;
using ICSharpCode.TextEditor;
using ICSharpCode.TextEditor.Document;


namespace WinFormDesigner
{
    public partial class MainForm : Form
    {
        bool _ShouldUpdateSelectableObjects = false;
        bool inUpdate = false;

        IDesignerHost _host;
        PropertyGrid _propertyGrid;
        TextEditorControl _textEditor;

        ISelectionService _selectionService;
        CustomToolboxService _toolboxService;
        MenuCommandService _menuCommandService;

        Loader.CodeDomHostLoader _CodeDomHostLoader;

        #region signleton

        private MainForm()
        {
            InitializeComponent();

            CustomInitialize();
        }
        static MainForm _form;
        public static MainForm Instance
        {
            get
            {
                if (null == _form)
                    _form = new MainForm();
                return _form;
            }
        }

        #endregion

        /// <summary>
        /// �����ʼ��
        /// </summary>
        void CustomInitialize()
        {
            #region ����ToolBox

            string fileName = Application.StartupPath + @"\..\data\SharpDevelopControlLibrary.xml";
            ComponentLibraryLoader componentLibraryLoader = new ComponentLibraryLoader();
            componentLibraryLoader.LoadToolComponentLibrary(fileName);

            Guanjinke.Windows.Forms.ToolBox toolBox = new Guanjinke.Windows.Forms.ToolBox();
            toolBox.Dock = DockStyle.Fill;

            foreach (Category category in componentLibraryLoader.Categories)
            {
                if (category.IsEnabled)
                {
                    Guanjinke.Windows.Forms.ToolBoxCategory cate = new Guanjinke.Windows.Forms.ToolBoxCategory();
                    cate.ImageIndex = -1;
                    cate.IsOpen = false;
                    cate.Name = category.Name;
                    cate.Parent = null;

                    Guanjinke.Windows.Forms.ToolBoxItem item = new Guanjinke.Windows.Forms.ToolBoxItem();
                    item.Tag = null;
                    item.Name = "<Pointer>";
                    item.Parent = null;
                    cate.Items.Add(item);

                    foreach (ToolComponent component in category.ToolComponents)
                    {
                        item = new Guanjinke.Windows.Forms.ToolBoxItem();

                        System.Drawing.Design.ToolboxItem toolboxItem = new System.Drawing.Design.ToolboxItem();
                        toolboxItem.TypeName = component.FullName;
                        toolboxItem.Bitmap = componentLibraryLoader.GetIcon(component);
                        toolboxItem.DisplayName = component.Name;
                        Assembly asm = component.LoadAssembly();
                        toolboxItem.AssemblyName = asm.GetName();

                        item.Image = toolboxItem.Bitmap;
                        item.Tag = toolboxItem;
                        item.Name = component.Name;
                        item.Parent = null;

                        cate.Items.Add(item);
                    }

                    toolBox.Categories.Add(cate);
                }
            }

            pnlToolBox.Controls.Add(toolBox);//���panel���ӿؼ�

            #endregion

            #region ����PropertyPad

            _propertyGrid = new PropertyGrid {Dock = DockStyle.Fill};
            pnlPropertyGrid.Controls.Add(_propertyGrid);//�ұ����Ա�

            #endregion


            #region ���� "����" �� "�����" �� "Code"����

            ServiceContainer serviceContainer = new ServiceContainer();
            serviceContainer.AddService(typeof(System.ComponentModel.Design.IDesignerEventService), new DesignerEventService());
            serviceContainer.AddService(typeof(System.ComponentModel.Design.Serialization.INameCreationService), new NameCreationService());
            _toolboxService = new CustomToolboxService();
            serviceContainer.AddService(typeof(IToolboxService), _toolboxService);

            DesignSurface surface = new DesignSurface(serviceContainer);
            serviceContainer.AddService(typeof(System.ComponentModel.Design.IEventBindingService), new ICSharpCode.FormsDesigner.Services.EventBindingService(surface));
            _menuCommandService = new MenuCommandService(surface);
            serviceContainer.AddService(typeof(IMenuCommandService), _menuCommandService);

            //surface.BeginLoad(typeof(Form));
            _CodeDomHostLoader = new Loader.CodeDomHostLoader();
            surface.BeginLoad(_CodeDomHostLoader);

            Control designerContorl = (Control)surface.View;
            designerContorl.Dock = DockStyle.Fill;
            tpDesign.Controls.Add(designerContorl);//����

            _textEditor = new TextEditorControl
            {
                IsReadOnly = true,
                Dock = DockStyle.Fill,
                Document = {HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("C#")}
            }; //����༭��
            tpCode.Controls.Add(_textEditor);

            #endregion

            _propertyGrid.SelectedObject = surface.ComponentContainer.Components[0];
            SetAlignMenuEnabled(false);

            _host = (IDesignerHost)surface.GetService(typeof(IDesignerHost));
            _propertyGrid.Site = (new IDEContainer(_host)).CreateSite(_propertyGrid);
            _propertyGrid.PropertyTabs.AddTabType(typeof(System.Windows.Forms.Design.EventsTab), PropertyTabScope.Document);

            #region �¼���Ӧ

            // ѡ����ı�ʱ���¼�
            _selectionService = surface.GetService(typeof(ISelectionService)) as ISelectionService;
            _selectionService.SelectionChanged += new EventHandler(selectionService_SelectionChanged);

            // ��/ɾ/������������¼�
            IComponentChangeService componentChangeService = (IComponentChangeService)surface.GetService(typeof(IComponentChangeService));
            componentChangeService.ComponentAdded += ComponentListChanged;
            componentChangeService.ComponentRemoved += ComponentListChanged;
            componentChangeService.ComponentRename += ComponentListChanged;
            _host.TransactionClosed += new DesignerTransactionCloseEventHandler(TransactionClosed);

            // ѡ�в�ͬ�Ĺ�������Ŀ
            toolBox.SelectedItemChanged += delegate(object sender, Guanjinke.Windows.Forms.ToolBoxItem newItem)
            {
                _toolboxService.SetSelectedToolboxItem(newItem.Tag as System.Drawing.Design.ToolboxItem);
            };

            // ˫����������Ŀʱ���ӵ��������
            toolBox.ItemDoubleClicked += delegate(object sender, Guanjinke.Windows.Forms.ToolBoxItem newItem)
            {
                System.Drawing.Design.ToolboxItem toolboxItem = newItem.Tag as System.Drawing.Design.ToolboxItem;
                if (null != toolboxItem)
                {
                    IToolboxUser toolboxUser = _host.GetDesigner(_host.RootComponent as IComponent) as IToolboxUser;
                    if (null != toolboxUser)
                        toolboxUser.ToolPicked(toolboxItem);
                }
                    
            };

            // �϶���������Ŀ��֧�ִ���
            toolBox.ItemDragStart += delegate(object sender, Guanjinke.Windows.Forms.ToolBoxItem newItem)
            {
                System.Drawing.Design.ToolboxItem toolboxItem = newItem.Tag as System.Drawing.Design.ToolboxItem;
                if (null != toolboxItem)
                {
                    DataObject dataObject = ((IToolboxService)_toolboxService).SerializeToolboxItem(toolboxItem) as DataObject;
                    toolBox.DoDragDrop(dataObject, DragDropEffects.Copy);
                }
            };

            _toolboxService.ResetToolboxItem += delegate
            {
                toolBox.ResetSelection();
            };


            #endregion

            tsmiDelete.ShortcutKeys = Keys.Delete;
            tsmiSelectAll.ShortcutKeys = Keys.Control | Keys.A;

            cmbControls.Sorted = true;
            cmbControls.DrawMode = DrawMode.OwnerDrawFixed;
            cmbControls.DrawItem += new DrawItemEventHandler(cmbControls_DrawItem);
            UpdateComboBox();
        }

        void selectionService_SelectionChanged(object sender, EventArgs e)
        {
            object[] selection = new object[_selectionService.SelectionCount];
            _selectionService.GetSelectedComponents().CopyTo(selection, 0);
            _propertyGrid.SelectedObjects = selection;
            if (_selectionService.SelectionCount > 1)
                SetAlignMenuEnabled(true);
            else
                SetAlignMenuEnabled(false);
            SelectedObjectsChanged();
        }

        void ComponentListChanged(object sender, EventArgs e)
        {
            _ShouldUpdateSelectableObjects = true;
        }

        void TransactionClosed(object sender, DesignerTransactionCloseEventArgs e)
        {
            if (_ShouldUpdateSelectableObjects)
            {
                panel2.BeginInvoke(new MethodInvoker(UpdateComboBox));
                _ShouldUpdateSelectableObjects = false;
            }
        }
        /// <summary>
        /// ���¿ؼ�������
        /// </summary>
        void UpdateComboBox()
        {
            inUpdate = true;
            cmbControls.Items.Clear();
            ICollection collect = _host.Container.Components;
            if (null != collect)
            {
                foreach (object obj in collect)
                    cmbControls.Items.Add(obj);
            }

            selectionService_SelectionChanged(null, null);
            inUpdate = false;
        }
        void SelectedObjectsChanged()
        {
            inUpdate = true;
            object[] objs = _propertyGrid.SelectedObjects;
            if (null != objs && objs.Length == 1)
            {
                for (int i = 0; i < cmbControls.Items.Count; i++)
                    if (objs[0] == cmbControls.Items[i])
                    {
                        cmbControls.SelectedIndex = i;
                        break;
                    }
            }
            else
                cmbControls.SelectedIndex = -1;
            inUpdate = false;
        }

        #region �˵��¼�

        private void tsmiLeft_Click(object sender, EventArgs e)
        {
            _menuCommandService.GlobalInvoke(StandardCommands.AlignLeft);
        }

        private void tsmiCenter_Click(object sender, EventArgs e)
        {
            _menuCommandService.GlobalInvoke(StandardCommands.AlignVerticalCenters);
        }

        private void tsmiRight_Click(object sender, EventArgs e)
        {
            _menuCommandService.GlobalInvoke(StandardCommands.AlignRight);
        }

        private void tsmiTop_Click(object sender, EventArgs e)
        {
            _menuCommandService.GlobalInvoke(StandardCommands.AlignTop);
        }

        private void tsmiMiddle_Click(object sender, EventArgs e)
        {
            _menuCommandService.GlobalInvoke(StandardCommands.AlignHorizontalCenters);
        }

        private void tsmiBottom_Click(object sender, EventArgs e)
        {
            _menuCommandService.GlobalInvoke(StandardCommands.AlignBottom);
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            _menuCommandService.GlobalInvoke(StandardCommands.Delete);
        }

        private void tsmiSelectAll_Click(object sender, EventArgs e)
        {
            int iCount = _host.Container.Components.Count;
            if (iCount <= 1)
                return;
            
            _menuCommandService.GlobalInvoke(StandardCommands.SelectAll);
        }

        void SetAlignMenuEnabled(bool bEnable)
        {
            tsmiLeft.Enabled = bEnable;
            tsmiCenter.Enabled = bEnable;
            tsmiRight.Enabled = bEnable;
            tsmiTop.Enabled = bEnable;
            tsmiMiddle.Enabled = bEnable;
            tsmiBottom.Enabled = bEnable;
        }

        private void tsmiRun_Click(object sender, EventArgs e)
        {
            _CodeDomHostLoader.Run();
        }

        #endregion

        private void cmbControls_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!inUpdate)
            {
                if (_selectionService != null)
                {
                    if (cmbControls.SelectedIndex >= 0)
                    {
                        _selectionService.SetSelectedComponents(new object[] { cmbControls.Items[cmbControls.SelectedIndex] });
                    }
                    else
                    {
                        _propertyGrid.SelectedObject = null;
                        _selectionService.SetSelectedComponents(new object[] { });
                    }
                }
            }
        }

        private void cmbControls_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= cmbControls.Items.Count)
            {
                return;
            }
            Graphics g = e.Graphics;
            Brush stringColor = SystemBrushes.ControlText;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                if ((e.State & DrawItemState.Focus) == DrawItemState.Focus)
                {
                    g.FillRectangle(SystemBrushes.Highlight, e.Bounds);
                    stringColor = SystemBrushes.HighlightText;
                }
                else
                {
                    g.FillRectangle(SystemBrushes.Window, e.Bounds);
                }
            }
            else
            {
                g.FillRectangle(SystemBrushes.Window, e.Bounds);
            }

            object item = cmbControls.Items[e.Index];
            int xPos = e.Bounds.X;

            if (item is IComponent)
            {
                ISite site = ((IComponent)item).Site;
                if (site != null)
                {
                    string name = site.Name;
                    using (Font f = new Font(cmbControls.Font, FontStyle.Bold))
                    {
                        g.DrawString(name, f, stringColor, xPos, e.Bounds.Y);
                        xPos += (int)g.MeasureString(name + "-", f).Width;
                    }
                }
            }

            string typeString = item.GetType().ToString();
            g.DrawString(typeString, cmbControls.Font, stringColor, xPos, e.Bounds.Y);
        }

        #region ���ɺ�̨����
        private void tabContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabContent.SelectedIndex == 1)
            {
                _textEditor.Text = _CodeDomHostLoader.GetCode(Strings.CS);
            }
        } 
        #endregion

        #region ��̨�����ʲô�������Դ���
        private class Strings
        {
            public const string Design = "Design";
            public const string Code = "Code";
            public const string Xml = "Xml";
            public const string CS = "C#";
            public const string JS = "J#";
            public const string VB = "VB";
        } 
        #endregion

    }
}