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
    /// 订单退款
    /// </summary>
    class BranchZcOrderRefundService
    {
        public void AddZcOrderRefund(List<ZcOrderRefund> list)
        {
            BranchZcOrderRefundDao dao = new BranchZcOrderRefundDao();
            dao.AddZcOrderRefund(list);
        }

        public void DeleteAll()
        {
            BranchZcOrderRefundDao dao = new BranchZcOrderRefundDao();
            dao.DeleteAll("zc_order_refund");
        }

        public void AddZcOrderRefund(ZcOrderRefund zcOrderRefund)
        {
            BranchZcOrderRefundDao dao = new BranchZcOrderRefundDao();
            dao.AddZcOrderRefund(zcOrderRefund);
        }


        public ZcOrderRefund FindById(string p)
        {
            BranchZcOrderRefundDao dao = new BranchZcOrderRefundDao();
            return dao.FindById(p);
        }

        
    }
}