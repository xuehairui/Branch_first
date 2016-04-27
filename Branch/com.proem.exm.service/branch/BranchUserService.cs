using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.dao.branch;

namespace Branch.com.proem.exm.service.branch
{
    class BranchUserService
    {
        public void AddUser(List<User> list)
        {
            BranchUserDao dao = new BranchUserDao();
            dao.AddUser(list);
        }

        public void DeleteAll()
        {
            BranchUserDao dao = new BranchUserDao();
            dao.DeleteAll("ctp_user");
        }
    }
}
