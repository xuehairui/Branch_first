using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.domain
{
    public class ZcBranchTotal
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

        public string BranchCode
        {
            get;
            set;
        }

        public string BranchName
        {
            get;
            set;
        }

        public string DelFlag
        {
            get;
            set;
        }

        public string Money { get; set; }

        public string CustomerId
        {
            get;
            set;
        }

        public string ZoningId
        {
            get;
            set;
        }
    }
}
