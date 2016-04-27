namespace Branch.com.proem.exm.window.util
{
    partial class Times
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
            this.components = new System.ComponentModel.Container();
            this.timesPanel = new System.Windows.Forms.Panel();
            this.timesLabel = new System.Windows.Forms.Label();
            this.timesTimer = new System.Windows.Forms.Timer(this.components);
            this.timesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timesPanel
            // 
            this.timesPanel.Controls.Add(this.timesLabel);
            this.timesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timesPanel.Location = new System.Drawing.Point(0, 0);
            this.timesPanel.Name = "timesPanel";
            this.timesPanel.Size = new System.Drawing.Size(119, 32);
            this.timesPanel.TabIndex = 0;
            // 
            // timesLabel
            // 
            this.timesLabel.AutoSize = true;
            this.timesLabel.Location = new System.Drawing.Point(0, 10);
            this.timesLabel.Name = "timesLabel";
            this.timesLabel.Size = new System.Drawing.Size(0, 12);
            this.timesLabel.TabIndex = 0;
            // 
            // timesTimer
            // 
            this.timesTimer.Tick += new System.EventHandler(this.timesTimer_Tick);
            // 
            // Times
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(119, 32);
            this.Controls.Add(this.timesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Times";
            this.Text = "当前时间";
            this.Load += new System.EventHandler(this.Times_Load);
            this.timesPanel.ResumeLayout(false);
            this.timesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel timesPanel;
        private System.Windows.Forms.Timer timesTimer;
        private System.Windows.Forms.Label timesLabel;

    }
}