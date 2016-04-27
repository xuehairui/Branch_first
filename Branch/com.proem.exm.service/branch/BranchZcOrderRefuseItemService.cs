using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.dao.branch;

namespace Branch.com.proem.exm.service.branch
{
    public class BranchZcOrderRefuseItemService
    {

        public void AddZcOrderRefuseItems(List<ZcOrderRefuseItem> list)
        {
            BranchZcOrderRefuseItemDao dao = new BranchZcOrderRefuseItemDao();
            dao.AddZcOrderRefuseItems(list);
        }

        public ZcOrderRefuseItem FindById(string p)
        {
            BranchZcOrderRefuseItemDao dao = new BranchZcOrderRefuseItemDao();
            return dao.FindById(p);
        }
    }
}
