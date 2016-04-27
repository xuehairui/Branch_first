using Branch.com.proem.exm.dao.branch;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.branch
{
    class BranchRoleService
    {
        public void AddRole(List<Role> list)
        {
            BranchRoleDao dao = new BranchRoleDao();
            dao.AddRole(list);
        }

        public void DeleteAll()
        {
            BranchRoleDao dao = new BranchRoleDao();
            dao.DeleteAll("ctp_role");
        }
    }
}
