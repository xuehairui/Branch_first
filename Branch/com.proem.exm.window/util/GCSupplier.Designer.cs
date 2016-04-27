namespace Branch.com.proem.exm.window.util
{
    partial class GCSupplier
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
            this.supplierPanel = new System.Windows.Forms.Panel();
            this.supplierTreeView = new System.Windows.Forms.TreeView();
            this.supplierPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // supplierPanel
            // 
            this.supplierPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.supplierPanel.Controls.Add(this.supplierTreeView);
            this.supplierPanel.Location = new System.Drawing.Point(0, 0);
            this.supplierPanel.Name = "supplierPanel";
            this.supplierPanel.Size = new System.Drawing.Size(154, 328);
            this.supplierPanel.TabIndex = 1;
            // 
            // supplierTreeView
            // 
            this.supplierTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierTreeView.Location = new System.Drawing.Point(0, 0);
            this.supplierTreeView.Name = "supplierTreeView";
            this.supplierTreeView.Size = new System.Drawing.Size(154, 328);
            this.supplierTreeView.TabIndex = 0;
            this.supplierTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.supplierTreeView_AfterSelect);
            this.supplierTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.supplierTreeView_NodeMouseClick);
            // 
            // GCSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 328);
            this.Controls.Add(this.supplierPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GCSupplier";
            this.Text = "供应商选择";
            this.Load += new System.EventHandler(this.GCSupplier_Load);
            this.supplierPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel supplierPanel;
        private System.Windows.Forms.TreeView supplierTreeView;
    }
}