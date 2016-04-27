namespace Branch.com.proem.exm.window.util
{
    partial class CDBDMoney
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
            this.cDBDMoneyPanel = new System.Windows.Forms.Panel();
            this.changeTextBox = new System.Windows.Forms.TextBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.payTextBox = new System.Windows.Forms.TextBox();
            this.payLabel = new System.Windows.Forms.Label();
            this.alreadyTextBox = new System.Windows.Forms.TextBox();
            this.needTextBox = new System.Windows.Forms.TextBox();
            this.alreadyLabel = new System.Windows.Forms.Label();
            this.needLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.cDBDMoneyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cDBDMoneyPanel
            // 
            this.cDBDMoneyPanel.Controls.Add(this.changeTextBox);
            this.cDBDMoneyPanel.Controls.Add(this.changeLabel);
            this.cDBDMoneyPanel.Controls.Add(this.payTextBox);
            this.cDBDMoneyPanel.Controls.Add(this.payLabel);
            this.cDBDMoneyPanel.Controls.Add(this.alreadyTextBox);
            this.cDBDMoneyPanel.Controls.Add(this.needTextBox);
            this.cDBDMoneyPanel.Controls.Add(this.alreadyLabel);
            this.cDBDMoneyPanel.Controls.Add(this.needLabel);
            this.cDBDMoneyPanel.Controls.Add(this.titleLabel);
            this.cDBDMoneyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cDBDMoneyPanel.Location = new System.Drawing.Point(0, 0);
            this.cDBDMoneyPanel.Name = "cDBDMoneyPanel";
            this.cDBDMoneyPanel.Size = new System.Drawing.Size(600, 300);
            this.cDBDMoneyPanel.TabIndex = 0;
            // 
            // changeTextBox
            // 
            this.changeTextBox.Font = new System.Drawing.Font("宋体", 16F);
            this.changeTextBox.Location = new System.Drawing.Point(276, 175);
            this.changeTextBox.Name = "changeTextBox";
            this.changeTextBox.ReadOnly = true;
            this.changeTextBox.Size = new System.Drawing.Size(200, 32);
            this.changeTextBox.TabIndex = 8;
            this.changeTextBox.TextChanged += new System.EventHandler(this.changeTextBox_TextChanged);
            this.changeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.changeTextBox_KeyPress);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("宋体", 16F);
            this.changeLabel.Location = new System.Drawing.Point(120, 180);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(76, 22);
            this.changeLabel.TabIndex = 7;
            this.changeLabel.Text = "找零：";
            // 
            // payTextBox
            // 
            this.payTextBox.Font = new System.Drawing.Font("宋体", 16F);
            this.payTextBox.Location = new System.Drawing.Point(275, 135);
            this.payTextBox.Name = "payTextBox";
            this.payTextBox.Size = new System.Drawing.Size(200, 32);
            this.payTextBox.TabIndex = 6;
            this.payTextBox.TextChanged += new System.EventHandler(this.payTextBox_TextChanged);
            this.payTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.payTextBox_KeyPress);
            // 
            // payLabel
            // 
            this.payLabel.AutoSize = true;
            this.payLabel.Font = new System.Drawing.Font("宋体", 16F);
            this.payLabel.Location = new System.Drawing.Point(120, 140);
            this.payLabel.Name = "payLabel";
            this.payLabel.Size = new System.Drawing.Size(120, 22);
            this.payLabel.TabIndex = 5;
            this.payLabel.Text = "支付金额：";
            // 
            // alreadyTextBox
            // 
            this.alreadyTextBox.Font = new System.Drawing.Font("宋体", 16F);
            this.alreadyTextBox.Location = new System.Drawing.Point(275, 215);
            this.alreadyTextBox.Name = "alreadyTextBox";
            this.alreadyTextBox.ReadOnly = true;
            this.alreadyTextBox.Size = new System.Drawing.Size(200, 32);
            this.alreadyTextBox.TabIndex = 4;
            this.alreadyTextBox.TextChanged += new System.EventHandler(this.alreadyTextBox_TextChanged);
            // 
            // needTextBox
            // 
            this.needTextBox.Font = new System.Drawing.Font("宋体", 16F);
            this.needTextBox.Location = new System.Drawing.Point(275, 95);
            this.needTextBox.Name = "needTextBox";
            this.needTextBox.ReadOnly = true;
            this.needTextBox.Size = new System.Drawing.Size(200, 32);
            this.needTextBox.TabIndex = 3;
            this.needTextBox.TextChanged += new System.EventHandler(this.needTextBox_TextChanged);
            // 
            // alreadyLabel
            // 
            this.alreadyLabel.AutoSize = true;
            this.alreadyLabel.Font = new System.Drawing.Font("宋体", 16F);
            this.alreadyLabel.Location = new System.Drawing.Point(120, 220);
            this.alreadyLabel.Name = "alreadyLabel";
            this.alreadyLabel.Size = new System.Drawing.Size(164, 22);
            this.alreadyLabel.TabIndex = 2;
            this.alreadyLabel.Text = "实际支付金额：";
            // 
            // needLabel
            // 
            this.needLabel.AutoSize = true;
            this.needLabel.Font = new System.Drawing.Font("宋体", 16F);
            this.needLabel.Location = new System.Drawing.Point(120, 100);
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
            this.titleLabel.Size = new System.Drawing.Size(120, 27);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "现金支付";
            // 
            // CDBDMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.cDBDMoneyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CDBDMoney";
            this.Text = "CDBDMoney";
            this.Load += new System.EventHandler(this.CDBDMoney_Load);
            this.cDBDMoneyPanel.ResumeLayout(false);
            this.cDBDMoneyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cDBDMoneyPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label alreadyLabel;
        private System.Windows.Forms.Label needLabel;
        private System.Windows.Forms.TextBox alreadyTextBox;
        private System.Windows.Forms.TextBox needTextBox;
        private System.Windows.Forms.TextBox changeTextBox;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.TextBox payTextBox;
        private System.Windows.Forms.Label payLabel;
    }
}