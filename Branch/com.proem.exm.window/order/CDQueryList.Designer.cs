namespace Branch.com.proem.exm.window.order
{
    partial class CDQueryList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cDQueryListPanel = new System.Windows.Forms.Panel();
            this.listTablePanel = new System.Windows.Forms.Panel();
            this.listDataGridView = new System.Windows.Forms.DataGridView();
            this.ORDERNUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDERAMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONSIGNEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANSIGNPHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASSOCIATOR_CARDNUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cDQueryListPanel.SuspendLayout();
            this.listTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cDQueryListPanel
            // 
            this.cDQueryListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cDQueryListPanel.BackgroundImage = global::Branch.Properties.Resources.login_bg_0;
            this.cDQueryListPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cDQueryListPanel.Controls.Add(this.listTablePanel);
            this.cDQueryListPanel.Controls.Add(this.leaveButton);
            this.cDQueryListPanel.Controls.Add(this.okButton);
            this.cDQueryListPanel.Location = new System.Drawing.Point(0, 0);
            this.cDQueryListPanel.Name = "cDQueryListPanel";
            this.cDQueryListPanel.Size = new System.Drawing.Size(784, 461);
            this.cDQueryListPanel.TabIndex = 2;
            // 
            // listTablePanel
            // 
            this.listTablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listTablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(243)))));
            this.listTablePanel.Controls.Add(this.listDataGridView);
            this.listTablePanel.Location = new System.Drawing.Point(0, 0);
            this.listTablePanel.Name = "listTablePanel";
            this.listTablePanel.Size = new System.Drawing.Size(784, 381);
            this.listTablePanel.TabIndex = 2;
            // 
            // listDataGridView
            // 
            this.listDataGridView.AllowUserToAddRows = false;
            this.listDataGridView.AllowUserToDeleteRows = false;
            this.listDataGridView.AllowUserToResizeColumns = false;
            this.listDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.listDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.listDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.listDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.listDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 16F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ORDERNUM,
            this.ORDERAMOUNT,
            this.CONSIGNEE,
            this.CANSIGNPHONE,
            this.ASSOCIATOR_CARDNUMBER});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.listDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDataGridView.EnableHeadersVisualStyles = false;
            this.listDataGridView.Location = new System.Drawing.Point(0, 0);
            this.listDataGridView.MultiSelect = false;
            this.listDataGridView.Name = "listDataGridView";
            this.listDataGridView.ReadOnly = true;
            this.listDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listDataGridView.RowTemplate.Height = 23;
            this.listDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listDataGridView.Size = new System.Drawing.Size(784, 381);
            this.listDataGridView.TabIndex = 0;
            this.listDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listDataGridView_CellClick);
            this.listDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listDataGridView_CellDoubleClick);
            this.listDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.listDataGridView_RowPostPaint);
            // 
            // ORDERNUM
            // 
            this.ORDERNUM.DataPropertyName = "ORDERNUM";
            this.ORDERNUM.HeaderText = "订单号";
            this.ORDERNUM.Name = "ORDERNUM";
            this.ORDERNUM.ReadOnly = true;
            this.ORDERNUM.Width = 200;
            // 
            // ORDERAMOUNT
            // 
            this.ORDERAMOUNT.DataPropertyName = "ORDERAMOUNT";
            this.ORDERAMOUNT.HeaderText = "金额";
            this.ORDERAMOUNT.Name = "ORDERAMOUNT";
            this.ORDERAMOUNT.ReadOnly = true;
            this.ORDERAMOUNT.Width = 120;
            // 
            // CONSIGNEE
            // 
            this.CONSIGNEE.DataPropertyName = "CONSIGNEE";
            this.CONSIGNEE.HeaderText = "姓名";
            this.CONSIGNEE.Name = "CONSIGNEE";
            this.CONSIGNEE.ReadOnly = true;
            this.CONSIGNEE.Width = 120;
            // 
            // CANSIGNPHONE
            // 
            this.CANSIGNPHONE.DataPropertyName = "CANSIGNPHONE";
            this.CANSIGNPHONE.HeaderText = "电话";
            this.CANSIGNPHONE.Name = "CANSIGNPHONE";
            this.CANSIGNPHONE.ReadOnly = true;
            this.CANSIGNPHONE.Width = 120;
            // 
            // ASSOCIATOR_CARDNUMBER
            // 
            this.ASSOCIATOR_CARDNUMBER.DataPropertyName = "ASSOCIATOR_CARDNUMBER";
            this.ASSOCIATOR_CARDNUMBER.HeaderText = "卡号";
            this.ASSOCIATOR_CARDNUMBER.Name = "ASSOCIATOR_CARDNUMBER";
            this.ASSOCIATOR_CARDNUMBER.ReadOnly = true;
            this.ASSOCIATOR_CARDNUMBER.Width = 180;
            // 
            // leaveButton
            // 
            this.leaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.leaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.leaveButton.FlatAppearance.BorderSize = 0;
            this.leaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaveButton.ForeColor = System.Drawing.Color.White;
            this.leaveButton.Location = new System.Drawing.Point(407, 390);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(80, 35);
            this.leaveButton.TabIndex = 1;
            this.leaveButton.Text = "退出(L)";
            this.leaveButton.UseVisualStyleBackColor = false;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(297, 390);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(80, 35);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "确定(Y)";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // CDQueryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.cDQueryListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CDQueryList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择单据";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CDQueryList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CDQueryList_KeyDown);
            this.cDQueryListPanel.ResumeLayout(false);
            this.listTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cDQueryListPanel;
        private System.Windows.Forms.Panel listTablePanel;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.DataGridView listDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDERNUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDERAMOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONSIGNEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANSIGNPHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASSOCIATOR_CARDNUMBER;
    }
}