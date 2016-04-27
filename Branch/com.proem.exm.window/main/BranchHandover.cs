using Branch.com.proem.exm.service.branch;
using Branch.com.proem.exm.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Branch.com.proem.exm.window.main
{
    /// <summary>
    /// 分店系统交班界面
    /// </summary>
    public partial class BranchHandover : Form
    {

        public bool alreadyHandover = false;

        public BranchHandover()
        {
            InitializeComponent();
        }

        private void BranchHandover_Load(object sender, EventArgs e)
        {
            inBrandTextBox.Text = LoginUserInfo.branchName;//分店
            salesmanTextBox.Text = LoginUserInfo.name;//业务员
            //金额
            BranchPayInfoService payService = new BranchPayInfoService();
            DateTime first = DateTime.Today;
            DateTime last = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 23:59:59"));
            string sum = payService.FindAmountCashier(first, last, LoginUserInfo.id);
            moneyTextBox.Text = sum;
            timeTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");//时间
        }

        private void sureButton_Click(object sender, EventArgs e)
        {
            //将数据存入数据库，并提交

            alreadyHandover = true;
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //退出分店系统
            this.Close();
        }

        private void BranchHandover_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                backButton_Click(this, EventArgs.Empty);
            }
        }
    }
}
