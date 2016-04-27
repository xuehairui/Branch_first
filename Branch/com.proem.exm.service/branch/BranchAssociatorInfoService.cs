using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.dao.branch;

namespace Branch.com.proem.exm.service.branch
{
    public class BranchAssociatorInfoService
    {

        public void AddAssociatorInfo(List<AssociatorInfo> list)
        {
            BranchAssociatorInfoDao dao = new BranchAssociatorInfoDao();
            dao.AddAssociatorInfo(list);
        }

        public void DeleteAll()
        {
            BranchAssociatorInfoDao dao = new BranchAssociatorInfoDao();
            dao.DeleteAll("zc_associator_info");
        }
    }
}
