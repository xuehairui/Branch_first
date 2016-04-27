using Branch.com.proem.exm.dao.master;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.master
{
    /// <summary>
    /// 上传退款信息
    /// </summary>
    class RefundInfoService
    {
        /// <summary>
        /// 上传退款信息
        /// </summary>
        /// <param name="obj"></param>
        public void AddZcOrderRefund(ZcOrderRefund obj)
        {
            RefundInfoDao dao = new RefundInfoDao();
            dao.AddZcOrderRefund(obj);
        }

        /// <summary>
        /// 上传退款明细信息
        /// </summary>
        /// <param name="list"></param>
        public void AddZcOrderRefundItem(List<ZcOrderRefundItem> list)
        {
            RefundInfoDao dao = new RefundInfoDao();
            dao.AddZcOrderRefundItem(list);
        }

        public bool AddZcOrderRefundI(ZcOrderRefund obj)
        {
            RefundInfoDao dao = new RefundInfoDao();
            return dao.AddZcOrderRefundI(obj);
        }

        public bool AddZcOrderRefundItemI(ZcOrderRefundItem item)
        {
            RefundInfoDao dao = new RefundInfoDao();
            return dao.AddZcOrderRefundItemI(item);
        }
    }
}
