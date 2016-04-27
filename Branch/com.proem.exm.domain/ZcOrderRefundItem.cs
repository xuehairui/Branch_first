using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.domain
{
    /// <summary>
    /// 订单退款明细类
    /// </summary>
    class ZcOrderRefundItem
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

        public string SerialNumber
        {
            get;
            set;
        }

        public string Order_id
        {
            get;
            set;
        }

        public string Order_nums
        {
            get;
            set;
        }

        public string Refund_nums
        {
            get;
            set;
        }

        public string Price
        {
            get;
            set;
        }

        public string Refund_amount
        {
            get;
            set;
        }

        public string Salesman_id
        {
            get;
            set;
        }

        public DateTime Hand_date
        {
            get;
            set;
        }

        public string Street
        {
            get;
            set;
        }

        public string GoodsFile_id
        {
            get;
            set;
        }

        public string Refund_id
        {
            get;
            set;
        }

        public string Refund_reason
        {
            get;
            set;
        }

    }
}
