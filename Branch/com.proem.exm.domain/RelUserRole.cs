using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.domain
{
    public class RelUserRole
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

        public string LeftClassId
        {
            get;
            set;
        }

        public string LeftId
        {
            get;
            set;
        }

        public int NotdeLeteRel
        {
            get;
            set;
        }

        public string RigthClassId
        {
            get;
            set;
        }

        public string RightId
        {
            get;
            set;
        }
    }
}
