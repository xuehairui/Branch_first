using Branch.com.proem.exm.dao.master;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.master
{
    class RelUserRoleService
    {
        public List<RelUserRole> FindAll()
        {
            RelUserRoleDao dao = new RelUserRoleDao();
            return dao.FindAll();
        }
    }
}
