using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.domain
{
    /// <summary>
    /// 角色
    /// </summary>
    public class Role
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

        public string Bpmlocked
        {
            get;
            set;
        }

        public string Creater
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int Noteditable
        {
            get;
            set;
        }
    }
}
