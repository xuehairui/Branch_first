namespace Branch.com.proem.exm.window.util
{
    partial class CDBShow
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
            this.cDBShowPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.showTablePanel = new System.Windows.Forms.Panel();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.PayMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDBShowPanel.SuspendLayout();
            this.showTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cDBShowPanel
            // 
            this.cDBShowPanel.Controls.Add(this.label1);
            this.cDBShowPanel.Controls.Add(this.showTablePanel);
            this.cDBShowPanel.Controls.Add(this.button1);
            this.cDBShowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cDBShowPanel.Location = new System.Drawing.Point(0, 0);
            this.cDBShowPanel.Name = "cDBShowPanel";
            this.cDBShowPanel.Size = new System.Drawing.Size(484, 361);
            this.cDBShowPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F);
            this.label1.Location = new System.Drawing.Point(189, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "支付明细";
            // 
            // showTablePanel
            // 
            this.showTablePanel.Controls.Add(this.showDataGridView);
            this.showTablePanel.Location = new System.Drawing.Point(92, 65);
            this.showTablePanel.Name = "showTablePanel";
            this.showTablePanel.Size = new System.Drawing.Size(300, 230);
            this.showTablePanel.TabIndex = 3;
            // 
            // showDataGridView
            // 
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PayMode,
            this.pay_amount});
            this.showDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showDataGridView.Location = new System.Drawing.Point(0, 0);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.RowTemplate.Height = 23;
            this.showDataGridView.Size = new System.Drawing.Size(300, 230);
            this.showDataGridView.TabIndex = 0;
            this.showDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.showDataGridView_RowPostPaint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PayMode
            // 
            this.PayMode.DataPropertyName = "pay_mode";
            this.PayMode.HeaderText = "支付方式";
            this.PayMode.Name = "PayMode";
            this.PayMode.Width = 120;
            // 
            // pay_amount
            // 
            this.pay_amount.DataPropertyName = "pay_amount";
            this.pay_amount.HeaderText = "支付金额";
            this.pay_amount.Name = "pay_amount";
            this.pay_amount.Width = 137;
            // 
            // CDBShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.cDBShowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CDBShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "支付明细";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CDBShow_Load);
            this.cDBShowPanel.ResumeLayout(false);
            this.cDBShowPanel.PerformLayout();
            this.showTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cDBShowPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel showTablePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay_amount;
    }
}