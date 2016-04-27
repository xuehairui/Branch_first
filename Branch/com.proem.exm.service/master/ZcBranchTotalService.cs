using Branch.com.proem.exm.dao.master;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.master
{
    class ZcBranchTotalService
    {
        public List<ZcBranchTotal> FindAll()
        {
            ZcBranchTotalDao dao = new ZcBranchTotalDao();
            return dao.FindAll();
        }

        public ZcBranchTotal FindOfAll(string id)
        {
            ZcBranchTotalDao dao = new ZcBranchTotalDao();
            return dao.FindOfAll(id);
        }
    }
}
