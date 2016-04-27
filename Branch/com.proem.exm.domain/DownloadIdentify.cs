using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.domain
{
    public class DownloadIdentify
    {
        
        public int Id { get; set; }

        /// <summary>
        /// 最后一次拉取订单时间
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 系统第一次初始化标识
        /// </summary>
        public bool FirstFlag { get; set; }

        /// <summary>
        /// 亭点收获标识
        /// </summary>
        public bool HarvestFlag { get; set; }

        /// <summary>
        /// 系统编码
        /// </summary>
        public string idCode { get; set; }
    }
}
