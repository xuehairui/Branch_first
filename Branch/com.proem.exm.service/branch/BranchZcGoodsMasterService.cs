using Branch.com.proem.exm.dao.branch;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.branch
{
    class BranchZcGoodsMasterService
    {
        public void AddZcGoodsMaster(List<ZcGoodsMaster> list)
        {
            BranchZcGoodsMasterDao dao = new BranchZcGoodsMasterDao();
            dao.AddZcGoodsMaster(list);
        }

        public void DeleteAll()
        {
            BranchZcGoodsMasterDao dao = new BranchZcGoodsMasterDao();
            dao.DeleteAll("zc_goods_master");
        }
    }
}
