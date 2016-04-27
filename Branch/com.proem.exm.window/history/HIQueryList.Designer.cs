namespace Branch.com.proem.exm.window.history
{
    partial class HIQueryList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hIQueryListPanel = new System.Windows.Forms.Panel();
            this.listGroupBox = new System.Windows.Forms.GroupBox();
            this.listTablePanel = new System.Windows.Forms.Panel();
            this.listDataGridView = new System.Windows.Forms.DataGridView();
            this.chooseCheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.serialnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nums = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diffenence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnGoods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiveAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_specifications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classify = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.chooseGroupBox = new System.Windows.Forms.GroupBox();
            this.returnGoodsButton = new System.Windows.Forms.Button();
            this.returnOrderButton = new System.Windows.Forms.Button();
            this.orderInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.informTextBox = new System.Windows.Forms.TextBox();
            this.numLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.cardTextBox = new System.Windows.Forms.TextBox();
            this.cardLabel = new System.Windows.Forms.Label();
            this.hIQueryListPanel.SuspendLayout();
            this.listGroupBox.SuspendLayout();
            this.listTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listDataGridView)).BeginInit();
            this.chooseGroupBox.SuspendLayout();
            this.orderInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // hIQueryListPanel
            // 
            this.hIQueryListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hIQueryListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.hIQueryListPanel.BackgroundImage = global::Branch.Properties.Resources.login_bg_0;
            this.hIQueryListPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hIQueryListPanel.Controls.Add(this.listGroupBox);
            this.hIQueryListPanel.Controls.Add(this.chooseGroupBox);
            this.hIQueryListPanel.Controls.Add(this.orderInfoGroupBox);
            this.hIQueryListPanel.Location = new System.Drawing.Point(0, 0);
            this.hIQueryListPanel.Name = "hIQueryListPanel";
            this.hIQueryListPanel.Size = new System.Drawing.Size(1000, 700);
            this.hIQueryListPanel.TabIndex = 3;
            // 
            // listGroupBox
            // 
            this.listGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listGroupBox.Controls.Add(this.listTablePanel);
            this.listGroupBox.Location = new System.Drawing.Point(0, 125);
            this.listGroupBox.Name = "listGroupBox";
            this.listGroupBox.Size = new System.Drawing.Size(1000, 575);
            this.listGroupBox.TabIndex = 5;
            this.listGroupBox.TabStop = false;
            this.listGroupBox.Text = "订单详情";
            // 
            // listTablePanel
            // 
            this.listTablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listTablePanel.Controls.Add(this.listDataGridView);
            this.listTablePanel.Font = new System.Drawing.Font("宋体", 13F);
            this.listTablePanel.Location = new System.Drawing.Point(4, 17);
            this.listTablePanel.Name = "listTablePanel";
            this.listTablePanel.Size = new System.Drawing.Size(992, 554);
            this.listTablePanel.TabIndex = 3;
            // 
            // listDataGridView
            // 
            this.listDataGridView.AllowUserToAddRows = false;
            this.listDataGridView.AllowUserToDeleteRows = false;
            this.listDataGridView.AllowUserToResizeColumns = false;
            this.listDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.listDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.listDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.listDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.listDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chooseCheckbox,
            this.serialnumber,
            this.goods_name,
            this.goods_price,
            this.nums,
            this.actualQuantity,
            this.diffenence,
            this.returnGoods,
            this.orderAmount,
            this.receiveAmount,
            this.returnMoney,
            this.weight,
            this.goods_specifications,
            this.goods_unit,
            this.classify,
            this.orderNum,
            this.returnButton});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 13F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.listDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDataGridView.EnableHeadersVisualStyles = false;
            this.listDataGridView.Location = new System.Drawing.Point(0, 0);
            this.listDataGridView.MultiSelect = false;
            this.listDataGridView.Name = "listDataGridView";
            this.listDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listDataGridView.RowTemplate.Height = 23;
            this.listDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listDataGridView.Size = new System.Drawing.Size(992, 554);
            this.listDataGridView.TabIndex = 2;
            this.listDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listDataGridView_CellClick);
            this.listDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listDataGridView_CellDoubleClick);
            this.listDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.listDataGridView_CellValueChanged);
            this.listDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.listDataGridView_RowPostPaint);
            // 
            // chooseCheckbox
            // 
            this.chooseCheckbox.HeaderText = "";
            this.chooseCheckbox.Name = "chooseCheckbox";
            this.chooseCheckbox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.chooseCheckbox.Width = 30;
            // 
            // serialnumber
            // 
            this.serialnumber.DataPropertyName = "serialNumber";
            this.serialnumber.HeaderText = "货号";
            this.serialnumber.Name = "serialnumber";
            this.serialnumber.ReadOnly = true;
            this.serialnumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.serialnumber.Width = 90;
            // 
            // goods_name
            // 
            this.goods_name.DataPropertyName = "name";
            this.goods_name.HeaderText = "商品名";
            this.goods_name.Name = "goods_name";
            this.goods_name.ReadOnly = true;
            this.goods_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.goods_name.Width = 200;
            // 
            // goods_price
            // 
            this.goods_price.DataPropertyName = "g_price";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.goods_price.DefaultCellStyle = dataGridViewCellStyle3;
            this.goods_price.HeaderText = "单价";
            this.goods_price.Name = "goods_price";
            this.goods_price.ReadOnly = true;
            this.goods_price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.goods_price.Width = 90;
            // 
            // nums
            // 
            this.nums.DataPropertyName = "nums";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.nums.DefaultCellStyle = dataGridViewCellStyle4;
            this.nums.HeaderText = "订单份数";
            this.nums.Name = "nums";
            this.nums.ReadOnly = true;
            this.nums.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nums.Width = 120;
            // 
            // actualQuantity
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            this.actualQuantity.DefaultCellStyle = dataGridViewCellStyle5;
            this.actualQuantity.HeaderText = "实际份数";
            this.actualQuantity.Name = "actualQuantity";
            this.actualQuantity.Width = 120;
            // 
            // diffenence
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "0";
            this.diffenence.DefaultCellStyle = dataGridViewCellStyle6;
            this.diffenence.HeaderText = "份数差异";
            this.diffenence.Name = "diffenence";
            this.diffenence.ReadOnly = true;
            this.diffenence.Width = 120;
            // 
            // returnGoods
            // 
            this.returnGoods.HeaderText = "退回份数";
            this.returnGoods.Name = "returnGoods";
            this.returnGoods.Width = 120;
            // 
            // orderAmount
            // 
            this.orderAmount.DataPropertyName = "totalprice";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0.00";
            this.orderAmount.DefaultCellStyle = dataGridViewCellStyle7;
            this.orderAmount.HeaderText = "订单金额";
            this.orderAmount.Name = "orderAmount";
            this.orderAmount.ReadOnly = true;
            this.orderAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.orderAmount.Width = 120;
            // 
            // receiveAmount
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "0.00";
            this.receiveAmount.DefaultCellStyle = dataGridViewCellStyle8;
            this.receiveAmount.HeaderText = "收货金额";
            this.receiveAmount.Name = "receiveAmount";
            this.receiveAmount.Width = 120;
            // 
            // returnMoney
            // 
            this.returnMoney.HeaderText = "退回金额";
            this.returnMoney.Name = "returnMoney";
            this.returnMoney.Width = 120;
            // 
            // weight
            // 
            this.weight.HeaderText = "商品重量";
            this.weight.Name = "weight";
            this.weight.Width = 120;
            // 
            // goods_specifications
            // 
            this.goods_specifications.DataPropertyName = "goods_specifications";
            this.goods_specifications.HeaderText = "规格";
            this.goods_specifications.Name = "goods_specifications";
            this.goods_specifications.ReadOnly = true;
            this.goods_specifications.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.goods_specifications.Width = 150;
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
            // classify
            // 
            this.classify.DataPropertyName = "classify_name";
            this.classify.HeaderText = "类型";
            this.classify.Name = "classify";
            // 
            // orderNum
            // 
            this.orderNum.DataPropertyName = "orderNum";
            this.orderNum.HeaderText = "订单号";
            this.orderNum.Name = "orderNum";
            this.orderNum.Visible = false;
            // 
            // returnButton
            // 
            this.returnButton.HeaderText = "商品操作";
            this.returnButton.Name = "returnButton";
            this.returnButton.Text = "退货";
            this.returnButton.UseColumnTextForButtonValue = true;
            this.returnButton.Visible = false;
            // 
            // chooseGroupBox
            // 
            this.chooseGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseGroupBox.Controls.Add(this.returnGoodsButton);
            this.chooseGroupBox.Controls.Add(this.returnOrderButton);
            this.chooseGroupBox.Location = new System.Drawing.Point(6, 55);
            this.chooseGroupBox.Name = "chooseGroupBox";
            this.chooseGroupBox.Size = new System.Drawing.Size(988, 70);
            this.chooseGroupBox.TabIndex = 4;
            this.chooseGroupBox.TabStop = false;
            this.chooseGroupBox.Text = "订单操作";
            // 
            // returnGoodsButton
            // 
            this.returnGoodsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.returnGoodsButton.FlatAppearance.BorderSize = 0;
            this.returnGoodsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnGoodsButton.ForeColor = System.Drawing.Color.White;
            this.returnGoodsButton.Location = new System.Drawing.Point(110, 20);
            this.returnGoodsButton.Name = "returnGoodsButton";
            this.returnGoodsButton.Size = new System.Drawing.Size(80, 35);
            this.returnGoodsButton.TabIndex = 7;
            this.returnGoodsButton.Text = "部分退款";
            this.returnGoodsButton.UseVisualStyleBackColor = false;
            this.returnGoodsButton.Visible = false;
            this.returnGoodsButton.Click += new System.EventHandler(this.returnGoodsButton_Click);
            // 
            // returnOrderButton
            // 
            this.returnOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.returnOrderButton.FlatAppearance.BorderSize = 0;
            this.returnOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnOrderButton.ForeColor = System.Drawing.Color.White;
            this.returnOrderButton.Location = new System.Drawing.Point(20, 20);
            this.returnOrderButton.Name = "returnOrderButton";
            this.returnOrderButton.Size = new System.Drawing.Size(80, 35);
            this.returnOrderButton.TabIndex = 6;
            this.returnOrderButton.Text = "全部退款";
            this.returnOrderButton.UseVisualStyleBackColor = false;
            this.returnOrderButton.Visible = false;
            this.returnOrderButton.Click += new System.EventHandler(this.returnOrderButton_Click);
            // 
            // orderInfoGroupBox
            // 
            this.orderInfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderInfoGroupBox.Controls.Add(this.idTextBox);
            this.orderInfoGroupBox.Controls.Add(this.idLabel);
            this.orderInfoGroupBox.Controls.Add(this.informTextBox);
            this.orderInfoGroupBox.Controls.Add(this.numLabel);
            this.orderInfoGroupBox.Controls.Add(this.nameTextBox);
            this.orderInfoGroupBox.Controls.Add(this.nameLabel);
            this.orderInfoGroupBox.Controls.Add(this.cardTextBox);
            this.orderInfoGroupBox.Controls.Add(this.cardLabel);
            this.orderInfoGroupBox.Location = new System.Drawing.Point(6, 4);
            this.orderInfoGroupBox.Name = "orderInfoGroupBox";
            this.orderInfoGroupBox.Size = new System.Drawing.Size(988, 50);
            this.orderInfoGroupBox.TabIndex = 3;
            this.orderInfoGroupBox.TabStop = false;
            this.orderInfoGroupBox.Text = "基本信息";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(684, 17);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(120, 21);
            this.idTextBox.TabIndex = 44;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(620, 22);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(53, 12);
            this.idLabel.TabIndex = 43;
            this.idLabel.Text = "单据号：";
            // 
            // informTextBox
            // 
            this.informTextBox.Enabled = false;
            this.informTextBox.Location = new System.Drawing.Point(484, 17);
            this.informTextBox.Name = "informTextBox";
            this.informTextBox.Size = new System.Drawing.Size(120, 21);
            this.informTextBox.TabIndex = 42;
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Location = new System.Drawing.Point(420, 22);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(65, 12);
            this.numLabel.TabIndex = 41;
            this.numLabel.Text = "会员电话：";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(284, 17);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(120, 21);
            this.nameTextBox.TabIndex = 40;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(220, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(65, 12);
            this.nameLabel.TabIndex = 39;
            this.nameLabel.Text = "会员姓名：";
            // 
            // cardTextBox
            // 
            this.cardTextBox.Enabled = false;
            this.cardTextBox.Location = new System.Drawing.Point(84, 17);
            this.cardTextBox.Name = "cardTextBox";
            this.cardTextBox.Size = new System.Drawing.Size(120, 21);
            this.cardTextBox.TabIndex = 38;
            // 
            // cardLabel
            // 
            this.cardLabel.AutoSize = true;
            this.cardLabel.Location = new System.Drawing.Point(20, 22);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(65, 12);
            this.cardLabel.TabIndex = 37;
            this.cardLabel.Text = "会员卡号：";
            // 
            // HIQueryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.hIQueryListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HIQueryList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "历史订单";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.HIQueryList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HIQueryList_KeyDown);
            this.hIQueryListPanel.ResumeLayout(false);
            this.listGroupBox.ResumeLayout(false);
            this.listTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listDataGridView)).EndInit();
            this.chooseGroupBox.ResumeLayout(false);
            this.orderInfoGroupBox.ResumeLayout(false);
            this.orderInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel hIQueryListPanel;
        private System.Windows.Forms.GroupBox orderInfoGroupBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox informTextBox;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox cardTextBox;
        private System.Windows.Forms.Label cardLabel;
        private System.Windows.Forms.GroupBox chooseGroupBox;
        private System.Windows.Forms.GroupBox listGroupBox;
        private System.Windows.Forms.Panel listTablePanel;
        private System.Windows.Forms.DataGridView listDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chooseCheckbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn nums;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn diffenence;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiveAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_specifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn classify;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNum;
        private System.Windows.Forms.DataGridViewButtonColumn returnButton;
        private System.Windows.Forms.Button returnGoodsButton;
        private System.Windows.Forms.Button returnOrderButton;
    }
}