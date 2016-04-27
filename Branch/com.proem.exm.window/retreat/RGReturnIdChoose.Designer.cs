namespace Branch.com.proem.exm.window.retreat
{
    partial class RGReturnIdChoose
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
            this.returnIdPanel = new System.Windows.Forms.Panel();
            this.queryResultGroupBox = new System.Windows.Forms.GroupBox();
            this.okButton = new System.Windows.Forms.Button();
            this.leaveButton = new System.Windows.Forms.Button();
            this.returnIdTablePanel = new System.Windows.Forms.Panel();
            this.returnIdDataGridView = new System.Windows.Forms.DataGridView();
            this.queryConditionGroupBox = new System.Windows.Forms.GroupBox();
            this.queryButton = new System.Windows.Forms.Button();
            this.returnIdTextBox = new System.Windows.Forms.TextBox();
            this.returnIdLabel = new System.Windows.Forms.Label();
            this.returnIdPanel.SuspendLayout();
            this.queryResultGroupBox.SuspendLayout();
            this.returnIdTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnIdDataGridView)).BeginInit();
            this.queryConditionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnIdPanel
            // 
            this.returnIdPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.returnIdPanel.Controls.Add(this.queryResultGroupBox);
            this.returnIdPanel.Controls.Add(this.queryConditionGroupBox);
            this.returnIdPanel.Location = new System.Drawing.Point(0, 0);
            this.returnIdPanel.Name = "returnIdPanel";
            this.returnIdPanel.Size = new System.Drawing.Size(583, 360);
            this.returnIdPanel.TabIndex = 3;
            // 
            // queryResultGroupBox
            // 
            this.queryResultGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryResultGroupBox.Controls.Add(this.okButton);
            this.queryResultGroupBox.Controls.Add(this.leaveButton);
            this.queryResultGroupBox.Controls.Add(this.returnIdTablePanel);
            this.queryResultGroupBox.Location = new System.Drawing.Point(5, 65);
            this.queryResultGroupBox.Name = "queryResultGroupBox";
            this.queryResultGroupBox.Size = new System.Drawing.Size(572, 292);
            this.queryResultGroupBox.TabIndex = 1;
            this.queryResultGroupBox.TabStop = false;
            this.queryResultGroupBox.Text = "查询结果";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(440, 264);
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
            this.leaveButton.Location = new System.Drawing.Point(506, 264);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(60, 22);
            this.leaveButton.TabIndex = 1;
            this.leaveButton.Text = "退出(L)";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // returnIdTablePanel
            // 
            this.returnIdTablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.returnIdTablePanel.Controls.Add(this.returnIdDataGridView);
            this.returnIdTablePanel.Location = new System.Drawing.Point(4, 19);
            this.returnIdTablePanel.Name = "returnIdTablePanel";
            this.returnIdTablePanel.Size = new System.Drawing.Size(564, 240);
            this.returnIdTablePanel.TabIndex = 0;
            // 
            // returnIdDataGridView
            // 
            this.returnIdDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnIdDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnIdDataGridView.Location = new System.Drawing.Point(0, 0);
            this.returnIdDataGridView.Name = "returnIdDataGridView";
            this.returnIdDataGridView.RowTemplate.Height = 23;
            this.returnIdDataGridView.Size = new System.Drawing.Size(564, 240);
            this.returnIdDataGridView.TabIndex = 0;
            // 
            // queryConditionGroupBox
            // 
            this.queryConditionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryConditionGroupBox.Controls.Add(this.queryButton);
            this.queryConditionGroupBox.Controls.Add(this.returnIdTextBox);
            this.queryConditionGroupBox.Controls.Add(this.returnIdLabel);
            this.queryConditionGroupBox.Location = new System.Drawing.Point(5, 2);
            this.queryConditionGroupBox.Name = "queryConditionGroupBox";
            this.queryConditionGroupBox.Size = new System.Drawing.Size(573, 58);
            this.queryConditionGroupBox.TabIndex = 0;
            this.queryConditionGroupBox.TabStop = false;
            this.queryConditionGroupBox.Text = "查询条件";
            // 
            // queryButton
            // 
            this.queryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.queryButton.Font = new System.Drawing.Font("宋体", 14F);
            this.queryButton.Location = new System.Drawing.Point(481, 15);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(55, 29);
            this.queryButton.TabIndex = 30;
            this.queryButton.Text = "查询";
            this.queryButton.UseVisualStyleBackColor = true;
            // 
            // returnIdTextBox
            // 
            this.returnIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.returnIdTextBox.Font = new System.Drawing.Font("宋体", 14F);
            this.returnIdTextBox.Location = new System.Drawing.Point(125, 15);
            this.returnIdTextBox.Name = "returnIdTextBox";
            this.returnIdTextBox.Size = new System.Drawing.Size(338, 29);
            this.returnIdTextBox.TabIndex = 29;
            // 
            // returnIdLabel
            // 
            this.returnIdLabel.AutoSize = true;
            this.returnIdLabel.Font = new System.Drawing.Font("宋体", 14F);
            this.returnIdLabel.Location = new System.Drawing.Point(24, 20);
            this.returnIdLabel.Name = "returnIdLabel";
            this.returnIdLabel.Size = new System.Drawing.Size(104, 19);
            this.returnIdLabel.TabIndex = 28;
            this.returnIdLabel.Text = "原始单号：";
            // 
            // RGReturnIdChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.returnIdPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RGReturnIdChoose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择原始单号";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RGReturnIdChoose_KeyDown);
            this.returnIdPanel.ResumeLayout(false);
            this.queryResultGroupBox.ResumeLayout(false);
            this.returnIdTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.returnIdDataGridView)).EndInit();
            this.queryConditionGroupBox.ResumeLayout(false);
            this.queryConditionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel returnIdPanel;
        private System.Windows.Forms.GroupBox queryResultGroupBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.Panel returnIdTablePanel;
        private System.Windows.Forms.GroupBox queryConditionGroupBox;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.TextBox returnIdTextBox;
        private System.Windows.Forms.Label returnIdLabel;
        private System.Windows.Forms.DataGridView returnIdDataGridView;
    }
}