namespace Branch.com.proem.exm.window.main
{
    partial class BranchHandover
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
            this.branchHandoverPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.sureButton = new System.Windows.Forms.Button();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.moneyTextBox = new System.Windows.Forms.TextBox();
            this.salesmanTextBox = new System.Windows.Forms.TextBox();
            this.inBrandTextBox = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.salesmanLabel = new System.Windows.Forms.Label();
            this.inBrandLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.branchHandoverPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // branchHandoverPanel
            // 
            this.branchHandoverPanel.BackgroundImage = global::Branch.Properties.Resources.login_bg_0;
            this.branchHandoverPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.branchHandoverPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.branchHandoverPanel.Controls.Add(this.titleLabel);
            this.branchHandoverPanel.Controls.Add(this.backButton);
            this.branchHandoverPanel.Controls.Add(this.sureButton);
            this.branchHandoverPanel.Controls.Add(this.timeTextBox);
            this.branchHandoverPanel.Controls.Add(this.moneyTextBox);
            this.branchHandoverPanel.Controls.Add(this.salesmanTextBox);
            this.branchHandoverPanel.Controls.Add(this.inBrandTextBox);
            this.branchHandoverPanel.Controls.Add(this.timeLabel);
            this.branchHandoverPanel.Controls.Add(this.salesmanLabel);
            this.branchHandoverPanel.Controls.Add(this.inBrandLabel);
            this.branchHandoverPanel.Controls.Add(this.moneyLabel);
            this.branchHandoverPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.branchHandoverPanel.Location = new System.Drawing.Point(0, 0);
            this.branchHandoverPanel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.branchHandoverPanel.Name = "branchHandoverPanel";
            this.branchHandoverPanel.Size = new System.Drawing.Size(700, 400);
            this.branchHandoverPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("宋体", 24F);
            this.titleLabel.Location = new System.Drawing.Point(238, 35);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(207, 33);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "分店交班页面";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(360, 310);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 45);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "取消";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // sureButton
            // 
            this.sureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.sureButton.FlatAppearance.BorderSize = 0;
            this.sureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sureButton.ForeColor = System.Drawing.Color.White;
            this.sureButton.Location = new System.Drawing.Point(230, 310);
            this.sureButton.Name = "sureButton";
            this.sureButton.Size = new System.Drawing.Size(100, 45);
            this.sureButton.TabIndex = 8;
            this.sureButton.Text = "确定";
            this.sureButton.UseVisualStyleBackColor = false;
            this.sureButton.Click += new System.EventHandler(this.sureButton_Click);
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(350, 261);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.ReadOnly = true;
            this.timeTextBox.Size = new System.Drawing.Size(220, 32);
            this.timeTextBox.TabIndex = 7;
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.Location = new System.Drawing.Point(350, 209);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.ReadOnly = true;
            this.moneyTextBox.Size = new System.Drawing.Size(220, 32);
            this.moneyTextBox.TabIndex = 6;
            // 
            // salesmanTextBox
            // 
            this.salesmanTextBox.Location = new System.Drawing.Point(350, 157);
            this.salesmanTextBox.Name = "salesmanTextBox";
            this.salesmanTextBox.ReadOnly = true;
            this.salesmanTextBox.Size = new System.Drawing.Size(220, 32);
            this.salesmanTextBox.TabIndex = 5;
            // 
            // inBrandTextBox
            // 
            this.inBrandTextBox.Location = new System.Drawing.Point(350, 105);
            this.inBrandTextBox.Name = "inBrandTextBox";
            this.inBrandTextBox.ReadOnly = true;
            this.inBrandTextBox.Size = new System.Drawing.Size(220, 32);
            this.inBrandTextBox.TabIndex = 4;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(190, 265);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(120, 22);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "交班时间：";
            // 
            // salesmanLabel
            // 
            this.salesmanLabel.AutoSize = true;
            this.salesmanLabel.Location = new System.Drawing.Point(190, 161);
            this.salesmanLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.salesmanLabel.Name = "salesmanLabel";
            this.salesmanLabel.Size = new System.Drawing.Size(142, 22);
            this.salesmanLabel.TabIndex = 2;
            this.salesmanLabel.Text = "当前业务员：";
            // 
            // inBrandLabel
            // 
            this.inBrandLabel.AutoSize = true;
            this.inBrandLabel.Location = new System.Drawing.Point(190, 109);
            this.inBrandLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.inBrandLabel.Name = "inBrandLabel";
            this.inBrandLabel.Size = new System.Drawing.Size(120, 22);
            this.inBrandLabel.TabIndex = 1;
            this.inBrandLabel.Text = "当前分店：";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(190, 213);
            this.moneyLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(120, 22);
            this.moneyLabel.TabIndex = 0;
            this.moneyLabel.Text = "所收金额：";
            // 
            // BranchHandover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.branchHandoverPanel);
            this.Font = new System.Drawing.Font("宋体", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BranchHandover";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "交班";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BranchHandover_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BranchHandover_KeyDown);
            this.branchHandoverPanel.ResumeLayout(false);
            this.branchHandoverPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel branchHandoverPanel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label salesmanLabel;
        private System.Windows.Forms.Label inBrandLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox moneyTextBox;
        private System.Windows.Forms.TextBox salesmanTextBox;
        private System.Windows.Forms.TextBox inBrandTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button sureButton;
        private System.Windows.Forms.Label titleLabel;
    }
}