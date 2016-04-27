using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.domain
{
    public class DailyReceiveGoods
    {
        /// <summary>
        /// id
        /// </summary>
        public string Id { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 货号
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// 商品名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        public string Classify { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string GoodsUnit { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        public string GoodsSpecifications { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        public string GooodsPrice { get;set;}

        /// <summary>
        /// 订单上商品数量
        /// </summary>
        public string Nums { get; set; }

        /// <summary>
        /// 配送份数
        /// </summary>
        public string sortenum { get; set; }

        /// <summary>
        /// 实际数量
        /// </summary>
        public string ActualQuantity { get; set; }

        /// <summary>
        /// 订单上商品金额
        /// </summary>
        public string OrderAmount { get; set; }

        /// <summary>
        /// 实际收获商品金额
        /// </summary>
        public string ReceiveAmount { get; set; }

        /// <summary>
        /// 收营员id
        /// </summary>
        public string Salesman { get; set; }

        /// <summary>
        /// 分店id
        /// </summary>
        public string BranchId { get; set; }

        /// <summary>
        /// 收获日期
        /// </summary>
        public DateTime receiveDate { get; set; }


    }
}
