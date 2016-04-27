namespace Branch.com.proem.exm.window.order
{
    partial class CDBalance
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
            this.balancePanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cardButton = new System.Windows.Forms.Button();
            this.moneyButton = new System.Windows.Forms.Button();
            this.balancePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // balancePanel
            // 
            this.balancePanel.Controls.Add(this.backButton);
            this.balancePanel.Controls.Add(this.titleLabel);
            this.balancePanel.Controls.Add(this.okButton);
            this.balancePanel.Controls.Add(this.cardButton);
            this.balancePanel.Controls.Add(this.moneyButton);
            this.balancePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.balancePanel.Location = new System.Drawing.Point(0, 0);
            this.balancePanel.Name = "balancePanel";
            this.balancePanel.Size = new System.Drawing.Size(484, 261);
            this.balancePanel.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.Location = new System.Drawing.Point(386, 217);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(88, 34);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "退出支付";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("宋体", 18F);
            this.titleLabel.Location = new System.Drawing.Point(151, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(178, 24);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "请选择支付方式";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(288, 217);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(88, 34);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "支付完成";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cardButton
            // 
            this.cardButton.Location = new System.Drawing.Point(296, 93);
            this.cardButton.Name = "cardButton";
            this.cardButton.Size = new System.Drawing.Size(80, 78);
            this.cardButton.TabIndex = 1;
            this.cardButton.Text = "会员卡支付";
            this.cardButton.UseVisualStyleBackColor = true;
            this.cardButton.Click += new System.EventHandler(this.cardButton_Click);
            // 
            // moneyButton
            // 
            this.moneyButton.Location = new System.Drawing.Point(108, 93);
            this.moneyButton.Name = "moneyButton";
            this.moneyButton.Size = new System.Drawing.Size(80, 78);
            this.moneyButton.TabIndex = 0;
            this.moneyButton.Text = "现金支付";
            this.moneyButton.UseVisualStyleBackColor = true;
            this.moneyButton.Click += new System.EventHandler(this.moneyButton_Click);
            // 
            // CDBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.balancePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CDBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请选择支付方式";
            this.TopMost = true;
            this.balancePanel.ResumeLayout(false);
            this.balancePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel balancePanel;
        private System.Windows.Forms.Button moneyButton;
        private System.Windows.Forms.Button cardButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button backButton;
    }
}