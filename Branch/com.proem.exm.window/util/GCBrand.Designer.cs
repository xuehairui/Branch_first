namespace Branch.com.proem.exm.window.util
{
    partial class GCBrand
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
            this.brandPanel = new System.Windows.Forms.Panel();
            this.brandTreeView = new System.Windows.Forms.TreeView();
            this.brandPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // brandPanel
            // 
            this.brandPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brandPanel.Controls.Add(this.brandTreeView);
            this.brandPanel.Location = new System.Drawing.Point(0, 0);
            this.brandPanel.Name = "brandPanel";
            this.brandPanel.Size = new System.Drawing.Size(154, 328);
            this.brandPanel.TabIndex = 1;
            // 
            // brandTreeView
            // 
            this.brandTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brandTreeView.Location = new System.Drawing.Point(0, 0);
            this.brandTreeView.Name = "brandTreeView";
            this.brandTreeView.Size = new System.Drawing.Size(154, 328);
            this.brandTreeView.TabIndex = 0;
            this.brandTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.brandTreeView_AfterSelect);
            this.brandTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.brandTreeView_NodeMouseClick);
            // 
            // GCBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 328);
            this.Controls.Add(this.brandPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GCBrand";
            this.Text = "品牌选择";
            this.Load += new System.EventHandler(this.GCBrand_Load);
            this.brandPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel brandPanel;
        private System.Windows.Forms.TreeView brandTreeView;
    }
}