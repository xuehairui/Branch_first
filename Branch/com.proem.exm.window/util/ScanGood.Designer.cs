namespace Branch.com.proem.exm.window.util
{
    partial class ScanGood
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.goodPanel = new System.Windows.Forms.Panel();
            this.goodsTablePanel = new System.Windows.Forms.Panel();
            this.goodsDataGridView = new System.Windows.Forms.DataGridView();
            this.serialnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_specifications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.goodPanel.SuspendLayout();
            this.goodsTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // goodPanel
            // 
            this.goodPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goodPanel.Controls.Add(this.goodsTablePanel);
            this.goodPanel.Controls.Add(this.leaveButton);
            this.goodPanel.Controls.Add(this.okButton);
            this.goodPanel.Location = new System.Drawing.Point(0, 0);
            this.goodPanel.Name = "goodPanel";
            this.goodPanel.Size = new System.Drawing.Size(784, 461);
            this.goodPanel.TabIndex = 1;
            // 
            // goodsTablePanel
            // 
            this.goodsTablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goodsTablePanel.Controls.Add(this.goodsDataGridView);
            this.goodsTablePanel.Location = new System.Drawing.Point(5, 5);
            this.goodsTablePanel.Name = "goodsTablePanel";
            this.goodsTablePanel.Size = new System.Drawing.Size(774, 381);
            this.goodsTablePanel.TabIndex = 2;
            // 
            // goodsDataGridView
            // 
            this.goodsDataGridView.AllowUserToAddRows = false;
            this.goodsDataGridView.AllowUserToDeleteRows = false;
            this.goodsDataGridView.AllowUserToResizeColumns = false;
            this.goodsDataGridView.AllowUserToResizeRows = false;
            this.goodsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialnumber,
            this.goods_name,
            this.goods_unit,
            this.goods_specifications,
            this.goods_price,
            this.remark,
            this.id});
            this.goodsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goodsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.goodsDataGridView.MultiSelect = false;
            this.goodsDataGridView.Name = "goodsDataGridView";
            this.goodsDataGridView.ReadOnly = true;
            this.goodsDataGridView.RowTemplate.Height = 23;
            this.goodsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.goodsDataGridView.Size = new System.Drawing.Size(774, 381);
            this.goodsDataGridView.TabIndex = 1;
            this.goodsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.goodsDataGridView_CellDoubleClick);
            // 
            // serialnumber
            // 
            this.serialnumber.DataPropertyName = "SERIALNUMBER";
            this.serialnumber.HeaderText = "货号";
            this.serialnumber.Name = "serialnumber";
            this.serialnumber.ReadOnly = true;
            // 
            // goods_name
            // 
            this.goods_name.DataPropertyName = "goods_name";
            this.goods_name.HeaderText = "商品名";
            this.goods_name.Name = "goods_name";
            this.goods_name.ReadOnly = true;
            // 
            // goods_unit
            // 
            this.goods_unit.DataPropertyName = "goods_unit";
            this.goods_unit.HeaderText = "单位";
            this.goods_unit.Name = "goods_unit";
            this.goods_unit.ReadOnly = true;
            // 
            // goods_specifications
            // 
            this.goods_specifications.DataPropertyName = "goods_specifications";
            this.goods_specifications.HeaderText = "规格";
            this.goods_specifications.Name = "goods_specifications";
            this.goods_specifications.ReadOnly = true;
            // 
            // goods_price
            // 
            this.goods_price.DataPropertyName = "goods_price";
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.goods_price.DefaultCellStyle = dataGridViewCellStyle7;
            this.goods_price.HeaderText = "商品价格";
            this.goods_price.Name = "goods_price";
            this.goods_price.ReadOnly = true;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "备注";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            this.remark.Width = 400;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // leaveButton
            // 
            this.leaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.leaveButton.Location = new System.Drawing.Point(407, 406);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(80, 35);
            this.leaveButton.TabIndex = 1;
            this.leaveButton.Text = "退出(L)";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(297, 406);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(80, 35);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "确定(Y)";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ScanGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.goodPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScanGood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择商品";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ScanGood_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScanGood_KeyDown);
            this.goodPanel.ResumeLayout(false);
            this.goodsTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel goodPanel;
        private System.Windows.Forms.Panel goodsTablePanel;
        private System.Windows.Forms.DataGridView goodsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_specifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.Button okButton;
    }
}