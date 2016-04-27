namespace Branch.com.proem.exm.window.util
{
    partial class GoodsChoose
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.goodsPanel = new System.Windows.Forms.Panel();
            this.chooseButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.leaveButton = new System.Windows.Forms.Button();
            this.queryCheckBox = new System.Windows.Forms.CheckBox();
            this.goodsLabel = new System.Windows.Forms.Label();
            this.queryPanel = new System.Windows.Forms.Panel();
            this.queryResultGroupBox = new System.Windows.Forms.GroupBox();
            this.goodsTablePanel = new System.Windows.Forms.Panel();
            this.goodsDataGridView = new System.Windows.Forms.DataGridView();
            this.serialnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_specifications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chooseOneButton = new System.Windows.Forms.Button();
            this.chooseAllButton = new System.Windows.Forms.Button();
            this.queryConditionGroupBox = new System.Windows.Forms.GroupBox();
            this.queryButton = new System.Windows.Forms.Button();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.keywordLabel = new System.Windows.Forms.Label();
            this.queryClassifyGroupBox = new System.Windows.Forms.GroupBox();
            this.goodsClassify_BrandPanel = new System.Windows.Forms.Panel();
            this.goodsClassify_TypePanel = new System.Windows.Forms.Panel();
            this.goodsClassify_SupplierPanel = new System.Windows.Forms.Panel();
            this.brandRadioButton = new System.Windows.Forms.RadioButton();
            this.supplierRadioButton = new System.Windows.Forms.RadioButton();
            this.typeRadioButton = new System.Windows.Forms.RadioButton();
            this.goodsPanel.SuspendLayout();
            this.queryPanel.SuspendLayout();
            this.queryResultGroupBox.SuspendLayout();
            this.goodsTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataGridView)).BeginInit();
            this.queryConditionGroupBox.SuspendLayout();
            this.queryClassifyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // goodsPanel
            // 
            this.goodsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goodsPanel.Controls.Add(this.chooseButton);
            this.goodsPanel.Controls.Add(this.okButton);
            this.goodsPanel.Controls.Add(this.leaveButton);
            this.goodsPanel.Controls.Add(this.queryCheckBox);
            this.goodsPanel.Controls.Add(this.goodsLabel);
            this.goodsPanel.Controls.Add(this.queryPanel);
            this.goodsPanel.Location = new System.Drawing.Point(0, 0);
            this.goodsPanel.Name = "goodsPanel";
            this.goodsPanel.Size = new System.Drawing.Size(783, 460);
            this.goodsPanel.TabIndex = 3;
            // 
            // chooseButton
            // 
            this.chooseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseButton.Location = new System.Drawing.Point(582, 429);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(60, 22);
            this.chooseButton.TabIndex = 6;
            this.chooseButton.Text = "选择(H)";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(648, 429);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(60, 22);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "确定(Y)";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // leaveButton
            // 
            this.leaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.leaveButton.Location = new System.Drawing.Point(714, 429);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(60, 22);
            this.leaveButton.TabIndex = 4;
            this.leaveButton.Text = "退出(L)";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // queryCheckBox
            // 
            this.queryCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.queryCheckBox.AutoSize = true;
            this.queryCheckBox.Location = new System.Drawing.Point(14, 433);
            this.queryCheckBox.Name = "queryCheckBox";
            this.queryCheckBox.Size = new System.Drawing.Size(174, 16);
            this.queryCheckBox.TabIndex = 3;
            this.queryCheckBox.Text = "查询结果只显示前100条数据";
            this.queryCheckBox.UseVisualStyleBackColor = true;
            this.queryCheckBox.CheckedChanged += new System.EventHandler(this.queryCheckBox_CheckedChanged);
            // 
            // goodsLabel
            // 
            this.goodsLabel.AutoSize = true;
            this.goodsLabel.Font = new System.Drawing.Font("宋体", 14F);
            this.goodsLabel.Location = new System.Drawing.Point(12, 9);
            this.goodsLabel.Name = "goodsLabel";
            this.goodsLabel.Size = new System.Drawing.Size(123, 19);
            this.goodsLabel.TabIndex = 1;
            this.goodsLabel.Text = "商品选择明细";
            // 
            // queryPanel
            // 
            this.queryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryPanel.Controls.Add(this.queryResultGroupBox);
            this.queryPanel.Controls.Add(this.queryConditionGroupBox);
            this.queryPanel.Controls.Add(this.queryClassifyGroupBox);
            this.queryPanel.Location = new System.Drawing.Point(0, 35);
            this.queryPanel.Name = "queryPanel";
            this.queryPanel.Size = new System.Drawing.Size(783, 385);
            this.queryPanel.TabIndex = 0;
            // 
            // queryResultGroupBox
            // 
            this.queryResultGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryResultGroupBox.Controls.Add(this.goodsTablePanel);
            this.queryResultGroupBox.Controls.Add(this.chooseOneButton);
            this.queryResultGroupBox.Controls.Add(this.chooseAllButton);
            this.queryResultGroupBox.Location = new System.Drawing.Point(175, 67);
            this.queryResultGroupBox.Name = "queryResultGroupBox";
            this.queryResultGroupBox.Size = new System.Drawing.Size(600, 311);
            this.queryResultGroupBox.TabIndex = 2;
            this.queryResultGroupBox.TabStop = false;
            this.queryResultGroupBox.Text = "列表信息";
            // 
            // goodsTablePanel
            // 
            this.goodsTablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goodsTablePanel.Controls.Add(this.goodsDataGridView);
            this.goodsTablePanel.Location = new System.Drawing.Point(5, 45);
            this.goodsTablePanel.Name = "goodsTablePanel";
            this.goodsTablePanel.Size = new System.Drawing.Size(590, 260);
            this.goodsTablePanel.TabIndex = 9;
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
            this.goodsDataGridView.Size = new System.Drawing.Size(590, 260);
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
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = null;
            this.goods_price.DefaultCellStyle = dataGridViewCellStyle13;
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
            // chooseOneButton
            // 
            this.chooseOneButton.Location = new System.Drawing.Point(81, 15);
            this.chooseOneButton.Name = "chooseOneButton";
            this.chooseOneButton.Size = new System.Drawing.Size(64, 22);
            this.chooseOneButton.TabIndex = 8;
            this.chooseOneButton.Text = "选择";
            this.chooseOneButton.UseVisualStyleBackColor = true;
            // 
            // chooseAllButton
            // 
            this.chooseAllButton.Location = new System.Drawing.Point(6, 15);
            this.chooseAllButton.Name = "chooseAllButton";
            this.chooseAllButton.Size = new System.Drawing.Size(64, 22);
            this.chooseAllButton.TabIndex = 7;
            this.chooseAllButton.Text = "全部选择";
            this.chooseAllButton.UseVisualStyleBackColor = true;
            // 
            // queryConditionGroupBox
            // 
            this.queryConditionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryConditionGroupBox.Controls.Add(this.queryButton);
            this.queryConditionGroupBox.Controls.Add(this.keywordTextBox);
            this.queryConditionGroupBox.Controls.Add(this.keywordLabel);
            this.queryConditionGroupBox.Location = new System.Drawing.Point(175, 5);
            this.queryConditionGroupBox.Name = "queryConditionGroupBox";
            this.queryConditionGroupBox.Size = new System.Drawing.Size(600, 56);
            this.queryConditionGroupBox.TabIndex = 1;
            this.queryConditionGroupBox.TabStop = false;
            this.queryConditionGroupBox.Text = "查询商品";
            // 
            // queryButton
            // 
            this.queryButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.queryButton.Location = new System.Drawing.Point(533, 19);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(55, 21);
            this.queryButton.TabIndex = 28;
            this.queryButton.Text = "查询";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.Location = new System.Drawing.Point(81, 20);
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.Size = new System.Drawing.Size(442, 21);
            this.keywordTextBox.TabIndex = 1;
            // 
            // keywordLabel
            // 
            this.keywordLabel.AutoSize = true;
            this.keywordLabel.Font = new System.Drawing.Font("宋体", 10F);
            this.keywordLabel.Location = new System.Drawing.Point(16, 22);
            this.keywordLabel.Name = "keywordLabel";
            this.keywordLabel.Size = new System.Drawing.Size(63, 14);
            this.keywordLabel.TabIndex = 0;
            this.keywordLabel.Text = "关键字：";
            // 
            // queryClassifyGroupBox
            // 
            this.queryClassifyGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.queryClassifyGroupBox.Controls.Add(this.goodsClassify_BrandPanel);
            this.queryClassifyGroupBox.Controls.Add(this.goodsClassify_TypePanel);
            this.queryClassifyGroupBox.Controls.Add(this.goodsClassify_SupplierPanel);
            this.queryClassifyGroupBox.Controls.Add(this.brandRadioButton);
            this.queryClassifyGroupBox.Controls.Add(this.supplierRadioButton);
            this.queryClassifyGroupBox.Controls.Add(this.typeRadioButton);
            this.queryClassifyGroupBox.Location = new System.Drawing.Point(7, 5);
            this.queryClassifyGroupBox.Name = "queryClassifyGroupBox";
            this.queryClassifyGroupBox.Size = new System.Drawing.Size(162, 373);
            this.queryClassifyGroupBox.TabIndex = 0;
            this.queryClassifyGroupBox.TabStop = false;
            this.queryClassifyGroupBox.Text = "分类信息";
            // 
            // goodsClassify_BrandPanel
            // 
            this.goodsClassify_BrandPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.goodsClassify_BrandPanel.Location = new System.Drawing.Point(4, 40);
            this.goodsClassify_BrandPanel.Name = "goodsClassify_BrandPanel";
            this.goodsClassify_BrandPanel.Size = new System.Drawing.Size(154, 328);
            this.goodsClassify_BrandPanel.TabIndex = 5;
            // 
            // goodsClassify_TypePanel
            // 
            this.goodsClassify_TypePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.goodsClassify_TypePanel.Location = new System.Drawing.Point(4, 40);
            this.goodsClassify_TypePanel.Name = "goodsClassify_TypePanel";
            this.goodsClassify_TypePanel.Size = new System.Drawing.Size(154, 328);
            this.goodsClassify_TypePanel.TabIndex = 4;
            // 
            // goodsClassify_SupplierPanel
            // 
            this.goodsClassify_SupplierPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.goodsClassify_SupplierPanel.Location = new System.Drawing.Point(4, 40);
            this.goodsClassify_SupplierPanel.Name = "goodsClassify_SupplierPanel";
            this.goodsClassify_SupplierPanel.Size = new System.Drawing.Size(154, 328);
            this.goodsClassify_SupplierPanel.TabIndex = 3;
            // 
            // brandRadioButton
            // 
            this.brandRadioButton.AutoSize = true;
            this.brandRadioButton.Location = new System.Drawing.Point(52, 19);
            this.brandRadioButton.Name = "brandRadioButton";
            this.brandRadioButton.Size = new System.Drawing.Size(47, 16);
            this.brandRadioButton.TabIndex = 2;
            this.brandRadioButton.TabStop = true;
            this.brandRadioButton.Text = "品牌";
            this.brandRadioButton.UseVisualStyleBackColor = true;
            this.brandRadioButton.CheckedChanged += new System.EventHandler(this.brandRadioButton_CheckedChanged);
            // 
            // supplierRadioButton
            // 
            this.supplierRadioButton.AutoSize = true;
            this.supplierRadioButton.Location = new System.Drawing.Point(100, 19);
            this.supplierRadioButton.Name = "supplierRadioButton";
            this.supplierRadioButton.Size = new System.Drawing.Size(59, 16);
            this.supplierRadioButton.TabIndex = 0;
            this.supplierRadioButton.TabStop = true;
            this.supplierRadioButton.Text = "供应商";
            this.supplierRadioButton.UseVisualStyleBackColor = true;
            this.supplierRadioButton.CheckedChanged += new System.EventHandler(this.supplierRadioButton_CheckedChanged);
            // 
            // typeRadioButton
            // 
            this.typeRadioButton.AutoSize = true;
            this.typeRadioButton.Location = new System.Drawing.Point(4, 19);
            this.typeRadioButton.Name = "typeRadioButton";
            this.typeRadioButton.Size = new System.Drawing.Size(47, 16);
            this.typeRadioButton.TabIndex = 1;
            this.typeRadioButton.TabStop = true;
            this.typeRadioButton.Text = "类别";
            this.typeRadioButton.UseVisualStyleBackColor = true;
            this.typeRadioButton.CheckedChanged += new System.EventHandler(this.typeRadioButton_CheckedChanged);
            // 
            // GoodsChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.goodsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoodsChoose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择添加商品";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GoodsChoose_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GoodsChoose_KeyDown);
            this.goodsPanel.ResumeLayout(false);
            this.goodsPanel.PerformLayout();
            this.queryPanel.ResumeLayout(false);
            this.queryResultGroupBox.ResumeLayout(false);
            this.goodsTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataGridView)).EndInit();
            this.queryConditionGroupBox.ResumeLayout(false);
            this.queryConditionGroupBox.PerformLayout();
            this.queryClassifyGroupBox.ResumeLayout(false);
            this.queryClassifyGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel goodsPanel;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.CheckBox queryCheckBox;
        private System.Windows.Forms.Label goodsLabel;
        private System.Windows.Forms.Panel queryPanel;
        private System.Windows.Forms.GroupBox queryResultGroupBox;
        private System.Windows.Forms.Panel goodsTablePanel;
        private System.Windows.Forms.DataGridView goodsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_specifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Button chooseOneButton;
        private System.Windows.Forms.Button chooseAllButton;
        private System.Windows.Forms.GroupBox queryConditionGroupBox;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.TextBox keywordTextBox;
        private System.Windows.Forms.Label keywordLabel;
        private System.Windows.Forms.GroupBox queryClassifyGroupBox;
        private System.Windows.Forms.Panel goodsClassify_BrandPanel;
        private System.Windows.Forms.Panel goodsClassify_TypePanel;
        private System.Windows.Forms.Panel goodsClassify_SupplierPanel;
        private System.Windows.Forms.RadioButton brandRadioButton;
        private System.Windows.Forms.RadioButton supplierRadioButton;
        private System.Windows.Forms.RadioButton typeRadioButton;
    }
}