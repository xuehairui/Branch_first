namespace Branch.com.proem.exm.window.retreat
{
    partial class RGROperatorChoose
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
            this.operatorPanel = new System.Windows.Forms.Panel();
            this.queryResultGroupBox = new System.Windows.Forms.GroupBox();
            this.okButton = new System.Windows.Forms.Button();
            this.leaveButton = new System.Windows.Forms.Button();
            this.operatorTablePanel = new System.Windows.Forms.Panel();
            this.operatorDataGridView = new System.Windows.Forms.DataGridView();
            this.queryConditionGroupBox = new System.Windows.Forms.GroupBox();
            this.queryButton = new System.Windows.Forms.Button();
            this.operatorTextBox = new System.Windows.Forms.TextBox();
            this.operatorLabel = new System.Windows.Forms.Label();
            this.operatorPanel.SuspendLayout();
            this.queryResultGroupBox.SuspendLayout();
            this.operatorTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operatorDataGridView)).BeginInit();
            this.queryConditionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // operatorPanel
            // 
            this.operatorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operatorPanel.Controls.Add(this.queryResultGroupBox);
            this.operatorPanel.Controls.Add(this.queryConditionGroupBox);
            this.operatorPanel.Location = new System.Drawing.Point(0, 0);
            this.operatorPanel.Name = "operatorPanel";
            this.operatorPanel.Size = new System.Drawing.Size(583, 360);
            this.operatorPanel.TabIndex = 1;
            // 
            // queryResultGroupBox
            // 
            this.queryResultGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryResultGroupBox.Controls.Add(this.okButton);
            this.queryResultGroupBox.Controls.Add(this.leaveButton);
            this.queryResultGroupBox.Controls.Add(this.operatorTablePanel);
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
            // operatorTablePanel
            // 
            this.operatorTablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operatorTablePanel.Controls.Add(this.operatorDataGridView);
            this.operatorTablePanel.Location = new System.Drawing.Point(4, 19);
            this.operatorTablePanel.Name = "operatorTablePanel";
            this.operatorTablePanel.Size = new System.Drawing.Size(564, 240);
            this.operatorTablePanel.TabIndex = 0;
            // 
            // operatorDataGridView
            // 
            this.operatorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operatorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operatorDataGridView.Location = new System.Drawing.Point(0, 0);
            this.operatorDataGridView.Name = "operatorDataGridView";
            this.operatorDataGridView.RowTemplate.Height = 23;
            this.operatorDataGridView.Size = new System.Drawing.Size(564, 240);
            this.operatorDataGridView.TabIndex = 0;
            // 
            // queryConditionGroupBox
            // 
            this.queryConditionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryConditionGroupBox.Controls.Add(this.queryButton);
            this.queryConditionGroupBox.Controls.Add(this.operatorTextBox);
            this.queryConditionGroupBox.Controls.Add(this.operatorLabel);
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
            // operatorTextBox
            // 
            this.operatorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operatorTextBox.Font = new System.Drawing.Font("宋体", 14F);
            this.operatorTextBox.Location = new System.Drawing.Point(109, 15);
            this.operatorTextBox.Name = "operatorTextBox";
            this.operatorTextBox.Size = new System.Drawing.Size(354, 29);
            this.operatorTextBox.TabIndex = 29;
            // 
            // operatorLabel
            // 
            this.operatorLabel.AutoSize = true;
            this.operatorLabel.Font = new System.Drawing.Font("宋体", 14F);
            this.operatorLabel.Location = new System.Drawing.Point(24, 20);
            this.operatorLabel.Name = "operatorLabel";
            this.operatorLabel.Size = new System.Drawing.Size(85, 19);
            this.operatorLabel.TabIndex = 28;
            this.operatorLabel.Text = "操作员：";
            // 
            // RGROperatorChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.operatorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RGROperatorChoose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择操作员";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RGROperatorChoose_KeyDown);
            this.operatorPanel.ResumeLayout(false);
            this.queryResultGroupBox.ResumeLayout(false);
            this.operatorTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.operatorDataGridView)).EndInit();
            this.queryConditionGroupBox.ResumeLayout(false);
            this.queryConditionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel operatorPanel;
        private System.Windows.Forms.GroupBox queryResultGroupBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.Panel operatorTablePanel;
        private System.Windows.Forms.GroupBox queryConditionGroupBox;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.TextBox operatorTextBox;
        private System.Windows.Forms.Label operatorLabel;
        private System.Windows.Forms.DataGridView operatorDataGridView;
    }
}