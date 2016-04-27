using Branch.com.proem.exm.dao.branch;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.branch
{
    public class BranchZcOrderSorteService
    {

        public void AddZcOrderSorte(List<ZcOrderSorte> obj)
        {
            BranchZcOrderSorteDao dao = new BranchZcOrderSorteDao();
            dao.AddZcOrdeSorte(obj);
        }

    }
}
