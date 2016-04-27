using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.dao.master;

namespace Branch.com.proem.exm.service.master
{
    public class ZcBranchInfoService
    {
        public List<ZcBranchInfo> FindAll()
        {
            ZcBranchInfoDao dao = new ZcBranchInfoDao();
            return dao.FindAll();
        }
    }
}
