using Branch.com.proem.exm.dao.branch;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.branch
{
    public class BranchZcProviderInfoService
    {
        public void DeleteAll()
        {
            BranchZcProviderInfoDao dao = new BranchZcProviderInfoDao();
            dao.DeleteAll("zc_provider_info");
        }

        public void AddZcProviderInfo(List<ZcProviderInfo> list)
        {
            BranchZcProviderInfoDao dao = new BranchZcProviderInfoDao();
            dao.AddZcProviderInfo(list);
        }
    }
}
