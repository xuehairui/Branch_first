namespace Branch.com.proem.exm.window.util
{
    partial class CDBDetial
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
            this.cDBDetialPanel = new System.Windows.Forms.Panel();
            this.backPanel = new System.Windows.Forms.Panel();
            this.sureButton = new System.Windows.Forms.Button();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cDBDetialPanel
            // 
            this.cDBDetialPanel.Location = new System.Drawing.Point(0, 0);
            this.cDBDetialPanel.Name = "cDBDetialPanel";
            this.cDBDetialPanel.Size = new System.Drawing.Size(600, 300);
            this.cDBDetialPanel.TabIndex = 0;
            // 
            // backPanel
            // 
            this.backPanel.Controls.Add(this.sureButton);
            this.backPanel.Location = new System.Drawing.Point(0, 300);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(600, 100);
            this.backPanel.TabIndex = 1;
            // 
            // sureButton
            // 
            this.sureButton.Font = new System.Drawing.Font("宋体", 16F);
            this.sureButton.Location = new System.Drawing.Point(247, 20);
            this.sureButton.Name = "sureButton";
            this.sureButton.Size = new System.Drawing.Size(106, 34);
            this.sureButton.TabIndex = 6;
            this.sureButton.Text = "确定付款";
            this.sureButton.UseVisualStyleBackColor = true;
            this.sureButton.Click += new System.EventHandler(this.sureButton_Click);
            // 
            // CDBDetial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.cDBDetialPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CDBDetial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CDBDetial";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CDBDetial_FormClosed);
            this.Load += new System.EventHandler(this.CDBDetial_Load);
            this.backPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cDBDetialPanel;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Button sureButton;
    }
}