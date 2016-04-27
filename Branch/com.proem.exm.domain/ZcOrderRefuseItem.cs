using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.domain
{
    public class ZcOrderRefuseItem
    {
        public string id { get; set; }

        public DateTime createTime { get; set; }

        public DateTime updateTime { get; set; }

        /// <summary>
        /// 货号
        /// </summary>
        public string serialNumber { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string orderId { get; set; }

        /// <summary>
        /// 订单数量
        /// </summary>
        public string orderNums { get; set; }

        /// <summary>
        /// 拒收数量
        /// </summary>
        public string refuseNums { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public string price { get; set; }

        /// <summary>
        /// 拒收金额
        /// </summary>
        public string refuseAmount { get; set; }

        /// <summary>
        /// 业务员ID
        /// </summary>
        public string salesmanId { get; set; }

        /// <summary>
        /// 处理时间
        /// </summary>
        public DateTime handDate { get; set; }

        /// <summary>
        /// 分店street
        /// </summary>
        public string street { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        public string goodsFileId { get; set; }

        /// <summary>
        /// 拒收主表id
        /// </summary>
        public string refuseId { get; set; }

        /// <summary>
        /// 拒收原因
        /// </summary>
        public string refuseReason { get; set; }
    }
}
