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
            this.components = new System.ComponentModel.Container();
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
            this.tPCom = new System.Windows.Forms.TabPage();
            this.btnDownLoad = new System.Windows.Forms.Button();
            this.btnOpenCom = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comParity = new System.Windows.Forms.ComboBox();
            this.comStopBit = new System.Windows.Forms.ComboBox();
            this.comDataBit = new System.Windows.Forms.ComboBox();
            this.comBaudRate = new System.Windows.Forms.ComboBox();
            this.comPortName = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.编辑EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.对齐AligmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRight = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMiddle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBottom = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRun = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.tabContent.SuspendLayout();
            this.tPCom.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolBox
            // 
            this.pnlToolBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlToolBox.Location = new System.Drawing.Point(0, 25);
            this.pnlToolBox.Name = "pnlToolBox";
            this.pnlToolBox.Size = new System.Drawing.Size(158, 434);
            this.pnlToolBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlPropertyGrid);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(663, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 434);
            this.panel2.TabIndex = 1;
            // 
            // pnlPropertyGrid
            // 
            this.pnlPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPropertyGrid.Location = new System.Drawing.Point(0, 23);
            this.pnlPropertyGrid.Name = "pnlPropertyGrid";
            this.pnlPropertyGrid.Size = new System.Drawing.Size(195, 411);
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
            this.splitter1.Size = new System.Drawing.Size(10, 434);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(660, 25);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 434);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tabContent);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(168, 25);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(492, 434);
            this.pnlContent.TabIndex = 4;
            // 
            // tabContent
            // 
            this.tabContent.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabContent.Controls.Add(this.tpDesign);
            this.tabContent.Controls.Add(this.tpCode);
            this.tabContent.Controls.Add(this.tPCom);
            this.tabContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContent.Location = new System.Drawing.Point(0, 0);
            this.tabContent.Name = "tabContent";
            this.tabContent.SelectedIndex = 0;
            this.tabContent.Size = new System.Drawing.Size(492, 434);
            this.tabContent.TabIndex = 0;
            this.tabContent.SelectedIndexChanged += new System.EventHandler(this.tabContent_SelectedIndexChanged);
            // 
            // tpDesign
            // 
            this.tpDesign.Location = new System.Drawing.Point(4, 4);
            this.tpDesign.Name = "tpDesign";
            this.tpDesign.Padding = new System.Windows.Forms.Padding(3);
            this.tpDesign.Size = new System.Drawing.Size(484, 408);
            this.tpDesign.TabIndex = 0;
            this.tpDesign.Text = "设计";
            this.tpDesign.UseVisualStyleBackColor = true;
            // 
            // tpCode
            // 
            this.tpCode.Location = new System.Drawing.Point(4, 4);
            this.tpCode.Name = "tpCode";
            this.tpCode.Padding = new System.Windows.Forms.Padding(3);
            this.tpCode.Size = new System.Drawing.Size(484, 408);
            this.tpCode.TabIndex = 1;
            this.tpCode.Text = "Code";
            this.tpCode.UseVisualStyleBackColor = true;
            // 
            // tPCom
            // 
            this.tPCom.Controls.Add(this.btnDownLoad);
            this.tPCom.Controls.Add(this.btnOpenCom);
            this.tPCom.Controls.Add(this.groupBox1);
            this.tPCom.Location = new System.Drawing.Point(4, 4);
            this.tPCom.Name = "tPCom";
            this.tPCom.Padding = new System.Windows.Forms.Padding(3);
            this.tPCom.Size = new System.Drawing.Size(484, 408);
            this.tPCom.TabIndex = 2;
            this.tPCom.Text = "串口下载";
            this.tPCom.UseVisualStyleBackColor = true;
            // 
            // btnDownLoad
            // 
            this.btnDownLoad.Location = new System.Drawing.Point(229, 169);
            this.btnDownLoad.Name = "btnDownLoad";
            this.btnDownLoad.Size = new System.Drawing.Size(75, 34);
            this.btnDownLoad.TabIndex = 3;
            this.btnDownLoad.Text = "下载";
            this.btnDownLoad.UseVisualStyleBackColor = true;
            this.btnDownLoad.Click += new System.EventHandler(this.btnDownLoad_Click);
            // 
            // btnOpenCom
            // 
            this.btnOpenCom.Location = new System.Drawing.Point(118, 169);
            this.btnOpenCom.Name = "btnOpenCom";
            this.btnOpenCom.Size = new System.Drawing.Size(79, 34);
            this.btnOpenCom.TabIndex = 2;
            this.btnOpenCom.Text = "打开端口";
            this.btnOpenCom.UseVisualStyleBackColor = true;
            this.btnOpenCom.Click += new System.EventHandler(this.btnOpenCom_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comParity);
            this.groupBox1.Controls.Add(this.comStopBit);
            this.groupBox1.Controls.Add(this.comDataBit);
            this.groupBox1.Controls.Add(this.comBaudRate);
            this.groupBox1.Controls.Add(this.comPortName);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "端口设置";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "奇偶校验";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "停止位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "数据位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口选择";
            // 
            // comParity
            // 
            this.comParity.FormattingEnabled = true;
            this.comParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.comParity.Location = new System.Drawing.Point(314, 54);
            this.comParity.Name = "comParity";
            this.comParity.Size = new System.Drawing.Size(57, 20);
            this.comParity.TabIndex = 0;
            this.comParity.Text = "Even";
            // 
            // comStopBit
            // 
            this.comStopBit.FormattingEnabled = true;
            this.comStopBit.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comStopBit.Location = new System.Drawing.Point(241, 54);
            this.comStopBit.Name = "comStopBit";
            this.comStopBit.Size = new System.Drawing.Size(57, 20);
            this.comStopBit.TabIndex = 0;
            this.comStopBit.Text = "1";
            // 
            // comDataBit
            // 
            this.comDataBit.FormattingEnabled = true;
            this.comDataBit.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.comDataBit.Location = new System.Drawing.Point(173, 54);
            this.comDataBit.Name = "comDataBit";
            this.comDataBit.Size = new System.Drawing.Size(57, 20);
            this.comDataBit.TabIndex = 0;
            this.comDataBit.Text = "8";
            // 
            // comBaudRate
            // 
            this.comBaudRate.AutoCompleteCustomSource.AddRange(new string[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "115200"});
            this.comBaudRate.FormattingEnabled = true;
            this.comBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200"});
            this.comBaudRate.Location = new System.Drawing.Point(103, 54);
            this.comBaudRate.Name = "comBaudRate";
            this.comBaudRate.Size = new System.Drawing.Size(57, 20);
            this.comBaudRate.TabIndex = 0;
            this.comBaudRate.Text = "9600";
            // 
            // comPortName
            // 
            this.comPortName.FormattingEnabled = true;
            this.comPortName.Location = new System.Drawing.Point(25, 54);
            this.comPortName.Name = "comPortName";
            this.comPortName.Size = new System.Drawing.Size(57, 20);
            this.comPortName.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑EditToolStripMenuItem,
            this.对齐AligmentToolStripMenuItem,
            this.buildToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 编辑EditToolStripMenuItem
            // 
            this.编辑EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete,
            this.tsmiSelectAll});
            this.编辑EditToolStripMenuItem.Name = "编辑EditToolStripMenuItem";
            this.编辑EditToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.编辑EditToolStripMenuItem.Text = "编辑(&Edit)";
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
            // 对齐AligmentToolStripMenuItem
            // 
            this.对齐AligmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLeft,
            this.tsmiCenter,
            this.tsmiRight,
            this.toolStripMenuItem1,
            this.tsmiTop,
            this.tsmiMiddle,
            this.tsmiBottom});
            this.对齐AligmentToolStripMenuItem.Name = "对齐AligmentToolStripMenuItem";
            this.对齐AligmentToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.对齐AligmentToolStripMenuItem.Text = "对齐(&Align)";
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
            this.ClientSize = new System.Drawing.Size(858, 459);
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
            this.tPCom.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem 对齐AligmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiLeft;
        private System.Windows.Forms.ToolStripMenuItem tsmiCenter;
        private System.Windows.Forms.ToolStripMenuItem tsmiRight;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTop;
        private System.Windows.Forms.ToolStripMenuItem tsmiMiddle;
        private System.Windows.Forms.ToolStripMenuItem tsmiBottom;
        private System.Windows.Forms.ToolStripMenuItem 编辑EditToolStripMenuItem;
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
        private System.Windows.Forms.TabPage tPCom;
        private System.Windows.Forms.Button btnDownLoad;
        private System.Windows.Forms.Button btnOpenCom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comParity;
        private System.Windows.Forms.ComboBox comStopBit;
        private System.Windows.Forms.ComboBox comDataBit;
        private System.Windows.Forms.ComboBox comBaudRate;
        private System.Windows.Forms.ComboBox comPortName;
        private System.IO.Ports.SerialPort serialPort1;
    }
}