namespace Branch.com.proem.exm.window.retreat
{
    partial class ReturnGoods
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.returnGoodsPanel = new System.Windows.Forms.Panel();
            this.returnItemGroupBox = new System.Windows.Forms.GroupBox();
            this.itemCountPanel = new System.Windows.Forms.Panel();
            this.totalAmount = new System.Windows.Forms.Label();
            this.totalSum = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.numsLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.itemTablePanel = new System.Windows.Forms.Panel();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.serialnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_specifications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nums = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsFile_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemInputPanel = new System.Windows.Forms.Panel();
            this.itemTitlePanel = new System.Windows.Forms.Panel();
            this.scanButton = new System.Windows.Forms.Button();
            this.addGoodButton = new System.Windows.Forms.Button();
            this.deleteLineButton = new System.Windows.Forms.Button();
            this.returnInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.salesmanNameTextBox = new System.Windows.Forms.TextBox();
            this.salesmanLabel = new System.Windows.Forms.Label();
            this.paymentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.paymentDateLabel = new System.Windows.Forms.Label();
            this.consigneeNameTextBox = new System.Windows.Forms.TextBox();
            this.consigneeLabel = new System.Windows.Forms.Label();
            this.buyerButton = new System.Windows.Forms.Button();
            this.supplierButton = new System.Windows.Forms.Button();
            this.returnIdTextBox = new System.Windows.Forms.TextBox();
            this.returnIdLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newBuiltButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.timeNowLabel = new System.Windows.Forms.Label();
            this.timePanel = new System.Windows.Forms.Panel();
            this.returnGoodsPanel.SuspendLayout();
            this.returnItemGroupBox.SuspendLayout();
            this.itemCountPanel.SuspendLayout();
            this.itemTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            this.itemTitlePanel.SuspendLayout();
            this.returnInfoGroupBox.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnGoodsPanel
            // 
            this.returnGoodsPanel.Controls.Add(this.returnItemGroupBox);
            this.returnGoodsPanel.Controls.Add(this.returnInfoGroupBox);
            this.returnGoodsPanel.Controls.Add(this.topPanel);
            this.returnGoodsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnGoodsPanel.Location = new System.Drawing.Point(0, 0);
            this.returnGoodsPanel.Name = "returnGoodsPanel";
            this.returnGoodsPanel.Size = new System.Drawing.Size(1000, 725);
            this.returnGoodsPanel.TabIndex = 1;
            // 
            // returnItemGroupBox
            // 
            this.returnItemGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.returnItemGroupBox.Controls.Add(this.itemCountPanel);
            this.returnItemGroupBox.Controls.Add(this.itemTablePanel);
            this.returnItemGroupBox.Controls.Add(this.itemInputPanel);
            this.returnItemGroupBox.Controls.Add(this.itemTitlePanel);
            this.returnItemGroupBox.Location = new System.Drawing.Point(6, 135);
            this.returnItemGroupBox.Name = "returnItemGroupBox";
            this.returnItemGroupBox.Size = new System.Drawing.Size(982, 576);
            this.returnItemGroupBox.TabIndex = 2;
            this.returnItemGroupBox.TabStop = false;
            this.returnItemGroupBox.Text = "详细信息";
            // 
            // itemCountPanel
            // 
            this.itemCountPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemCountPanel.Controls.Add(this.totalAmount);
            this.itemCountPanel.Controls.Add(this.totalSum);
            this.itemCountPanel.Controls.Add(this.amountLabel);
            this.itemCountPanel.Controls.Add(this.numsLabel);
            this.itemCountPanel.Controls.Add(this.totalLabel);
            this.itemCountPanel.Location = new System.Drawing.Point(2, 544);
            this.itemCountPanel.Name = "itemCountPanel";
            this.itemCountPanel.Size = new System.Drawing.Size(763, 22);
            this.itemCountPanel.TabIndex = 5;
            // 
            // totalAmount
            // 
            this.totalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.totalAmount.AutoSize = true;
            this.totalAmount.Font = new System.Drawing.Font("宋体", 12F);
            this.totalAmount.Location = new System.Drawing.Point(756, 3);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(40, 16);
            this.totalAmount.TabIndex = 4;
            this.totalAmount.Text = "0.00";
            // 
            // totalSum
            // 
            this.totalSum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.totalSum.AutoSize = true;
            this.totalSum.Font = new System.Drawing.Font("宋体", 12F);
            this.totalSum.Location = new System.Drawing.Point(556, 3);
            this.totalSum.Name = "totalSum";
            this.totalSum.Size = new System.Drawing.Size(16, 16);
            this.totalSum.TabIndex = 3;
            this.totalSum.Text = "0";
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.amountLabel.Location = new System.Drawing.Point(700, 3);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(56, 16);
            this.amountLabel.TabIndex = 2;
            this.amountLabel.Text = "金额：";
            // 
            // numsLabel
            // 
            this.numsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.numsLabel.AutoSize = true;
            this.numsLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.numsLabel.Location = new System.Drawing.Point(500, 3);
            this.numsLabel.Name = "numsLabel";
            this.numsLabel.Size = new System.Drawing.Size(56, 16);
            this.numsLabel.TabIndex = 1;
            this.numsLabel.Text = "份数：";
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("宋体", 12F);
            this.totalLabel.Location = new System.Drawing.Point(5, 3);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(56, 16);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "合计：";
            // 
            // itemTablePanel
            // 
            this.itemTablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemTablePanel.Controls.Add(this.itemDataGridView);
            this.itemTablePanel.Location = new System.Drawing.Point(2, 61);
            this.itemTablePanel.Name = "itemTablePanel";
            this.itemTablePanel.Size = new System.Drawing.Size(763, 483);
            this.itemTablePanel.TabIndex = 4;
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.AllowUserToAddRows = false;
            this.itemDataGridView.AllowUserToDeleteRows = false;
            this.itemDataGridView.AllowUserToResizeColumns = false;
            this.itemDataGridView.AllowUserToResizeRows = false;
            this.itemDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialnumber,
            this.goods_name,
            this.goods_unit,
            this.goods_specifications,
            this.nums,
            this.goods_price,
            this.amount,
            this.remark,
            this.id,
            this.goodsFile_id});
            this.itemDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemDataGridView.Location = new System.Drawing.Point(0, 0);
            this.itemDataGridView.MultiSelect = false;
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.RowTemplate.Height = 23;
            this.itemDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemDataGridView.Size = new System.Drawing.Size(763, 483);
            this.itemDataGridView.TabIndex = 1;
            // 
            // serialnumber
            // 
            this.serialnumber.DataPropertyName = "serialnumber";
            this.serialnumber.HeaderText = "货号";
            this.serialnumber.Name = "serialnumber";
            this.serialnumber.ReadOnly = true;
            this.serialnumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.serialnumber.Width = 90;
            // 
            // goods_name
            // 
            this.goods_name.DataPropertyName = "goods_name";
            this.goods_name.HeaderText = "商品名";
            this.goods_name.Name = "goods_name";
            this.goods_name.ReadOnly = true;
            this.goods_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.goods_name.Width = 90;
            // 
            // goods_unit
            // 
            this.goods_unit.DataPropertyName = "goods_unit";
            this.goods_unit.HeaderText = "单位";
            this.goods_unit.Name = "goods_unit";
            this.goods_unit.ReadOnly = true;
            this.goods_unit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.goods_unit.Width = 90;
            // 
            // goods_specifications
            // 
            this.goods_specifications.DataPropertyName = "goods_specifications";
            this.goods_specifications.HeaderText = "规格";
            this.goods_specifications.Name = "goods_specifications";
            this.goods_specifications.ReadOnly = true;
            this.goods_specifications.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.goods_specifications.Width = 200;
            // 
            // nums
            // 
            this.nums.DataPropertyName = "nums";
            this.nums.HeaderText = "份数";
            this.nums.Name = "nums";
            this.nums.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nums.Width = 90;
            // 
            // goods_price
            // 
            this.goods_price.DataPropertyName = "goods_price";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.goods_price.DefaultCellStyle = dataGridViewCellStyle5;
            this.goods_price.HeaderText = "单价";
            this.goods_price.Name = "goods_price";
            this.goods_price.ReadOnly = true;
            this.goods_price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.goods_price.Width = 90;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.amount.DefaultCellStyle = dataGridViewCellStyle6;
            this.amount.HeaderText = "金额";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.amount.Width = 90;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "备注";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            this.remark.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.remark.Width = 500;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // goodsFile_id
            // 
            this.goodsFile_id.HeaderText = "goodsFile_id";
            this.goodsFile_id.Name = "goodsFile_id";
            this.goodsFile_id.Visible = false;
            // 
            // itemInputPanel
            // 
            this.itemInputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.itemInputPanel.Location = new System.Drawing.Point(765, 225);
            this.itemInputPanel.Name = "itemInputPanel";
            this.itemInputPanel.Size = new System.Drawing.Size(217, 340);
            this.itemInputPanel.TabIndex = 2;
            // 
            // itemTitlePanel
            // 
            this.itemTitlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemTitlePanel.Controls.Add(this.scanButton);
            this.itemTitlePanel.Controls.Add(this.addGoodButton);
            this.itemTitlePanel.Controls.Add(this.deleteLineButton);
            this.itemTitlePanel.Location = new System.Drawing.Point(2, 14);
            this.itemTitlePanel.Name = "itemTitlePanel";
            this.itemTitlePanel.Size = new System.Drawing.Size(978, 48);
            this.itemTitlePanel.TabIndex = 0;
            // 
            // scanButton
            // 
            this.scanButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.scanButton.Font = new System.Drawing.Font("宋体", 10F);
            this.scanButton.Location = new System.Drawing.Point(210, 9);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(70, 30);
            this.scanButton.TabIndex = 6;
            this.scanButton.Text = "扫描(P)";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // addGoodButton
            // 
            this.addGoodButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.addGoodButton.Font = new System.Drawing.Font("宋体", 10F);
            this.addGoodButton.Location = new System.Drawing.Point(20, 9);
            this.addGoodButton.Name = "addGoodButton";
            this.addGoodButton.Size = new System.Drawing.Size(100, 30);
            this.addGoodButton.TabIndex = 5;
            this.addGoodButton.Text = "添加商品(G)";
            this.addGoodButton.UseVisualStyleBackColor = true;
            this.addGoodButton.Click += new System.EventHandler(this.addGoodButton_Click);
            // 
            // deleteLineButton
            // 
            this.deleteLineButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteLineButton.Font = new System.Drawing.Font("宋体", 10F);
            this.deleteLineButton.Location = new System.Drawing.Point(130, 9);
            this.deleteLineButton.Name = "deleteLineButton";
            this.deleteLineButton.Size = new System.Drawing.Size(70, 30);
            this.deleteLineButton.TabIndex = 4;
            this.deleteLineButton.Text = "删除(E)";
            this.deleteLineButton.UseVisualStyleBackColor = true;
            this.deleteLineButton.Click += new System.EventHandler(this.deleteLineButton_Click);
            // 
            // returnInfoGroupBox
            // 
            this.returnInfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.returnInfoGroupBox.Controls.Add(this.timeNowLabel);
            this.returnInfoGroupBox.Controls.Add(this.timePanel);
            this.returnInfoGroupBox.Controls.Add(this.salesmanNameTextBox);
            this.returnInfoGroupBox.Controls.Add(this.salesmanLabel);
            this.returnInfoGroupBox.Controls.Add(this.paymentDateTimePicker);
            this.returnInfoGroupBox.Controls.Add(this.paymentDateLabel);
            this.returnInfoGroupBox.Controls.Add(this.consigneeNameTextBox);
            this.returnInfoGroupBox.Controls.Add(this.consigneeLabel);
            this.returnInfoGroupBox.Controls.Add(this.buyerButton);
            this.returnInfoGroupBox.Controls.Add(this.supplierButton);
            this.returnInfoGroupBox.Controls.Add(this.returnIdTextBox);
            this.returnInfoGroupBox.Controls.Add(this.returnIdLabel);
            this.returnInfoGroupBox.Location = new System.Drawing.Point(6, 60);
            this.returnInfoGroupBox.Name = "returnInfoGroupBox";
            this.returnInfoGroupBox.Size = new System.Drawing.Size(983, 75);
            this.returnInfoGroupBox.TabIndex = 1;
            this.returnInfoGroupBox.TabStop = false;
            this.returnInfoGroupBox.Text = "退货单";
            // 
            // salesmanNameTextBox
            // 
            this.salesmanNameTextBox.Location = new System.Drawing.Point(350, 41);
            this.salesmanNameTextBox.Name = "salesmanNameTextBox";
            this.salesmanNameTextBox.ReadOnly = true;
            this.salesmanNameTextBox.Size = new System.Drawing.Size(130, 21);
            this.salesmanNameTextBox.TabIndex = 30;
            // 
            // salesmanLabel
            // 
            this.salesmanLabel.AutoSize = true;
            this.salesmanLabel.Location = new System.Drawing.Point(270, 45);
            this.salesmanLabel.Name = "salesmanLabel";
            this.salesmanLabel.Size = new System.Drawing.Size(77, 12);
            this.salesmanLabel.TabIndex = 29;
            this.salesmanLabel.Text = "当前业务员：";
            // 
            // paymentDateTimePicker
            // 
            this.paymentDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.paymentDateTimePicker.Location = new System.Drawing.Point(580, 41);
            this.paymentDateTimePicker.Name = "paymentDateTimePicker";
            this.paymentDateTimePicker.Size = new System.Drawing.Size(127, 21);
            this.paymentDateTimePicker.TabIndex = 28;
            // 
            // paymentDateLabel
            // 
            this.paymentDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.paymentDateLabel.AutoSize = true;
            this.paymentDateLabel.Location = new System.Drawing.Point(512, 45);
            this.paymentDateLabel.Name = "paymentDateLabel";
            this.paymentDateLabel.Size = new System.Drawing.Size(65, 12);
            this.paymentDateLabel.TabIndex = 27;
            this.paymentDateLabel.Text = "付款日期：";
            // 
            // consigneeNameTextBox
            // 
            this.consigneeNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.consigneeNameTextBox.Location = new System.Drawing.Point(73, 41);
            this.consigneeNameTextBox.Name = "consigneeNameTextBox";
            this.consigneeNameTextBox.ReadOnly = true;
            this.consigneeNameTextBox.Size = new System.Drawing.Size(160, 21);
            this.consigneeNameTextBox.TabIndex = 15;
            // 
            // consigneeLabel
            // 
            this.consigneeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.consigneeLabel.AutoSize = true;
            this.consigneeLabel.Location = new System.Drawing.Point(10, 45);
            this.consigneeLabel.Name = "consigneeLabel";
            this.consigneeLabel.Size = new System.Drawing.Size(65, 12);
            this.consigneeLabel.TabIndex = 12;
            this.consigneeLabel.Text = "当前分店：";
            // 
            // buyerButton
            // 
            this.buyerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buyerButton.Location = new System.Drawing.Point(184, 67);
            this.buyerButton.Name = "buyerButton";
            this.buyerButton.Size = new System.Drawing.Size(32, 0);
            this.buyerButton.TabIndex = 8;
            this.buyerButton.Text = "…";
            this.buyerButton.UseVisualStyleBackColor = true;
            this.buyerButton.Click += new System.EventHandler(this.buyerButton_Click);
            // 
            // supplierButton
            // 
            this.supplierButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.supplierButton.Location = new System.Drawing.Point(230, 41);
            this.supplierButton.Name = "supplierButton";
            this.supplierButton.Size = new System.Drawing.Size(32, 0);
            this.supplierButton.TabIndex = 4;
            this.supplierButton.Text = "…";
            this.supplierButton.UseVisualStyleBackColor = true;
            this.supplierButton.Click += new System.EventHandler(this.supplierButton_Click);
            // 
            // returnIdTextBox
            // 
            this.returnIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.returnIdTextBox.Location = new System.Drawing.Point(73, 15);
            this.returnIdTextBox.Name = "returnIdTextBox";
            this.returnIdTextBox.ReadOnly = true;
            this.returnIdTextBox.Size = new System.Drawing.Size(634, 21);
            this.returnIdTextBox.TabIndex = 1;
            // 
            // returnIdLabel
            // 
            this.returnIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.returnIdLabel.AutoSize = true;
            this.returnIdLabel.Location = new System.Drawing.Point(10, 19);
            this.returnIdLabel.Name = "returnIdLabel";
            this.returnIdLabel.Size = new System.Drawing.Size(41, 12);
            this.returnIdLabel.TabIndex = 0;
            this.returnIdLabel.Text = "单号：";
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.Controls.Add(this.deleteButton);
            this.topPanel.Controls.Add(this.saveButton);
            this.topPanel.Controls.Add(this.newBuiltButton);
            this.topPanel.Controls.Add(this.openButton);
            this.topPanel.Controls.Add(this.returnButton);
            this.topPanel.Location = new System.Drawing.Point(6, 8);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(984, 52);
            this.topPanel.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("宋体", 10F);
            this.deleteButton.Location = new System.Drawing.Point(260, 10);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(70, 30);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "删除(D)";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("宋体", 10F);
            this.saveButton.Location = new System.Drawing.Point(180, 10);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 30);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "保存(S)";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newBuiltButton
            // 
            this.newBuiltButton.Font = new System.Drawing.Font("宋体", 10F);
            this.newBuiltButton.Location = new System.Drawing.Point(100, 10);
            this.newBuiltButton.Name = "newBuiltButton";
            this.newBuiltButton.Size = new System.Drawing.Size(70, 30);
            this.newBuiltButton.TabIndex = 3;
            this.newBuiltButton.Text = "新建(N)";
            this.newBuiltButton.UseVisualStyleBackColor = true;
            this.newBuiltButton.Click += new System.EventHandler(this.newBuiltButton_Click);
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("宋体", 10F);
            this.openButton.Location = new System.Drawing.Point(20, 10);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(70, 30);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "打开(O)";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.returnButton.Font = new System.Drawing.Font("宋体", 10F);
            this.returnButton.Location = new System.Drawing.Point(850, 10);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(120, 30);
            this.returnButton.TabIndex = 1;
            this.returnButton.Text = "返回主页面(Esc)";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // timeNowLabel
            // 
            this.timeNowLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeNowLabel.AutoSize = true;
            this.timeNowLabel.Location = new System.Drawing.Point(779, 30);
            this.timeNowLabel.Name = "timeNowLabel";
            this.timeNowLabel.Size = new System.Drawing.Size(65, 12);
            this.timeNowLabel.TabIndex = 32;
            this.timeNowLabel.Text = "当前时间：";
            // 
            // timePanel
            // 
            this.timePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timePanel.Location = new System.Drawing.Point(844, 20);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(119, 32);
            this.timePanel.TabIndex = 31;
            // 
            // ReturnGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 725);
            this.Controls.Add(this.returnGoodsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ReturnGoods";
            this.Text = "扫码退货";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReturnGoods_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReturnGoods_KeyDown);
            this.returnGoodsPanel.ResumeLayout(false);
            this.returnItemGroupBox.ResumeLayout(false);
            this.itemCountPanel.ResumeLayout(false);
            this.itemCountPanel.PerformLayout();
            this.itemTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            this.itemTitlePanel.ResumeLayout(false);
            this.returnInfoGroupBox.ResumeLayout(false);
            this.returnInfoGroupBox.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel returnGoodsPanel;
        private System.Windows.Forms.GroupBox returnItemGroupBox;
        private System.Windows.Forms.Panel itemInputPanel;
        private System.Windows.Forms.Panel itemTitlePanel;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Button addGoodButton;
        private System.Windows.Forms.Button deleteLineButton;
        private System.Windows.Forms.GroupBox returnInfoGroupBox;
        private System.Windows.Forms.TextBox consigneeNameTextBox;
        private System.Windows.Forms.Label consigneeLabel;
        private System.Windows.Forms.Button buyerButton;
        private System.Windows.Forms.TextBox returnIdTextBox;
        private System.Windows.Forms.Label returnIdLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newBuiltButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label paymentDateLabel;
        private System.Windows.Forms.DateTimePicker paymentDateTimePicker;
        private System.Windows.Forms.Panel itemCountPanel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label numsLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Panel itemTablePanel;
        private System.Windows.Forms.Label totalSum;
        private System.Windows.Forms.Label totalAmount;
        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_specifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn nums;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsFile_id;
        private System.Windows.Forms.Button supplierButton;
        private System.Windows.Forms.TextBox salesmanNameTextBox;
        private System.Windows.Forms.Label salesmanLabel;
        private System.Windows.Forms.Label timeNowLabel;
        private System.Windows.Forms.Panel timePanel;

    }
}