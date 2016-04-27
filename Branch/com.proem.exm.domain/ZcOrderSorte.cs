using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.domain
{
    /// <summary>
    /// 分拣信息
    /// </summary>
    public class ZcOrderSorte
    {
        public string Id{get;set;}

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public string Address { get; set; }

        public string GoodsId { get; set; }

        public string GoodsName { get; set; }

        public string OrdersNum { get; set; }

        public string SorteNum { get; set; }

        public string Weight { get; set; }
    }
}
