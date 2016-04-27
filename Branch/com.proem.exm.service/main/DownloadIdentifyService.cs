using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.dao.branch;

namespace Branch.com.proem.exm.service.main
{
    public class DownloadIdentifyService
    {
        public DownloadIdentify FindIdentify()
        {
            DownloadIdenifyDao dao = new DownloadIdenifyDao();
            return dao.FindIdentify();
        }

        public void UpdateIdentify(DateTime time)
        {
            DownloadIdenifyDao dao = new DownloadIdenifyDao();
            dao.UpdateIdentify(time);
        }

        /// <summary>
        /// 需要下载数据
        /// </summary>
        /// <returns></returns>
        public bool NeedDownload()
        {
            DownloadIdentify obj = FindIdentify();
            DateTime last = obj.UpdateTime;
            DateTime now = DateTime.Now;
            //表示上次下载数据是今天的某个时间
            if (now.Year == last.Year && now.Month == last.Month && now.Day == last.Day)  
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

        /// <summary>
        /// 判断是不是第一次
        /// </summary>
        /// <returns></returns>
        public bool IsFirst()
        {
            DownloadIdenifyDao dao = new DownloadIdenifyDao();
            if (dao.FindFlag() == 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        /// <summary>
        /// 亭点是否收货
        /// </summary>
        /// <returns></returns>
        public bool IsHarvest()
        {
            DownloadIdenifyDao dao = new DownloadIdenifyDao();
            return dao.IsHarvest();
        }

        /// <summary>
        /// 更新亭点收货标识
        /// </summary>
        /// <param name="p"></param>
        public void UpdateHarvestFlag(bool p)
        {
            DownloadIdenifyDao dao = new DownloadIdenifyDao();
            dao.UpdateHarvestFlag(p);
        }

        /// <summary>
        /// 获取最后一次更新时间
        /// </summary>
        /// <returns></returns>
        public DateTime GetLastUpdate()
        {
            DownloadIdenifyDao dao = new DownloadIdenifyDao();
            return dao.GetLastUpdate();
        }

        public String getIdCode()
        {
            DownloadIdenifyDao dao = new DownloadIdenifyDao();
            return dao.GetIdCode();
        }

        public void setIdCode(string code)
        {
            DownloadIdenifyDao dao = new DownloadIdenifyDao();
            dao.SetIdCode(code);
        }

        public void setBranchTotalId()
        {
            DownloadIdenifyDao dao = new DownloadIdenifyDao();
            dao.setBranchTotalId();
        }
    }
}
