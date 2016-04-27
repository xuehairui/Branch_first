using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.domain
{
    public class ZcOrderRefuse
    {
        public string id { get; set; }

        public DateTime createTime { get; set; }

        public DateTime updateTime { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string orderId { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        public string orderAmount { get; set; }

        /// <summary>
        /// 实际金额
        /// </summary>
        public string actualAmount { get; set; }
    }
}
