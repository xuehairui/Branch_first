using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.dao.branch;
using Branch.com.proem.exm.domain;

namespace Branch.com.proem.exm.service.branch
{
    public class BranchZcClassifyInfoService
    {
        public void AddZcClassifyInfo(List<ZcClassIfyInfo> list)
        {
            BranchZcClassifyInfoDao dao = new BranchZcClassifyInfoDao();
            dao.AddZcClassifyInfo(list);
        }

        public void DeleteAll()
        {
            BranchZcClassifyInfoDao dao = new BranchZcClassifyInfoDao();
            dao.DeleteAll("zc_classify_info");
        }
    }
}
