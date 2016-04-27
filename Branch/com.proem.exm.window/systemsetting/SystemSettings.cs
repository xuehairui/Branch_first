using Branch.com.proem.exm.window.main;
using Branch.com.proem.exm.window.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Branch.com.proem.exm.window.systemsetting
{
    /// <summary>
    /// 系统设置
    /// </summary>
    public partial class SystemSettings : Form
    {
        public SystemSettings()
        {
            InitializeComponent();
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            leave();
        }

        private void leaveDeskButton_Click(object sender, EventArgs e)
        {
            leave();
        }

        private void leave()
        {
            BranchMain branchMain = new BranchMain();
            branchMain.Show();
            this.Close();
        }

        private void SystemSettings_Load(object sender, EventArgs e)
        {
            this.deskLogPanel.Hide();
            this.systemLogPanel.Show();
            logTreeView.ExpandAll();

            Times times = new Times();
            times.TopLevel = false;
            this.timePanel.Controls.Add(times);
            times.Show();

            Times timesDesk = new Times();
            timesDesk.TopLevel = false;
            this.timeDeskPanel.Controls.Add(timesDesk);
            timesDesk.Show();
        }

        private void operatorButton_Click(object sender, EventArgs e)
        {
            //系统日志-操作员
        }

        private void operatorDeskButton_Click(object sender, EventArgs e)
        {
            //前台日志-操作员
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            //系统日志-查询
        }

        private void queryDeskButton_Click(object sender, EventArgs e)
        {
            //前台日志-查询
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            //系统日志-打印
        }

        private void printDeskButton_Click(object sender, EventArgs e)
        {
            //前台日志-打印
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            //系统日志-设置
        }

        private void setDeskButton_Click(object sender, EventArgs e)
        {
            //前台日志-设置
        }

        private void logTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (logTreeView.SelectedNode.Name.Equals("systemLog"))
            {
                this.deskLogPanel.Hide();
                this.systemLogPanel.Show();
            }
            if (logTreeView.SelectedNode.Name.Equals("deskLog"))
            {
                this.systemLogPanel.Hide();
                this.deskLogPanel.Show();
            }
        }

        private void SystemSettings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                leave();
            }
        }
    }
}
