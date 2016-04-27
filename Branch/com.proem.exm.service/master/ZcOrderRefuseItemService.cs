using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.dao.master;

namespace Branch.com.proem.exm.service.master
{
    public class ZcOrderRefuseItemService
    {
        public void AddZcOrderRefuseItem(List<ZcOrderRefuseItem> list)
        {
            ZcOrderRefuseItemDao dao = new ZcOrderRefuseItemDao();
            dao.AddZcOrderRefuseItem(list);
        }

        public bool AddZcOrderRefuseItemI(ZcOrderRefuseItem item)
        {
            ZcOrderRefuseItemDao dao = new ZcOrderRefuseItemDao();
            return dao.AddZcOrderRefuseItemI(item);
        }
    }
}
