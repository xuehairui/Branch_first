using Branch.com.proem.exm.dao.master;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.service.main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.master
{
    class ZcZoningService
    {
        public List<ZcZoning> FindAll()
        {
            ZcZoningDao dao = new ZcZoningDao();
            return dao.FindAll();
        }

        /// <summary>
        /// 获取在上次下载数据后更新过的数据
        /// </summary>
        /// <returns></returns>
        public List<ZcZoning> FindUpdate()
        {
            ZcZoningDao dao = new ZcZoningDao();
            DownloadIdentifyService service = new DownloadIdentifyService();
            DateTime lastUpdate = service.GetLastUpdate();
            return dao.FindUpdate(lastUpdate);
        }
    }
}
