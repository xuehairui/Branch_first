namespace Branch.com.proem.exm.window.retreat
{
    partial class RGReturnList
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
            this.rGReturnListPanel = new System.Windows.Forms.Panel();
            this.queryResultGroupBox = new System.Windows.Forms.GroupBox();
            this.okButton = new System.Windows.Forms.Button();
            this.leaveButton = new System.Windows.Forms.Button();
            this.returnTablePanel = new System.Windows.Forms.Panel();
            this.returnDataGridView = new System.Windows.Forms.DataGridView();
            this.queryConditionGroupBox = new System.Windows.Forms.GroupBox();
            this.warehouseButton = new System.Windows.Forms.Button();
            this.warehouseTextBox = new System.Windows.Forms.TextBox();
            this.warehouseLabel = new System.Windows.Forms.Label();
            this.supplierButton = new System.Windows.Forms.Button();
            this.supplierIdTextBox = new System.Windows.Forms.TextBox();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.queryButton = new System.Windows.Forms.Button();
            this.moneyTextBox = new System.Windows.Forms.TextBox();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.operatorButton = new System.Windows.Forms.Button();
            this.operatorTextBox = new System.Windows.Forms.TextBox();
            this.operatorLabel = new System.Windows.Forms.Label();
            this.docketIdTextBox = new System.Windows.Forms.TextBox();
            this.docketIdLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.rGReturnListPanel.SuspendLayout();
            this.queryResultGroupBox.SuspendLayout();
            this.returnTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnDataGridView)).BeginInit();
            this.queryConditionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // rGReturnListPanel
            // 
            this.rGReturnListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rGReturnListPanel.Controls.Add(this.queryResultGroupBox);
            this.rGReturnListPanel.Controls.Add(this.queryConditionGroupBox);
            this.rGReturnListPanel.Location = new System.Drawing.Point(0, 0);
            this.rGReturnListPanel.Name = "rGReturnListPanel";
            this.rGReturnListPanel.Size = new System.Drawing.Size(784, 461);
            this.rGReturnListPanel.TabIndex = 1;
            // 
            // queryResultGroupBox
            // 
            this.queryResultGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryResultGroupBox.Controls.Add(this.okButton);
            this.queryResultGroupBox.Controls.Add(this.leaveButton);
            this.queryResultGroupBox.Controls.Add(this.returnTablePanel);
            this.queryResultGroupBox.Location = new System.Drawing.Point(5, 115);
            this.queryResultGroupBox.Name = "queryResultGroupBox";
            this.queryResultGroupBox.Size = new System.Drawing.Size(776, 341);
            this.queryResultGroupBox.TabIndex = 1;
            this.queryResultGroupBox.TabStop = false;
            this.queryResultGroupBox.Text = "查询结果";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(644, 312);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(60, 22);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "确定(Y)";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // leaveButton
            // 
            this.leaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.leaveButton.Location = new System.Drawing.Point(710, 312);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(60, 22);
            this.leaveButton.TabIndex = 1;
            this.leaveButton.Text = "退出(L)";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // returnTablePanel
            // 
            this.returnTablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.returnTablePanel.Controls.Add(this.returnDataGridView);
            this.returnTablePanel.Location = new System.Drawing.Point(4, 19);
            this.returnTablePanel.Name = "returnTablePanel";
            this.returnTablePanel.Size = new System.Drawing.Size(768, 288);
            this.returnTablePanel.TabIndex = 0;
            // 
            // returnDataGridView
            // 
            this.returnDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnDataGridView.Location = new System.Drawing.Point(0, 0);
            this.returnDataGridView.Name = "returnDataGridView";
            this.returnDataGridView.RowTemplate.Height = 23;
            this.returnDataGridView.Size = new System.Drawing.Size(768, 288);
            this.returnDataGridView.TabIndex = 0;
            // 
            // queryConditionGroupBox
            // 
            this.queryConditionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryConditionGroupBox.Controls.Add(this.warehouseButton);
            this.queryConditionGroupBox.Controls.Add(this.warehouseTextBox);
            this.queryConditionGroupBox.Controls.Add(this.warehouseLabel);
            this.queryConditionGroupBox.Controls.Add(this.supplierButton);
            this.queryConditionGroupBox.Controls.Add(this.supplierIdTextBox);
            this.queryConditionGroupBox.Controls.Add(this.supplierLabel);
            this.queryConditionGroupBox.Controls.Add(this.endDateTimePicker);
            this.queryConditionGroupBox.Controls.Add(this.startDateTimePicker);
            this.queryConditionGroupBox.Controls.Add(this.queryButton);
            this.queryConditionGroupBox.Controls.Add(this.moneyTextBox);
            this.queryConditionGroupBox.Controls.Add(this.moneyLabel);
            this.queryConditionGroupBox.Controls.Add(this.operatorButton);
            this.queryConditionGroupBox.Controls.Add(this.operatorTextBox);
            this.queryConditionGroupBox.Controls.Add(this.operatorLabel);
            this.queryConditionGroupBox.Controls.Add(this.docketIdTextBox);
            this.queryConditionGroupBox.Controls.Add(this.docketIdLabel);
            this.queryConditionGroupBox.Controls.Add(this.endDateLabel);
            this.queryConditionGroupBox.Controls.Add(this.startDateLabel);
            this.queryConditionGroupBox.Location = new System.Drawing.Point(5, 2);
            this.queryConditionGroupBox.Name = "queryConditionGroupBox";
            this.queryConditionGroupBox.Size = new System.Drawing.Size(776, 110);
            this.queryConditionGroupBox.TabIndex = 0;
            this.queryConditionGroupBox.TabStop = false;
            this.queryConditionGroupBox.Text = "查询条件";
            // 
            // warehouseButton
            // 
            this.warehouseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.warehouseButton.Enabled = false;
            this.warehouseButton.Location = new System.Drawing.Point(443, 19);
            this.warehouseButton.Name = "warehouseButton";
            this.warehouseButton.Size = new System.Drawing.Size(32, 21);
            this.warehouseButton.TabIndex = 39;
            this.warehouseButton.Text = "…";
            this.warehouseButton.UseVisualStyleBackColor = true;
            // 
            // warehouseTextBox
            // 
            this.warehouseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.warehouseTextBox.Location = new System.Drawing.Point(332, 19);
            this.warehouseTextBox.Name = "warehouseTextBox";
            this.warehouseTextBox.ReadOnly = true;
            this.warehouseTextBox.Size = new System.Drawing.Size(105, 21);
            this.warehouseTextBox.TabIndex = 38;
            // 
            // warehouseLabel
            // 
            this.warehouseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.warehouseLabel.AutoSize = true;
            this.warehouseLabel.Location = new System.Drawing.Point(269, 23);
            this.warehouseLabel.Name = "warehouseLabel";
            this.warehouseLabel.Size = new System.Drawing.Size(65, 12);
            this.warehouseLabel.TabIndex = 37;
            this.warehouseLabel.Text = "当前分店：";
            // 
            // supplierButton
            // 
            this.supplierButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.supplierButton.Location = new System.Drawing.Point(443, 48);
            this.supplierButton.Name = "supplierButton";
            this.supplierButton.Size = new System.Drawing.Size(32, 21);
            this.supplierButton.TabIndex = 36;
            this.supplierButton.Text = "…";
            this.supplierButton.UseVisualStyleBackColor = true;
            this.supplierButton.Click += new System.EventHandler(this.supplierButton_Click);
            // 
            // supplierIdTextBox
            // 
            this.supplierIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.supplierIdTextBox.Location = new System.Drawing.Point(332, 48);
            this.supplierIdTextBox.Name = "supplierIdTextBox";
            this.supplierIdTextBox.Size = new System.Drawing.Size(105, 21);
            this.supplierIdTextBox.TabIndex = 35;
            // 
            // supplierLabel
            // 
            this.supplierLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(269, 52);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(53, 12);
            this.supplierLabel.TabIndex = 34;
            this.supplierLabel.Text = "供应商：";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(76, 48);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(125, 21);
            this.endDateTimePicker.TabIndex = 33;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(76, 19);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(125, 21);
            this.startDateTimePicker.TabIndex = 32;
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(687, 75);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(55, 21);
            this.queryButton.TabIndex = 27;
            this.queryButton.Text = "查询";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.Location = new System.Drawing.Point(637, 19);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.Size = new System.Drawing.Size(105, 21);
            this.moneyTextBox.TabIndex = 25;
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(537, 23);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(83, 12);
            this.moneyLabel.TabIndex = 24;
            this.moneyLabel.Text = "单据金额   >=";
            // 
            // operatorButton
            // 
            this.operatorButton.Location = new System.Drawing.Point(710, 48);
            this.operatorButton.Name = "operatorButton";
            this.operatorButton.Size = new System.Drawing.Size(32, 21);
            this.operatorButton.TabIndex = 23;
            this.operatorButton.Text = "…";
            this.operatorButton.UseVisualStyleBackColor = true;
            this.operatorButton.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // operatorTextBox
            // 
            this.operatorTextBox.Location = new System.Drawing.Point(600, 48);
            this.operatorTextBox.Name = "operatorTextBox";
            this.operatorTextBox.Size = new System.Drawing.Size(105, 21);
            this.operatorTextBox.TabIndex = 22;
            // 
            // operatorLabel
            // 
            this.operatorLabel.AutoSize = true;
            this.operatorLabel.Location = new System.Drawing.Point(537, 52);
            this.operatorLabel.Name = "operatorLabel";
            this.operatorLabel.Size = new System.Drawing.Size(53, 12);
            this.operatorLabel.TabIndex = 21;
            this.operatorLabel.Text = "操作员：";
            // 
            // docketIdTextBox
            // 
            this.docketIdTextBox.Location = new System.Drawing.Point(76, 75);
            this.docketIdTextBox.Name = "docketIdTextBox";
            this.docketIdTextBox.Size = new System.Drawing.Size(544, 21);
            this.docketIdTextBox.TabIndex = 20;
            // 
            // docketIdLabel
            // 
            this.docketIdLabel.AutoSize = true;
            this.docketIdLabel.Location = new System.Drawing.Point(13, 79);
            this.docketIdLabel.Name = "docketIdLabel";
            this.docketIdLabel.Size = new System.Drawing.Size(41, 12);
            this.docketIdLabel.TabIndex = 19;
            this.docketIdLabel.Text = "单号：";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(10, 52);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(65, 12);
            this.endDateLabel.TabIndex = 17;
            this.endDateLabel.Text = "结束时间：";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(10, 23);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(65, 12);
            this.startDateLabel.TabIndex = 15;
            this.startDateLabel.Text = "开始时间：";
            // 
            // RGReturnList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.rGReturnListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RGReturnList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打开已有单据";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RGReturnList_KeyDown);
            this.rGReturnListPanel.ResumeLayout(false);
            this.queryResultGroupBox.ResumeLayout(false);
            this.returnTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.returnDataGridView)).EndInit();
            this.queryConditionGroupBox.ResumeLayout(false);
            this.queryConditionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rGReturnListPanel;
        private System.Windows.Forms.GroupBox queryResultGroupBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.Panel returnTablePanel;
        private System.Windows.Forms.DataGridView returnDataGridView;
        private System.Windows.Forms.GroupBox queryConditionGroupBox;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.TextBox moneyTextBox;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Button operatorButton;
        private System.Windows.Forms.TextBox operatorTextBox;
        private System.Windows.Forms.Label operatorLabel;
        private System.Windows.Forms.TextBox docketIdTextBox;
        private System.Windows.Forms.Label docketIdLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Button supplierButton;
        private System.Windows.Forms.TextBox supplierIdTextBox;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.Button warehouseButton;
        private System.Windows.Forms.TextBox warehouseTextBox;
        private System.Windows.Forms.Label warehouseLabel;
    }
}