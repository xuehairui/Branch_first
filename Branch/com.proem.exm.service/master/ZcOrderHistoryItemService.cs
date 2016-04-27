using Branch.com.proem.exm.dao.master;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.master
{
    public class ZcOrderHistoryItemService
    {

        public void AddZcOrderHistoryItem(List<ZcOrderHistoryItem> historyItemlist)
        {
            ZcOrderHistoryItemDao dao = new ZcOrderHistoryItemDao();
            dao.AddZcOrderHistoryItem(historyItemlist);
        }

        public bool AddZcOrderHistoryItemI(ZcOrderHistoryItem item)
        {
            ZcOrderHistoryItemDao dao = new ZcOrderHistoryItemDao();
            return dao.AddZcOrderHistoryItemI(item);
        }
    }
}
