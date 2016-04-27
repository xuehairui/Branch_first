using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.dao.master;

namespace Branch.com.proem.exm.service.master
{
    public class ZcStoreHouseService
    {
        public List<ZcStoreHouse> FindByBranchId()
        {
            ZcStoreHouseDao dao = new ZcStoreHouseDao();
            return dao.FindByBranchId();
        }
    }
}
