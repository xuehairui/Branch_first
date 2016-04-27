namespace Branch.com.proem.exm.window.order
{
    partial class ZFBPay
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
            this.zFBPayPanel = new System.Windows.Forms.Panel();
            this.leaveButton = new System.Windows.Forms.Button();
            this.sureButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.WIDtotal_fee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WIDdynamic_id = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.zFBPayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // zFBPayPanel
            // 
            this.zFBPayPanel.BackgroundImage = global::Branch.Properties.Resources.login_bg_0;
            this.zFBPayPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zFBPayPanel.Controls.Add(this.WIDdynamic_id);
            this.zFBPayPanel.Controls.Add(this.WIDtotal_fee);
            this.zFBPayPanel.Controls.Add(this.textBox3);
            this.zFBPayPanel.Controls.Add(this.leaveButton);
            this.zFBPayPanel.Controls.Add(this.sureButton);
            this.zFBPayPanel.Controls.Add(this.label2);
            this.zFBPayPanel.Controls.Add(this.label6);
            this.zFBPayPanel.Controls.Add(this.label4);
            this.zFBPayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zFBPayPanel.Location = new System.Drawing.Point(0, 0);
            this.zFBPayPanel.Name = "zFBPayPanel";
            this.zFBPayPanel.Size = new System.Drawing.Size(384, 270);
            this.zFBPayPanel.TabIndex = 0;
            // 
            // leaveButton
            // 
            this.leaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.leaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.leaveButton.FlatAppearance.BorderSize = 0;
            this.leaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaveButton.ForeColor = System.Drawing.Color.White;
            this.leaveButton.Location = new System.Drawing.Point(207, 180);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(77, 39);
            this.leaveButton.TabIndex = 17;
            this.leaveButton.Text = "取消支付";
            this.leaveButton.UseVisualStyleBackColor = false;
            this.leaveButton.Visible = false;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // sureButton
            // 
            this.sureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.sureButton.FlatAppearance.BorderSize = 0;
            this.sureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sureButton.ForeColor = System.Drawing.Color.White;
            this.sureButton.Location = new System.Drawing.Point(101, 180);
            this.sureButton.Name = "sureButton";
            this.sureButton.Size = new System.Drawing.Size(81, 39);
            this.sureButton.TabIndex = 16;
            this.sureButton.Text = "确定支付";
            this.sureButton.UseVisualStyleBackColor = false;
            this.sureButton.Visible = false;
            this.sureButton.Click += new System.EventHandler(this.sureButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "付款金额：";
            // 
            // WIDtotal_fee
            // 
            this.WIDtotal_fee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WIDtotal_fee.Location = new System.Drawing.Point(174, 90);
            this.WIDtotal_fee.Name = "WIDtotal_fee";
            this.WIDtotal_fee.Size = new System.Drawing.Size(119, 21);
            this.WIDtotal_fee.TabIndex = 12;
            this.WIDtotal_fee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WIDtotal_fee_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "动态ID：";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "应付金额：";
            // 
            // WIDdynamic_id
            // 
            this.WIDdynamic_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WIDdynamic_id.Location = new System.Drawing.Point(174, 130);
            this.WIDdynamic_id.Name = "WIDdynamic_id";
            this.WIDdynamic_id.Size = new System.Drawing.Size(119, 21);
            this.WIDdynamic_id.TabIndex = 8;
            this.WIDdynamic_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WIDdynamic_id_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(174, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(119, 21);
            this.textBox3.TabIndex = 6;
            // 
            // ZFBPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 270);
            this.Controls.Add(this.zFBPayPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZFBPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ZFBPay";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.ZFBPay_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZFBPay_FormClosing);
            this.Load += new System.EventHandler(this.ZFBPay_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ZFBPay_KeyDown);
            this.zFBPayPanel.ResumeLayout(false);
            this.zFBPayPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel zFBPayPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WIDdynamic_id;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WIDtotal_fee;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.Button sureButton;
    }
}