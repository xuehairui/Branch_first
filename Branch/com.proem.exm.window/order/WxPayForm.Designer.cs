namespace Branch.com.proem.exm.window.order
{
    partial class WxPayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WxPayForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.codeTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.actualTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.payableTextbox = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mainPanel.BackgroundImage = global::Branch.Properties.Resources.login_bg_0;
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(385, 358);
            this.mainPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.codeTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.actualTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.payableTextbox);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 321);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "付款信息";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(20, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "扫二维码";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // codeTextbox
            // 
            this.codeTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codeTextbox.Font = new System.Drawing.Font("宋体", 15F);
            this.codeTextbox.Location = new System.Drawing.Point(160, 185);
            this.codeTextbox.Name = "codeTextbox";
            this.codeTextbox.Size = new System.Drawing.Size(152, 30);
            this.codeTextbox.TabIndex = 7;
            this.codeTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.codeTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codeTextbox_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(20, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "应付金额";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actualTextbox
            // 
            this.actualTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.actualTextbox.Font = new System.Drawing.Font("宋体", 15F);
            this.actualTextbox.Location = new System.Drawing.Point(160, 135);
            this.actualTextbox.Name = "actualTextbox";
            this.actualTextbox.Size = new System.Drawing.Size(152, 30);
            this.actualTextbox.TabIndex = 6;
            this.actualTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.actualTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.actualTextbox_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(20, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "实付金额";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // payableTextbox
            // 
            this.payableTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.payableTextbox.Enabled = false;
            this.payableTextbox.Font = new System.Drawing.Font("宋体", 15F);
            this.payableTextbox.Location = new System.Drawing.Point(160, 85);
            this.payableTextbox.Name = "payableTextbox";
            this.payableTextbox.ReadOnly = true;
            this.payableTextbox.Size = new System.Drawing.Size(152, 30);
            this.payableTextbox.TabIndex = 5;
            this.payableTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WxPayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "WxPayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "微信支付";
            this.Activated += new System.EventHandler(this.WxPayForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WxPayForm_FormClosing);
            this.Load += new System.EventHandler(this.WxPayForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WxPayForm_KeyDown);
            this.mainPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox actualTextbox;
        private System.Windows.Forms.TextBox payableTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codeTextbox;
    }
}