using Branch.com.proem.exm.dao.master;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service
{
    public class ZcOrderTransitService
    {
        public List<ZcOrderTransit> FindAll()
        {
            ZcOrderTransitDao dao = new ZcOrderTransitDao();
            return dao.FindAll();
        }

        /// <summary>
        /// 更新状态
        /// </summary>
        /// <param name="tranlist"></param>
        public void UpdateStatus(List<ZcOrderTransit> tranlist)
        {
            ZcOrderTransitDao dao = new ZcOrderTransitDao();
            dao.UpdateStatus(tranlist);
        }

        public void DeleteByOrderId(string p)
        {
            ZcOrderTransitDao dao = new ZcOrderTransitDao();
            dao.DeleteByOrderId(p);
        }

        public bool UpdateStatus(string p1, string p2)
        {
            ZcOrderTransitDao dao = new ZcOrderTransitDao();
            return dao.UpdateStatus(p1, p2);
        }

        public bool DeleteById(string id)
        {
            ZcOrderTransitDao dao = new ZcOrderTransitDao();
            return dao.DeleteById(id);
        }
    }
}
