using Branch.com.proem.exm.dao.branch;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.branch
{
    class BranchZcBranchTotalService
    {

        public void AddZcBranchTotal(List<ZcBranchTotal> list)
        {
            BranchZcBranchTotalDao dao = new BranchZcBranchTotalDao();
            dao.AddZcBranchTotal(list);
        }

        public void DeleteAll()
        {
            BranchZcBranchTotalDao dao = new BranchZcBranchTotalDao();
            dao.DeleteAll("zc_branch_total");
        }
    }
}
