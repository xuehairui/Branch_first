using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.domain
{
    public class ZcStoreHouse
    {
        public string Id { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public int Status { get; set; }

        public string Store { get; set; }

        public string BranchId { get; set; }

        public string CreateUserId { get; set; }

        public string GoodsFileId { get; set; }
    }
}
