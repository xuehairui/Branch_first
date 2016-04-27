namespace Branch.com.proem.exm.window.retreat
{
    partial class RGBuyerChoose
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
            this.buyerPanel = new System.Windows.Forms.Panel();
            this.queryResultGroupBox = new System.Windows.Forms.GroupBox();
            this.okButton = new System.Windows.Forms.Button();
            this.leaveButton = new System.Windows.Forms.Button();
            this.buyerTablePanel = new System.Windows.Forms.Panel();
            this.queryConditionGroupBox = new System.Windows.Forms.GroupBox();
            this.queryButton = new System.Windows.Forms.Button();
            this.buyerLabel = new System.Windows.Forms.Label();
            this.buyerTextBox = new System.Windows.Forms.TextBox();
            this.buyerDataGridView = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerPanel.SuspendLayout();
            this.queryResultGroupBox.SuspendLayout();
            this.buyerTablePanel.SuspendLayout();
            this.queryConditionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buyerPanel
            // 
            this.buyerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buyerPanel.Controls.Add(this.queryResultGroupBox);
            this.buyerPanel.Controls.Add(this.queryConditionGroupBox);
            this.buyerPanel.Location = new System.Drawing.Point(0, 0);
            this.buyerPanel.Name = "buyerPanel";
            this.buyerPanel.Size = new System.Drawing.Size(583, 360);
            this.buyerPanel.TabIndex = 3;
            // 
            // queryResultGroupBox
            // 
            this.queryResultGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryResultGroupBox.Controls.Add(this.okButton);
            this.queryResultGroupBox.Controls.Add(this.leaveButton);
            this.queryResultGroupBox.Controls.Add(this.buyerTablePanel);
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
            // buyerTablePanel
            // 
            this.buyerTablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buyerTablePanel.Controls.Add(this.buyerDataGridView);
            this.buyerTablePanel.Location = new System.Drawing.Point(4, 19);
            this.buyerTablePanel.Name = "buyerTablePanel";
            this.buyerTablePanel.Size = new System.Drawing.Size(564, 240);
            this.buyerTablePanel.TabIndex = 0;
            // 
            // queryConditionGroupBox
            // 
            this.queryConditionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryConditionGroupBox.Controls.Add(this.queryButton);
            this.queryConditionGroupBox.Controls.Add(this.buyerLabel);
            this.queryConditionGroupBox.Controls.Add(this.buyerTextBox);
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
            this.queryButton.Location = new System.Drawing.Point(476, 15);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(85, 29);
            this.queryButton.TabIndex = 30;
            this.queryButton.Text = "查询";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // buyerLabel
            // 
            this.buyerLabel.AutoSize = true;
            this.buyerLabel.Font = new System.Drawing.Font("宋体", 14F);
            this.buyerLabel.Location = new System.Drawing.Point(24, 20);
            this.buyerLabel.Name = "buyerLabel";
            this.buyerLabel.Size = new System.Drawing.Size(85, 19);
            this.buyerLabel.TabIndex = 28;
            this.buyerLabel.Text = "采购员：";
            // 
            // buyerTextBox
            // 
            this.buyerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buyerTextBox.Font = new System.Drawing.Font("宋体", 14F);
            this.buyerTextBox.Location = new System.Drawing.Point(109, 15);
            this.buyerTextBox.Name = "buyerTextBox";
            this.buyerTextBox.Size = new System.Drawing.Size(354, 29);
            this.buyerTextBox.TabIndex = 29;
            // 
            // buyerDataGridView
            // 
            this.buyerDataGridView.AllowUserToAddRows = false;
            this.buyerDataGridView.AllowUserToDeleteRows = false;
            this.buyerDataGridView.AllowUserToResizeColumns = false;
            this.buyerDataGridView.AllowUserToResizeRows = false;
            this.buyerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.buyerDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.buyerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.buyerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.userId});
            this.buyerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buyerDataGridView.Location = new System.Drawing.Point(0, 0);
            this.buyerDataGridView.MultiSelect = false;
            this.buyerDataGridView.Name = "buyerDataGridView";
            this.buyerDataGridView.ReadOnly = true;
            this.buyerDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.buyerDataGridView.RowTemplate.Height = 23;
            this.buyerDataGridView.RowTemplate.ReadOnly = true;
            this.buyerDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.buyerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buyerDataGridView.ShowEditingIcon = false;
            this.buyerDataGridView.Size = new System.Drawing.Size(564, 240);
            this.buyerDataGridView.TabIndex = 1;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "采购员名字";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 90;
            // 
            // userId
            // 
            this.userId.DataPropertyName = "user_id";
            this.userId.HeaderText = "用户id";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            this.userId.Visible = false;
            this.userId.Width = 66;
            // 
            // RGBuyerChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.buyerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RGBuyerChoose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择采购员";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RGBuyerChoose_KeyDown);
            this.buyerPanel.ResumeLayout(false);
            this.queryResultGroupBox.ResumeLayout(false);
            this.buyerTablePanel.ResumeLayout(false);
            this.queryConditionGroupBox.ResumeLayout(false);
            this.queryConditionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buyerPanel;
        private System.Windows.Forms.GroupBox queryResultGroupBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.Panel buyerTablePanel;
        private System.Windows.Forms.GroupBox queryConditionGroupBox;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.TextBox buyerTextBox;
        private System.Windows.Forms.Label buyerLabel;
        private System.Windows.Forms.DataGridView buyerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
    }
}