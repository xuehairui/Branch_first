using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Branch.com.proem.exm.util
{
    /// <summary>
    /// 打印的商品信息
    /// </summary>
    public class GoodsPrint
    {
        /// <summary>
        /// 货号
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// 商品名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// 重量
        /// </summary>
        public float Weight { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public float Nums { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }

    }
}
