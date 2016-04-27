using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.dao.branch;

namespace Branch.com.proem.exm.service.branch
{
    public class BranchZcStoreHouseService
    {
        public void AddZcStoreHouse(List<ZcStoreHouse> list)
        {
            BranchZcStoreHouseDao dao = new BranchZcStoreHouseDao();
            dao.AddZcStoreHouse(list);
        }

        public void DeleteAll()
        {
            BranchZcStoreHouseDao dao = new BranchZcStoreHouseDao();
            dao.DeleteAll("zc_storehouse");
        }
    }
}
