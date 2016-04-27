namespace Branch.com.proem.exm.window.util
{
    partial class GCType
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
            this.typePanel = new System.Windows.Forms.Panel();
            this.typeTreeView = new System.Windows.Forms.TreeView();
            this.typePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // typePanel
            // 
            this.typePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typePanel.Controls.Add(this.typeTreeView);
            this.typePanel.Location = new System.Drawing.Point(0, 0);
            this.typePanel.Name = "typePanel";
            this.typePanel.Size = new System.Drawing.Size(154, 328);
            this.typePanel.TabIndex = 1;
            // 
            // typeTreeView
            // 
            this.typeTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeTreeView.Location = new System.Drawing.Point(0, 0);
            this.typeTreeView.Name = "typeTreeView";
            this.typeTreeView.Size = new System.Drawing.Size(154, 328);
            this.typeTreeView.TabIndex = 0;
            this.typeTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.typeTreeView_AfterSelect);
            this.typeTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.typeTreeView_NodeMouseClick);
            // 
            // GCType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 328);
            this.Controls.Add(this.typePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GCType";
            this.Text = "分类选择";
            this.Load += new System.EventHandler(this.GCType_Load);
            this.typePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel typePanel;
        private System.Windows.Forms.TreeView typeTreeView;
    }
}