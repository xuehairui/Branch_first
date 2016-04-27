using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.domain
{
    /// <summary>
    /// 订单退款类
    /// </summary>
    class ZcOrderRefund
    {
        public string Id
        {
            get;
            set;
        }

        public DateTime CreateTime
        {
            get;
            set;
        }

        public DateTime UpdateTime
        {
            get;
            set;
        }

        /// <summary>
        /// 订单ID
        /// </summary>
        public string Order_id
        {
            get;
            set;
        }

        /// <summary>
        /// 订单金额
        /// </summary>
        public string Order_amount
        {
            get;
            set;
        }

        /// <summary>
        /// 实际金额
        /// </summary>
        public string Actual_amount
        {
            get;
            set;
        }

        /// <summary>
        /// 退款单状态
        /// </summary>
        public string Order_refund_status
        {
            get;
            set;
        }

        public DateTime Hand_date
        {
            get;
            set;
        }
    }
}