using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.domain
{
    /// <summary>
    /// 支付信息
    /// </summary>
    public class PayInfo
    {
        /// <summary>
        /// 付款单号
        /// </summary>
        public string Id { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        public string PayAmount { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string orderId { get; set; }

        /// <summary>
        /// 业务员
        /// </summary>
        public string salesmanId { get; set; }

        /// <summary>
        /// 付款日期
        /// </summary>
        public DateTime payDate { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        public string PayMode { get; set; }

        /// <summary>
        /// 分店
        /// </summary>
        public string BranchId { get; set; }

        /// <summary>
        /// 会员卡号
        /// </summary>
        public string MemberId { get; set; }

    }
}
