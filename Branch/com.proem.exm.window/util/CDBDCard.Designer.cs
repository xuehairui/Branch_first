namespace Branch.com.proem.exm.window.util
{
    partial class CDBDCard
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
            this.cDBDCardPanel = new System.Windows.Forms.Panel();
            this.cardsumTextBox = new System.Windows.Forms.TextBox();
            this.cardsumLabel = new System.Windows.Forms.Label();
            this.alreadyTextBox = new System.Windows.Forms.TextBox();
            this.needTextBox = new System.Windows.Forms.TextBox();
            this.alreadyLabel = new System.Windows.Forms.Label();
            this.needLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.cDBDCardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cDBDCardPanel
            // 
            this.cDBDCardPanel.Controls.Add(this.cardsumTextBox);
            this.cDBDCardPanel.Controls.Add(this.cardsumLabel);
            this.cDBDCardPanel.Controls.Add(this.alreadyTextBox);
            this.cDBDCardPanel.Controls.Add(this.needTextBox);
            this.cDBDCardPanel.Controls.Add(this.alreadyLabel);
            this.cDBDCardPanel.Controls.Add(this.needLabel);
            this.cDBDCardPanel.Controls.Add(this.titleLabel);
            this.cDBDCardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cDBDCardPanel.Location = new System.Drawing.Point(0, 0);
            this.cDBDCardPanel.Name = "cDBDCardPanel";
            this.cDBDCardPanel.Size = new System.Drawing.Size(600, 300);
            this.cDBDCardPanel.TabIndex = 1;
            // 
            // cardsumTextBox
            // 
            this.cardsumTextBox.Font = new System.Drawing.Font("宋体", 16F);
            this.cardsumTextBox.Location = new System.Drawing.Point(275, 195);
            this.cardsumTextBox.Name = "cardsumTextBox";
            this.cardsumTextBox.ReadOnly = true;
            this.cardsumTextBox.Size = new System.Drawing.Size(200, 32);
            this.cardsumTextBox.TabIndex = 7;
            // 
            // cardsumLabel
            // 
            this.cardsumLabel.AutoSize = true;
            this.cardsumLabel.Font = new System.Drawing.Font("宋体", 16F);
            this.cardsumLabel.Location = new System.Drawing.Point(150, 200);
            this.cardsumLabel.Name = "cardsumLabel";
            this.cardsumLabel.Size = new System.Drawing.Size(120, 22);
            this.cardsumLabel.TabIndex = 6;
            this.cardsumLabel.Text = "卡内金额：";
            // 
            // alreadyTextBox
            // 
            this.alreadyTextBox.Font = new System.Drawing.Font("宋体", 16F);
            this.alreadyTextBox.Location = new System.Drawing.Point(275, 255);
            this.alreadyTextBox.Name = "alreadyTextBox";
            this.alreadyTextBox.Size = new System.Drawing.Size(200, 32);
            this.alreadyTextBox.TabIndex = 4;
            this.alreadyTextBox.TextChanged += new System.EventHandler(this.alreadyTextBox_TextChanged);
            this.alreadyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alreadyTextBox_KeyPress);
            // 
            // needTextBox
            // 
            this.needTextBox.Font = new System.Drawing.Font("宋体", 16F);
            this.needTextBox.Location = new System.Drawing.Point(275, 135);
            this.needTextBox.Name = "needTextBox";
            this.needTextBox.ReadOnly = true;
            this.needTextBox.Size = new System.Drawing.Size(200, 32);
            this.needTextBox.TabIndex = 3;
            // 
            // alreadyLabel
            // 
            this.alreadyLabel.AutoSize = true;
            this.alreadyLabel.Font = new System.Drawing.Font("宋体", 16F);
            this.alreadyLabel.Location = new System.Drawing.Point(150, 260);
            this.alreadyLabel.Name = "alreadyLabel";
            this.alreadyLabel.Size = new System.Drawing.Size(120, 22);
            this.alreadyLabel.TabIndex = 2;
            this.alreadyLabel.Text = "支付金额：";
            // 
            // needLabel
            // 
            this.needLabel.AutoSize = true;
            this.needLabel.Font = new System.Drawing.Font("宋体", 16F);
            this.needLabel.Location = new System.Drawing.Point(150, 140);
            this.needLabel.Name = "needLabel";
            this.needLabel.Size = new System.Drawing.Size(120, 22);
            this.needLabel.TabIndex = 1;
            this.needLabel.Text = "所需金额：";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("宋体", 20F);
            this.titleLabel.Location = new System.Drawing.Point(240, 44);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(147, 27);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "会员卡支付";
            // 
            // CDBDCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.cDBDCardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CDBDCard";
            this.Text = "CDBDCard";
            this.Load += new System.EventHandler(this.CDBDCard_Load);
            this.cDBDCardPanel.ResumeLayout(false);
            this.cDBDCardPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cDBDCardPanel;
        private System.Windows.Forms.TextBox alreadyTextBox;
        private System.Windows.Forms.TextBox needTextBox;
        private System.Windows.Forms.Label alreadyLabel;
        private System.Windows.Forms.Label needLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox cardsumTextBox;
        private System.Windows.Forms.Label cardsumLabel;
    }
}