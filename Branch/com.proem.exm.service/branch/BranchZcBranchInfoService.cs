using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.dao.branch;

namespace Branch.com.proem.exm.service.branch
{
    public class BranchZcBranchInfoService
    {
        public void AddZcBranchInfo(List<ZcBranchInfo> list)
        {
            BranchZcBranchInfoDao dao = new BranchZcBranchInfoDao();
            dao.AddZcBranchInfo(list);
        }

        public void DeleteAll()
        {
            BranchZcBranchInfoDao dao = new BranchZcBranchInfoDao();
            dao.DeleteAll("zc_branch_info");
        }

    }
}
