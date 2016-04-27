using Branch.com.proem.exm.dao.branch;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.branch
{
    public class BranchRelUserRoleService
    {
        public void DeleteAll()
        {
            BranchRelUserRoleDao dao = new BranchRelUserRoleDao();
            dao.DeleteAll("ctp_rel_user_role");
        }

        public void AddRelUserRole(List<RelUserRole> list)
        {
            BranchRelUserRoleDao dao = new BranchRelUserRoleDao();
            dao.AddRelUserRole(list);
        }
    }
}
