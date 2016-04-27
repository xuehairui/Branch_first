namespace Branch.com.proem.exm.window.systemsetting
{
    partial class SystemSettings
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
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("系统操作日志");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("前台操作日志");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("系统日志", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            this.systemSettingsPanel = new System.Windows.Forms.Panel();
            this.queryLogPanel = new System.Windows.Forms.Panel();
            this.deskLogPanel = new System.Windows.Forms.Panel();
            this.queryResultDeskGroupBox = new System.Windows.Forms.GroupBox();
            this.logTableDeskPanel = new System.Windows.Forms.Panel();
            this.logDeskDataGridView = new System.Windows.Forms.DataGridView();
            this.titleDeskPanel = new System.Windows.Forms.Panel();
            this.leaveDeskButton = new System.Windows.Forms.Button();
            this.printDeskButton = new System.Windows.Forms.Button();
            this.setDeskButton = new System.Windows.Forms.Button();
            this.queryConditionDeskGroupBox = new System.Windows.Forms.GroupBox();
            this.endDeskDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDeskDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.queryDeskButton = new System.Windows.Forms.Button();
            this.operatorDeskButton = new System.Windows.Forms.Button();
            this.operatorDeskTextBox = new System.Windows.Forms.TextBox();
            this.operatorDeskLabel = new System.Windows.Forms.Label();
            this.endDateDeskLabel = new System.Windows.Forms.Label();
            this.startDateDeskLabel = new System.Windows.Forms.Label();
            this.systemLogPanel = new System.Windows.Forms.Panel();
            this.queryResultGroupBox = new System.Windows.Forms.GroupBox();
            this.logTablePanel = new System.Windows.Forms.Panel();
            this.logDataGridView = new System.Windows.Forms.DataGridView();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.leaveButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.setButton = new System.Windows.Forms.Button();
            this.queryConditionGroupBox = new System.Windows.Forms.GroupBox();
            this.functionTextBox = new System.Windows.Forms.TextBox();
            this.functionLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.queryButton = new System.Windows.Forms.Button();
            this.operatorButton = new System.Windows.Forms.Button();
            this.operatorTextBox = new System.Windows.Forms.TextBox();
            this.operatorLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.leftSplitter = new System.Windows.Forms.Splitter();
            this.categoryMessagePanel = new System.Windows.Forms.Panel();
            this.categoryMessageGroupBox = new System.Windows.Forms.GroupBox();
            this.logTreeView = new System.Windows.Forms.TreeView();
            this.timeNowDeskLabel = new System.Windows.Forms.Label();
            this.timeDeskPanel = new System.Windows.Forms.Panel();
            this.timeNowLabel = new System.Windows.Forms.Label();
            this.timePanel = new System.Windows.Forms.Panel();
            this.systemSettingsPanel.SuspendLayout();
            this.queryLogPanel.SuspendLayout();
            this.deskLogPanel.SuspendLayout();
            this.queryResultDeskGroupBox.SuspendLayout();
            this.logTableDeskPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logDeskDataGridView)).BeginInit();
            this.titleDeskPanel.SuspendLayout();
            this.queryConditionDeskGroupBox.SuspendLayout();
            this.systemLogPanel.SuspendLayout();
            this.queryResultGroupBox.SuspendLayout();
            this.logTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logDataGridView)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.queryConditionGroupBox.SuspendLayout();
            this.categoryMessagePanel.SuspendLayout();
            this.categoryMessageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // systemSettingsPanel
            // 
            this.systemSettingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.systemSettingsPanel.Controls.Add(this.queryLogPanel);
            this.systemSettingsPanel.Controls.Add(this.leftSplitter);
            this.systemSettingsPanel.Controls.Add(this.categoryMessagePanel);
            this.systemSettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.systemSettingsPanel.Name = "systemSettingsPanel";
            this.systemSettingsPanel.Size = new System.Drawing.Size(1000, 700);
            this.systemSettingsPanel.TabIndex = 0;
            // 
            // queryLogPanel
            // 
            this.queryLogPanel.Controls.Add(this.deskLogPanel);
            this.queryLogPanel.Controls.Add(this.systemLogPanel);
            this.queryLogPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryLogPanel.Location = new System.Drawing.Point(300, 0);
            this.queryLogPanel.Name = "queryLogPanel";
            this.queryLogPanel.Size = new System.Drawing.Size(700, 700);
            this.queryLogPanel.TabIndex = 4;
            // 
            // deskLogPanel
            // 
            this.deskLogPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deskLogPanel.Controls.Add(this.queryResultDeskGroupBox);
            this.deskLogPanel.Controls.Add(this.queryConditionDeskGroupBox);
            this.deskLogPanel.Location = new System.Drawing.Point(0, 0);
            this.deskLogPanel.Name = "deskLogPanel";
            this.deskLogPanel.Size = new System.Drawing.Size(700, 700);
            this.deskLogPanel.TabIndex = 1;
            // 
            // queryResultDeskGroupBox
            // 
            this.queryResultDeskGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryResultDeskGroupBox.Controls.Add(this.logTableDeskPanel);
            this.queryResultDeskGroupBox.Controls.Add(this.titleDeskPanel);
            this.queryResultDeskGroupBox.Font = new System.Drawing.Font("宋体", 12F);
            this.queryResultDeskGroupBox.Location = new System.Drawing.Point(10, 130);
            this.queryResultDeskGroupBox.Name = "queryResultDeskGroupBox";
            this.queryResultDeskGroupBox.Size = new System.Drawing.Size(680, 560);
            this.queryResultDeskGroupBox.TabIndex = 7;
            this.queryResultDeskGroupBox.TabStop = false;
            this.queryResultDeskGroupBox.Text = "查询结果";
            // 
            // logTableDeskPanel
            // 
            this.logTableDeskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTableDeskPanel.Controls.Add(this.logDeskDataGridView);
            this.logTableDeskPanel.Location = new System.Drawing.Point(5, 55);
            this.logTableDeskPanel.Name = "logTableDeskPanel";
            this.logTableDeskPanel.Size = new System.Drawing.Size(670, 500);
            this.logTableDeskPanel.TabIndex = 2;
            // 
            // logDeskDataGridView
            // 
            this.logDeskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logDeskDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logDeskDataGridView.Location = new System.Drawing.Point(0, 0);
            this.logDeskDataGridView.Name = "logDeskDataGridView";
            this.logDeskDataGridView.RowTemplate.Height = 23;
            this.logDeskDataGridView.Size = new System.Drawing.Size(670, 500);
            this.logDeskDataGridView.TabIndex = 0;
            // 
            // titleDeskPanel
            // 
            this.titleDeskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleDeskPanel.Controls.Add(this.leaveDeskButton);
            this.titleDeskPanel.Controls.Add(this.printDeskButton);
            this.titleDeskPanel.Controls.Add(this.setDeskButton);
            this.titleDeskPanel.Location = new System.Drawing.Point(5, 15);
            this.titleDeskPanel.Name = "titleDeskPanel";
            this.titleDeskPanel.Size = new System.Drawing.Size(670, 40);
            this.titleDeskPanel.TabIndex = 1;
            // 
            // leaveDeskButton
            // 
            this.leaveDeskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.leaveDeskButton.Font = new System.Drawing.Font("宋体", 9F);
            this.leaveDeskButton.Location = new System.Drawing.Point(533, 7);
            this.leaveDeskButton.Name = "leaveDeskButton";
            this.leaveDeskButton.Size = new System.Drawing.Size(121, 26);
            this.leaveDeskButton.TabIndex = 47;
            this.leaveDeskButton.Text = "返回主页面(Esc)";
            this.leaveDeskButton.UseVisualStyleBackColor = true;
            this.leaveDeskButton.Click += new System.EventHandler(this.leaveDeskButton_Click);
            // 
            // printDeskButton
            // 
            this.printDeskButton.Location = new System.Drawing.Point(100, 7);
            this.printDeskButton.Name = "printDeskButton";
            this.printDeskButton.Size = new System.Drawing.Size(55, 26);
            this.printDeskButton.TabIndex = 46;
            this.printDeskButton.Text = "打印";
            this.printDeskButton.UseVisualStyleBackColor = true;
            this.printDeskButton.Click += new System.EventHandler(this.printDeskButton_Click);
            // 
            // setDeskButton
            // 
            this.setDeskButton.Location = new System.Drawing.Point(25, 7);
            this.setDeskButton.Name = "setDeskButton";
            this.setDeskButton.Size = new System.Drawing.Size(55, 26);
            this.setDeskButton.TabIndex = 45;
            this.setDeskButton.Text = "设置";
            this.setDeskButton.UseVisualStyleBackColor = true;
            this.setDeskButton.Click += new System.EventHandler(this.setDeskButton_Click);
            // 
            // queryConditionDeskGroupBox
            // 
            this.queryConditionDeskGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryConditionDeskGroupBox.Controls.Add(this.timeNowDeskLabel);
            this.queryConditionDeskGroupBox.Controls.Add(this.timeDeskPanel);
            this.queryConditionDeskGroupBox.Controls.Add(this.endDeskDateTimePicker);
            this.queryConditionDeskGroupBox.Controls.Add(this.startDeskDateTimePicker);
            this.queryConditionDeskGroupBox.Controls.Add(this.queryDeskButton);
            this.queryConditionDeskGroupBox.Controls.Add(this.operatorDeskButton);
            this.queryConditionDeskGroupBox.Controls.Add(this.operatorDeskTextBox);
            this.queryConditionDeskGroupBox.Controls.Add(this.operatorDeskLabel);
            this.queryConditionDeskGroupBox.Controls.Add(this.endDateDeskLabel);
            this.queryConditionDeskGroupBox.Controls.Add(this.startDateDeskLabel);
            this.queryConditionDeskGroupBox.Font = new System.Drawing.Font("宋体", 12F);
            this.queryConditionDeskGroupBox.Location = new System.Drawing.Point(10, 10);
            this.queryConditionDeskGroupBox.Name = "queryConditionDeskGroupBox";
            this.queryConditionDeskGroupBox.Size = new System.Drawing.Size(680, 110);
            this.queryConditionDeskGroupBox.TabIndex = 6;
            this.queryConditionDeskGroupBox.TabStop = false;
            this.queryConditionDeskGroupBox.Text = "查询条件";
            // 
            // endDeskDateTimePicker
            // 
            this.endDeskDateTimePicker.Location = new System.Drawing.Point(400, 30);
            this.endDeskDateTimePicker.Name = "endDeskDateTimePicker";
            this.endDeskDateTimePicker.Size = new System.Drawing.Size(159, 26);
            this.endDeskDateTimePicker.TabIndex = 46;
            // 
            // startDeskDateTimePicker
            // 
            this.startDeskDateTimePicker.Location = new System.Drawing.Point(115, 30);
            this.startDeskDateTimePicker.Name = "startDeskDateTimePicker";
            this.startDeskDateTimePicker.Size = new System.Drawing.Size(159, 26);
            this.startDeskDateTimePicker.TabIndex = 45;
            // 
            // queryDeskButton
            // 
            this.queryDeskButton.Location = new System.Drawing.Point(504, 70);
            this.queryDeskButton.Name = "queryDeskButton";
            this.queryDeskButton.Size = new System.Drawing.Size(55, 26);
            this.queryDeskButton.TabIndex = 44;
            this.queryDeskButton.Text = "查询";
            this.queryDeskButton.UseVisualStyleBackColor = true;
            this.queryDeskButton.Click += new System.EventHandler(this.queryDeskButton_Click);
            // 
            // operatorDeskButton
            // 
            this.operatorDeskButton.Location = new System.Drawing.Point(411, 70);
            this.operatorDeskButton.Name = "operatorDeskButton";
            this.operatorDeskButton.Size = new System.Drawing.Size(32, 26);
            this.operatorDeskButton.TabIndex = 43;
            this.operatorDeskButton.Text = "…";
            this.operatorDeskButton.UseVisualStyleBackColor = true;
            this.operatorDeskButton.Click += new System.EventHandler(this.operatorDeskButton_Click);
            // 
            // operatorDeskTextBox
            // 
            this.operatorDeskTextBox.Location = new System.Drawing.Point(115, 70);
            this.operatorDeskTextBox.Name = "operatorDeskTextBox";
            this.operatorDeskTextBox.Size = new System.Drawing.Size(283, 26);
            this.operatorDeskTextBox.TabIndex = 42;
            // 
            // operatorDeskLabel
            // 
            this.operatorDeskLabel.AutoSize = true;
            this.operatorDeskLabel.Location = new System.Drawing.Point(27, 75);
            this.operatorDeskLabel.Name = "operatorDeskLabel";
            this.operatorDeskLabel.Size = new System.Drawing.Size(72, 16);
            this.operatorDeskLabel.TabIndex = 41;
            this.operatorDeskLabel.Text = "收银员：";
            // 
            // endDateDeskLabel
            // 
            this.endDateDeskLabel.AutoSize = true;
            this.endDateDeskLabel.Location = new System.Drawing.Point(310, 35);
            this.endDateDeskLabel.Name = "endDateDeskLabel";
            this.endDateDeskLabel.Size = new System.Drawing.Size(88, 16);
            this.endDateDeskLabel.TabIndex = 40;
            this.endDateDeskLabel.Text = "结束时间：";
            // 
            // startDateDeskLabel
            // 
            this.startDateDeskLabel.AutoSize = true;
            this.startDateDeskLabel.Location = new System.Drawing.Point(25, 35);
            this.startDateDeskLabel.Name = "startDateDeskLabel";
            this.startDateDeskLabel.Size = new System.Drawing.Size(88, 16);
            this.startDateDeskLabel.TabIndex = 39;
            this.startDateDeskLabel.Text = "开始时间：";
            // 
            // systemLogPanel
            // 
            this.systemLogPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.systemLogPanel.Controls.Add(this.queryResultGroupBox);
            this.systemLogPanel.Controls.Add(this.queryConditionGroupBox);
            this.systemLogPanel.Location = new System.Drawing.Point(0, 0);
            this.systemLogPanel.Name = "systemLogPanel";
            this.systemLogPanel.Size = new System.Drawing.Size(700, 700);
            this.systemLogPanel.TabIndex = 0;
            // 
            // queryResultGroupBox
            // 
            this.queryResultGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryResultGroupBox.Controls.Add(this.logTablePanel);
            this.queryResultGroupBox.Controls.Add(this.titlePanel);
            this.queryResultGroupBox.Font = new System.Drawing.Font("宋体", 12F);
            this.queryResultGroupBox.Location = new System.Drawing.Point(10, 130);
            this.queryResultGroupBox.Name = "queryResultGroupBox";
            this.queryResultGroupBox.Size = new System.Drawing.Size(680, 560);
            this.queryResultGroupBox.TabIndex = 3;
            this.queryResultGroupBox.TabStop = false;
            this.queryResultGroupBox.Text = "查询结果";
            // 
            // logTablePanel
            // 
            this.logTablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTablePanel.Controls.Add(this.logDataGridView);
            this.logTablePanel.Location = new System.Drawing.Point(5, 55);
            this.logTablePanel.Name = "logTablePanel";
            this.logTablePanel.Size = new System.Drawing.Size(670, 500);
            this.logTablePanel.TabIndex = 2;
            // 
            // logDataGridView
            // 
            this.logDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logDataGridView.Location = new System.Drawing.Point(0, 0);
            this.logDataGridView.Name = "logDataGridView";
            this.logDataGridView.RowTemplate.Height = 23;
            this.logDataGridView.Size = new System.Drawing.Size(670, 500);
            this.logDataGridView.TabIndex = 0;
            // 
            // titlePanel
            // 
            this.titlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titlePanel.Controls.Add(this.leaveButton);
            this.titlePanel.Controls.Add(this.printButton);
            this.titlePanel.Controls.Add(this.setButton);
            this.titlePanel.Location = new System.Drawing.Point(5, 15);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(670, 40);
            this.titlePanel.TabIndex = 1;
            // 
            // leaveButton
            // 
            this.leaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.leaveButton.Font = new System.Drawing.Font("宋体", 9F);
            this.leaveButton.Location = new System.Drawing.Point(533, 7);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(121, 26);
            this.leaveButton.TabIndex = 47;
            this.leaveButton.Text = "返回主页面(Esc)";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(100, 7);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(55, 26);
            this.printButton.TabIndex = 46;
            this.printButton.Text = "打印";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(25, 7);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(55, 26);
            this.setButton.TabIndex = 45;
            this.setButton.Text = "设置";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // queryConditionGroupBox
            // 
            this.queryConditionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryConditionGroupBox.Controls.Add(this.timeNowLabel);
            this.queryConditionGroupBox.Controls.Add(this.timePanel);
            this.queryConditionGroupBox.Controls.Add(this.functionTextBox);
            this.queryConditionGroupBox.Controls.Add(this.functionLabel);
            this.queryConditionGroupBox.Controls.Add(this.endDateTimePicker);
            this.queryConditionGroupBox.Controls.Add(this.startDateTimePicker);
            this.queryConditionGroupBox.Controls.Add(this.queryButton);
            this.queryConditionGroupBox.Controls.Add(this.operatorButton);
            this.queryConditionGroupBox.Controls.Add(this.operatorTextBox);
            this.queryConditionGroupBox.Controls.Add(this.operatorLabel);
            this.queryConditionGroupBox.Controls.Add(this.endDateLabel);
            this.queryConditionGroupBox.Controls.Add(this.startDateLabel);
            this.queryConditionGroupBox.Font = new System.Drawing.Font("宋体", 12F);
            this.queryConditionGroupBox.Location = new System.Drawing.Point(10, 10);
            this.queryConditionGroupBox.Name = "queryConditionGroupBox";
            this.queryConditionGroupBox.Size = new System.Drawing.Size(680, 110);
            this.queryConditionGroupBox.TabIndex = 2;
            this.queryConditionGroupBox.TabStop = false;
            this.queryConditionGroupBox.Text = "查询条件";
            // 
            // functionTextBox
            // 
            this.functionTextBox.Location = new System.Drawing.Point(400, 30);
            this.functionTextBox.Name = "functionTextBox";
            this.functionTextBox.Size = new System.Drawing.Size(170, 26);
            this.functionTextBox.TabIndex = 48;
            // 
            // functionLabel
            // 
            this.functionLabel.AutoSize = true;
            this.functionLabel.Location = new System.Drawing.Point(335, 35);
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size(56, 16);
            this.functionLabel.TabIndex = 47;
            this.functionLabel.Text = "功能：";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(115, 65);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(159, 26);
            this.endDateTimePicker.TabIndex = 46;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(115, 30);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(159, 26);
            this.startDateTimePicker.TabIndex = 45;
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(619, 30);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(55, 26);
            this.queryButton.TabIndex = 44;
            this.queryButton.Text = "查询";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // operatorButton
            // 
            this.operatorButton.Location = new System.Drawing.Point(538, 65);
            this.operatorButton.Name = "operatorButton";
            this.operatorButton.Size = new System.Drawing.Size(32, 26);
            this.operatorButton.TabIndex = 43;
            this.operatorButton.Text = "…";
            this.operatorButton.UseVisualStyleBackColor = true;
            this.operatorButton.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // operatorTextBox
            // 
            this.operatorTextBox.Location = new System.Drawing.Point(400, 65);
            this.operatorTextBox.Name = "operatorTextBox";
            this.operatorTextBox.Size = new System.Drawing.Size(130, 26);
            this.operatorTextBox.TabIndex = 42;
            // 
            // operatorLabel
            // 
            this.operatorLabel.AutoSize = true;
            this.operatorLabel.Location = new System.Drawing.Point(335, 70);
            this.operatorLabel.Name = "operatorLabel";
            this.operatorLabel.Size = new System.Drawing.Size(72, 16);
            this.operatorLabel.TabIndex = 41;
            this.operatorLabel.Text = "操作员：";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(25, 70);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(88, 16);
            this.endDateLabel.TabIndex = 40;
            this.endDateLabel.Text = "结束时间：";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(25, 35);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(88, 16);
            this.startDateLabel.TabIndex = 39;
            this.startDateLabel.Text = "开始时间：";
            // 
            // leftSplitter
            // 
            this.leftSplitter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.leftSplitter.Location = new System.Drawing.Point(290, 0);
            this.leftSplitter.Name = "leftSplitter";
            this.leftSplitter.Size = new System.Drawing.Size(10, 700);
            this.leftSplitter.TabIndex = 3;
            this.leftSplitter.TabStop = false;
            // 
            // categoryMessagePanel
            // 
            this.categoryMessagePanel.Controls.Add(this.categoryMessageGroupBox);
            this.categoryMessagePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.categoryMessagePanel.Location = new System.Drawing.Point(0, 0);
            this.categoryMessagePanel.Name = "categoryMessagePanel";
            this.categoryMessagePanel.Size = new System.Drawing.Size(290, 700);
            this.categoryMessagePanel.TabIndex = 2;
            // 
            // categoryMessageGroupBox
            // 
            this.categoryMessageGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.categoryMessageGroupBox.Controls.Add(this.logTreeView);
            this.categoryMessageGroupBox.Font = new System.Drawing.Font("宋体", 12F);
            this.categoryMessageGroupBox.Location = new System.Drawing.Point(10, 10);
            this.categoryMessageGroupBox.Name = "categoryMessageGroupBox";
            this.categoryMessageGroupBox.Size = new System.Drawing.Size(270, 680);
            this.categoryMessageGroupBox.TabIndex = 0;
            this.categoryMessageGroupBox.TabStop = false;
            this.categoryMessageGroupBox.Text = "分类信息";
            // 
            // logTreeView
            // 
            this.logTreeView.BackColor = System.Drawing.SystemColors.Window;
            this.logTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTreeView.Location = new System.Drawing.Point(3, 22);
            this.logTreeView.Name = "logTreeView";
            treeNode19.Name = "systemLog";
            treeNode19.Text = "系统操作日志";
            treeNode20.Name = "deskLog";
            treeNode20.Text = "前台操作日志";
            treeNode21.Name = "log";
            treeNode21.Text = "系统日志";
            this.logTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21});
            this.logTreeView.Size = new System.Drawing.Size(264, 655);
            this.logTreeView.TabIndex = 0;
            this.logTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.logTreeView_AfterSelect);
            // 
            // timeNowDeskLabel
            // 
            this.timeNowDeskLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeNowDeskLabel.AutoSize = true;
            this.timeNowDeskLabel.Font = new System.Drawing.Font("宋体", 9F);
            this.timeNowDeskLabel.Location = new System.Drawing.Point(476, 40);
            this.timeNowDeskLabel.Name = "timeNowDeskLabel";
            this.timeNowDeskLabel.Size = new System.Drawing.Size(65, 12);
            this.timeNowDeskLabel.TabIndex = 48;
            this.timeNowDeskLabel.Text = "当前时间：";
            // 
            // timeDeskPanel
            // 
            this.timeDeskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeDeskPanel.Font = new System.Drawing.Font("宋体", 9F);
            this.timeDeskPanel.Location = new System.Drawing.Point(541, 30);
            this.timeDeskPanel.Name = "timeDeskPanel";
            this.timeDeskPanel.Size = new System.Drawing.Size(119, 32);
            this.timeDeskPanel.TabIndex = 47;
            // 
            // timeNowLabel
            // 
            this.timeNowLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeNowLabel.AutoSize = true;
            this.timeNowLabel.Font = new System.Drawing.Font("宋体", 9F);
            this.timeNowLabel.Location = new System.Drawing.Point(476, 40);
            this.timeNowLabel.Name = "timeNowLabel";
            this.timeNowLabel.Size = new System.Drawing.Size(65, 12);
            this.timeNowLabel.TabIndex = 50;
            this.timeNowLabel.Text = "当前时间：";
            // 
            // timePanel
            // 
            this.timePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timePanel.Font = new System.Drawing.Font("宋体", 9F);
            this.timePanel.Location = new System.Drawing.Point(541, 30);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(119, 32);
            this.timePanel.TabIndex = 49;
            // 
            // SystemSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.systemSettingsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "SystemSettings";
            this.Text = "系统设置";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SystemSettings_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SystemSettings_KeyDown);
            this.systemSettingsPanel.ResumeLayout(false);
            this.queryLogPanel.ResumeLayout(false);
            this.deskLogPanel.ResumeLayout(false);
            this.queryResultDeskGroupBox.ResumeLayout(false);
            this.logTableDeskPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logDeskDataGridView)).EndInit();
            this.titleDeskPanel.ResumeLayout(false);
            this.queryConditionDeskGroupBox.ResumeLayout(false);
            this.queryConditionDeskGroupBox.PerformLayout();
            this.systemLogPanel.ResumeLayout(false);
            this.queryResultGroupBox.ResumeLayout(false);
            this.logTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logDataGridView)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.queryConditionGroupBox.ResumeLayout(false);
            this.queryConditionGroupBox.PerformLayout();
            this.categoryMessagePanel.ResumeLayout(false);
            this.categoryMessageGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel systemSettingsPanel;
        private System.Windows.Forms.Panel categoryMessagePanel;
        private System.Windows.Forms.Splitter leftSplitter;
        private System.Windows.Forms.GroupBox categoryMessageGroupBox;
        private System.Windows.Forms.Panel queryLogPanel;
        private System.Windows.Forms.TreeView logTreeView;
        private System.Windows.Forms.Panel systemLogPanel;
        private System.Windows.Forms.GroupBox queryResultGroupBox;
        private System.Windows.Forms.Panel logTablePanel;
        private System.Windows.Forms.DataGridView logDataGridView;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.GroupBox queryConditionGroupBox;
        private System.Windows.Forms.TextBox functionTextBox;
        private System.Windows.Forms.Label functionLabel;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.Button operatorButton;
        private System.Windows.Forms.TextBox operatorTextBox;
        private System.Windows.Forms.Label operatorLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Panel deskLogPanel;
        private System.Windows.Forms.GroupBox queryResultDeskGroupBox;
        private System.Windows.Forms.Panel logTableDeskPanel;
        private System.Windows.Forms.DataGridView logDeskDataGridView;
        private System.Windows.Forms.Panel titleDeskPanel;
        private System.Windows.Forms.Button leaveDeskButton;
        private System.Windows.Forms.Button printDeskButton;
        private System.Windows.Forms.Button setDeskButton;
        private System.Windows.Forms.GroupBox queryConditionDeskGroupBox;
        private System.Windows.Forms.DateTimePicker endDeskDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDeskDateTimePicker;
        private System.Windows.Forms.Button queryDeskButton;
        private System.Windows.Forms.Button operatorDeskButton;
        private System.Windows.Forms.TextBox operatorDeskTextBox;
        private System.Windows.Forms.Label operatorDeskLabel;
        private System.Windows.Forms.Label endDateDeskLabel;
        private System.Windows.Forms.Label startDateDeskLabel;
        private System.Windows.Forms.Label timeNowDeskLabel;
        private System.Windows.Forms.Panel timeDeskPanel;
        private System.Windows.Forms.Label timeNowLabel;
        private System.Windows.Forms.Panel timePanel;
    }
}