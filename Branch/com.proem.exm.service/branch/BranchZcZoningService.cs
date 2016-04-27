using Branch.com.proem.exm.dao.branch;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.branch
{
    public class BranchZcZoningService
    {
        public void DeleteAll()
        {
            BranchZcZoningDao dao = new BranchZcZoningDao();
            dao.DeleteAll("zc_zoning");
        }

        public void AddZcZoning(List<ZcZoning> list)
        {
            BranchZcZoningDao dao = new BranchZcZoningDao();
            dao.AddZcZoning(list);
        }

        public void DeleteBy(List<ZcZoning> list)
        {
            BranchZcZoningDao dao = new BranchZcZoningDao();
            dao.DeleteBy(list);
        }
    }
}
