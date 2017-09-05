namespace WinFormDesigner
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlToolBox = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlPropertyGrid = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbControls = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.tabContent = new System.Windows.Forms.TabControl();
            this.tpDesign = new System.Windows.Forms.TabPage();
            this.tpCode = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.±‡º≠EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.∂‘∆ÎAligmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRight = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMiddle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBottom = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRun = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.tabContent.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolBox
            // 
            this.pnlToolBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlToolBox.Location = new System.Drawing.Point(0, 25);
            this.pnlToolBox.Name = "pnlToolBox";
            this.pnlToolBox.Size = new System.Drawing.Size(158, 421);
            this.pnlToolBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlPropertyGrid);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(475, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 421);
            this.panel2.TabIndex = 1;
            // 
            // pnlPropertyGrid
            // 
            this.pnlPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPropertyGrid.Location = new System.Drawing.Point(0, 23);
            this.pnlPropertyGrid.Name = "pnlPropertyGrid";
            this.pnlPropertyGrid.Size = new System.Drawing.Size(195, 398);
            this.pnlPropertyGrid.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbControls);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 23);
            this.panel1.TabIndex = 0;
            // 
            // cmbControls
            // 
            this.cmbControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbControls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbControls.FormattingEnabled = true;
            this.cmbControls.Items.AddRange(new object[] {
            "Form1 System.Windows.Forms"});
            this.cmbControls.Location = new System.Drawing.Point(0, 0);
            this.cmbControls.Name = "cmbControls";
            this.cmbControls.Size = new System.Drawing.Size(195, 20);
            this.cmbControls.TabIndex = 1;
            this.cmbControls.SelectedIndexChanged += new System.EventHandler(this.cmbControls_SelectedIndexChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(158, 25);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 421);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(472, 25);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 421);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tabContent);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(168, 25);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(304, 421);
            this.pnlContent.TabIndex = 4;
            // 
            // tabContent
            // 
            this.tabContent.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabContent.Controls.Add(this.tpDesign);
            this.tabContent.Controls.Add(this.tpCode);
            this.tabContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContent.Location = new System.Drawing.Point(0, 0);
            this.tabContent.Name = "tabContent";
            this.tabContent.SelectedIndex = 0;
            this.tabContent.Size = new System.Drawing.Size(304, 421);
            this.tabContent.TabIndex = 0;
            this.tabContent.SelectedIndexChanged += new System.EventHandler(this.tabContent_SelectedIndexChanged);
            // 
            // tpDesign
            // 
            this.tpDesign.Location = new System.Drawing.Point(4, 4);
            this.tpDesign.Name = "tpDesign";
            this.tpDesign.Padding = new System.Windows.Forms.Padding(3);
            this.tpDesign.Size = new System.Drawing.Size(296, 395);
            this.tpDesign.TabIndex = 0;
            this.tpDesign.Text = "Design";
            this.tpDesign.UseVisualStyleBackColor = true;
            // 
            // tpCode
            // 
            this.tpCode.Location = new System.Drawing.Point(4, 4);
            this.tpCode.Name = "tpCode";
            this.tpCode.Padding = new System.Windows.Forms.Padding(3);
            this.tpCode.Size = new System.Drawing.Size(296, 395);
            this.tpCode.TabIndex = 1;
            this.tpCode.Text = "Code";
            this.tpCode.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.±‡º≠EditToolStripMenuItem,
            this.∂‘∆ÎAligmentToolStripMenuItem,
            this.buildToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ±‡º≠EditToolStripMenuItem
            // 
            this.±‡º≠EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete,
            this.tsmiSelectAll});
            this.±‡º≠EditToolStripMenuItem.Name = "±‡º≠EditToolStripMenuItem";
            this.±‡º≠EditToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.±‡º≠EditToolStripMenuItem.Text = "±‡º≠(&Edit)";
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(128, 22);
            this.tsmiDelete.Text = "&Delete";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.Size = new System.Drawing.Size(128, 22);
            this.tsmiSelectAll.Text = "Select &All";
            this.tsmiSelectAll.Click += new System.EventHandler(this.tsmiSelectAll_Click);
            // 
            // ∂‘∆ÎAligmentToolStripMenuItem
            // 
            this.∂‘∆ÎAligmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLeft,
            this.tsmiCenter,
            this.tsmiRight,
            this.toolStripMenuItem1,
            this.tsmiTop,
            this.tsmiMiddle,
            this.tsmiBottom});
            this.∂‘∆ÎAligmentToolStripMenuItem.Name = "∂‘∆ÎAligmentToolStripMenuItem";
            this.∂‘∆ÎAligmentToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.∂‘∆ÎAligmentToolStripMenuItem.Text = "∂‘∆Î(&Align)";
            // 
            // tsmiLeft
            // 
            this.tsmiLeft.Name = "tsmiLeft";
            this.tsmiLeft.Size = new System.Drawing.Size(119, 22);
            this.tsmiLeft.Text = "&Left";
            this.tsmiLeft.Click += new System.EventHandler(this.tsmiLeft_Click);
            // 
            // tsmiCenter
            // 
            this.tsmiCenter.Name = "tsmiCenter";
            this.tsmiCenter.Size = new System.Drawing.Size(119, 22);
            this.tsmiCenter.Text = "&Center";
            this.tsmiCenter.Click += new System.EventHandler(this.tsmiCenter_Click);
            // 
            // tsmiRight
            // 
            this.tsmiRight.Name = "tsmiRight";
            this.tsmiRight.Size = new System.Drawing.Size(119, 22);
            this.tsmiRight.Text = "&Right";
            this.tsmiRight.Click += new System.EventHandler(this.tsmiRight_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(116, 6);
            // 
            // tsmiTop
            // 
            this.tsmiTop.Name = "tsmiTop";
            this.tsmiTop.Size = new System.Drawing.Size(119, 22);
            this.tsmiTop.Text = "&Top";
            this.tsmiTop.Click += new System.EventHandler(this.tsmiTop_Click);
            // 
            // tsmiMiddle
            // 
            this.tsmiMiddle.Name = "tsmiMiddle";
            this.tsmiMiddle.Size = new System.Drawing.Size(119, 22);
            this.tsmiMiddle.Text = "&Middle";
            this.tsmiMiddle.Click += new System.EventHandler(this.tsmiMiddle_Click);
            // 
            // tsmiBottom
            // 
            this.tsmiBottom.Name = "tsmiBottom";
            this.tsmiBottom.Size = new System.Drawing.Size(119, 22);
            this.tsmiBottom.Text = "&Bottom";
            this.tsmiBottom.Click += new System.EventHandler(this.tsmiBottom_Click);
            // 
            // buildToolStripMenuItem
            // 
            this.buildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRun});
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            this.buildToolStripMenuItem.Size = new System.Drawing.Size(49, 21);
            this.buildToolStripMenuItem.Text = "&Build";
            // 
            // tsmiRun
            // 
            this.tsmiRun.Name = "tsmiRun";
            this.tsmiRun.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmiRun.Size = new System.Drawing.Size(119, 22);
            this.tsmiRun.Text = "&Run";
            this.tsmiRun.Click += new System.EventHandler(this.tsmiRun_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 446);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlToolBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.tabContent.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ∂‘∆ÎAligmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiLeft;
        private System.Windows.Forms.ToolStripMenuItem tsmiCenter;
        private System.Windows.Forms.ToolStripMenuItem tsmiRight;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTop;
        private System.Windows.Forms.ToolStripMenuItem tsmiMiddle;
        private System.Windows.Forms.ToolStripMenuItem tsmiBottom;
        private System.Windows.Forms.ToolStripMenuItem ±‡º≠EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbControls;
        private System.Windows.Forms.Panel pnlPropertyGrid;
        private System.Windows.Forms.TabControl tabContent;
        private System.Windows.Forms.TabPage tpDesign;
        private System.Windows.Forms.TabPage tpCode;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiRun;
    }
}