using Branch.com.proem.exm.dao.branch;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.branch
{
    class BranchZcOrderHistoryItemService
    {
        public void AddZcOrderHistoryItem(List<ZcOrderHistoryItem> list)
        {
            BranchZcOrderHistoryItemDao dao = new BranchZcOrderHistoryItemDao();
            dao.AddZcOrderHistoryItem(list);
        }

        public void DeleteAll()
        {
            BranchZcOrderHistoryItemDao dao = new BranchZcOrderHistoryItemDao();
            dao.DeleteAll("zc_order_history_item");
        }

        public ZcOrderHistoryItem FindById(string p)
        {
            BranchZcOrderHistoryItemDao dao = new BranchZcOrderHistoryItemDao();
            return dao.FindById(p);
        }
    }
}
