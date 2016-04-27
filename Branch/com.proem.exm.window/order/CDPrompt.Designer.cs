﻿namespace Branch.com.proem.exm.window.order
{
    partial class CDPrompt
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
            this.cDPromptPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.cDPromptPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cDPromptPanel
            // 
            this.cDPromptPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cDPromptPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cDPromptPanel.Controls.Add(this.okButton);
            this.cDPromptPanel.Controls.Add(this.backButton);
            this.cDPromptPanel.Controls.Add(this.inputTextBox);
            this.cDPromptPanel.Controls.Add(this.titleLabel);
            this.cDPromptPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cDPromptPanel.Location = new System.Drawing.Point(0, 0);
            this.cDPromptPanel.Name = "cDPromptPanel";
            this.cDPromptPanel.Size = new System.Drawing.Size(403, 121);
            this.cDPromptPanel.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(140, 81);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(64, 24);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "确定";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(210, 81);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(64, 24);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "取消";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTextBox.Location = new System.Drawing.Point(25, 43);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(357, 21);
            this.inputTextBox.TabIndex = 8;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(14, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(383, 12);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "当前订单中有商品数目存在差异，是否继续结算？（如果是请输入\"y\"）";
            // 
            // CDPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 121);
            this.Controls.Add(this.cDPromptPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CDPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "提示";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CDPrompt_Load);
            this.cDPromptPanel.ResumeLayout(false);
            this.cDPromptPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cDPromptPanel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label titleLabel;

    }
}