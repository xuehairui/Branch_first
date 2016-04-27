using Branch.com.proem.exm.dao.branch;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.branch
{
    /// <summary>
    /// 订单退款明细
    /// </summary>
    class BranchZcOrderRefundItemService
    {
        public void AddZcOrderRefundItem(List<ZcOrderRefundItem> list)
        {
            BranchZcOrderRefundItemDao dao = new BranchZcOrderRefundItemDao();
            dao.AddZcOrderRefundItem(list);
        }

        public void DeleteAll()
        {
            BranchZcOrderRefundItemDao dao = new BranchZcOrderRefundItemDao();
            dao.DeleteAll("zc_order_refund_item");
        }

        public ZcOrderRefundItem FindById(string p)
        {
            BranchZcOrderRefundItemDao dao = new BranchZcOrderRefundItemDao();
            return dao.FindById(p);
        }
    }
}
