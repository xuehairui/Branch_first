using Branch.com.proem.exm.dao.master;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.master
{
    class ZcOrderHistoryService
    {

        public void AddZcOrderHistory(ZcOrderHistory history)
        {
            ZcOrderHistoryDao dao = new ZcOrderHistoryDao();
            dao.AddZcOrderHistory(history);
        }

        /// <summary>
        /// 更新历史订单状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        public void UpdateOrderStatusByIds(string id, string status)
        {
            ZcOrderHistoryDao dao = new ZcOrderHistoryDao();
            dao.UpdateOrderStatusByIds(id, status);
        }

        public bool AddZcOrderHistoryI(ZcOrderHistory obj)
        {
            ZcOrderHistoryDao dao = new ZcOrderHistoryDao();
            return dao.AddZcOrderHistoryI(obj);
        }

        public bool UpdateOrderStatusByIdsI(string p1, string p2)
        {
            ZcOrderHistoryDao dao = new ZcOrderHistoryDao();
            return dao.UpdateOrderStatusByIdsI(p1, p2);
        }
    }
}
