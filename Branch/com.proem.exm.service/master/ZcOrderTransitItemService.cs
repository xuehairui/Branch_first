using Branch.com.proem.exm.dao.master;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.master
{
    public class ZcOrderTransitItemService
    {
        public List<ZcOrderTransitItem> FindAll()
        {
            ZcOrderTransitItemDao dao = new ZcOrderTransitItemDao();
            return dao.FindAll();
        }

        public void DeleteByOrderId(string p)
        {
            ZcOrderTransitItemDao dao = new ZcOrderTransitItemDao();
            dao.DeleteByOrderId(p);
        }

        public bool DeleteByOrderIdI(string p)
        {
            ZcOrderTransitItemDao dao = new ZcOrderTransitItemDao();
            return dao.DeleteByOrderIdI(p);
        }
    }
}
