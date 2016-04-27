using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.domain
{
    /// <summary>
    /// 交班信息
    /// </summary>
    public class DeliverAmountInfo
    {
        /// <summary>
        /// 标识 yyyyMMddhhmmss格式
        /// </summary>
        public string Id { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 收银员
        /// </summary>
        public string Salesman { get; set; }

        /// <summary>
        /// 收银金额
        /// </summary>
        public string AmountCashier { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// 分店id
        /// </summary>
        public string BranchId { get; set; }

    }
}
