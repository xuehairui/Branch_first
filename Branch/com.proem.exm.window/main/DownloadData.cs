using Branch.com.proem.exm.service;
using Branch.com.proem.exm.service.main;
using Branch.com.proem.exm.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Branch.com.proem.exm.window.main
{
    public partial class DownloadData : Form
    {
        public DownloadData()
        {
            InitializeComponent();
        }

        public void Step()
        {
            this.progressBar1.PerformStep();
        }

        /// <summary>
        /// 显示下载信息
        /// </summary>
        /// <param name="message"></param>
        public void AppendMessage(string message)
        {
            messagebox.SelectionStart = 0;
            messagebox.AppendText(message);
        }

        private void DownloadData_Load(object sender, EventArgs e)
        {
            messagebox.SelectionStart = 0;
            messagebox.AppendText("");
        }

        private void loadData()
        {
            messagebox.SelectionStart = 0;
            messagebox.AppendText("开始下载数据,请稍等.......\n");
            DownloadDataService download = new DownloadDataService();
            download.DownloadData(this);
            DownloadIdentifyService service = new DownloadIdentifyService();
            ///更新最后一次下载时间
            service.UpdateIdentify(DateTime.Now);
            ///更新亭点收货标识
            service.UpdateHarvestFlag(Constant.HARVEST_NO);
        }

        private void DownloadData_Shown(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
