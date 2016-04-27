using Branch.com.proem.exm.dao.branch;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.branch
{
    public class BranchZcUserInfoService
    {
        public void AddZcUserInfo(List<ZcUserInfo> list)
        {
            BranchZcUserInfoDao dao = new BranchZcUserInfoDao();
            dao.AddZcUserInfo(list);
        }

        public void DeleteAll()
        {
            BranchZcUserInfoDao dao = new BranchZcUserInfoDao();
            dao.DeleteAll("zc_user_info");
        }
    }
}
