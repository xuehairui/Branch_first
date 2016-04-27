using Branch.com.proem.exm.dao.branch;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.branch
{
    public class BranchZcOrderHistoryService
    {
        public void AddZcOrderHistory(List<ZcOrderHistory> list)
        {
            BranchZcOrderHistoryDao dao = new BranchZcOrderHistoryDao();
            dao.AddZcOrderHistory(list);
        }

        public void DeleteAll()
        {
            BranchZcOrderHistoryDao dao = new BranchZcOrderHistoryDao();
            dao.DeleteAll("zc_order_history");
        }

        /// <summary>
        /// 根据订单号将订单的状态修改为完成
        /// </summary>
        /// <param name="list"></param>
        /// <param name="status"></param>
        public void UpdateOrderStatusByIds(List<string> list, string status)
        {
            BranchZcOrderHistoryDao dao = new BranchZcOrderHistoryDao();
            dao.UpdateOrderStatusByIds(list, status);
        }

        /// <summary>
        /// 根据订单号更新订单状态
        /// </summary>
        /// <param name="history"></param>
        /// <param name="status"></param>
        public void UpdateOrderStatusByIds(string id, string status)
        {
            BranchZcOrderHistoryDao dao = new BranchZcOrderHistoryDao();
            dao.UpdateOrderStatusByIds(id, status);
        }

        /// <summary>
        /// 添加单个订单信息
        /// </summary>
        /// <param name="history"></param>
        public void AddZcOrderHistory(ZcOrderHistory history)
        {
            BranchZcOrderHistoryDao dao = new BranchZcOrderHistoryDao();
            dao.AddZcOrderHistory(history);
        }

        public ZcOrderHistory FindById(string id)
        {
            BranchZcOrderHistoryDao dao = new BranchZcOrderHistoryDao();
            return dao.FindById(id);
        }
    }
}
