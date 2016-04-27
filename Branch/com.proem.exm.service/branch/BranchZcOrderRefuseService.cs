using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.dao.branch;

namespace Branch.com.proem.exm.service.branch
{
    public class BranchZcOrderRefuseService
    {

        public void AddZcOrderRefuse(ZcOrderRefuse obj)
        {
            BranchZcOrderRefuseDao dao = new BranchZcOrderRefuseDao();
            dao.AddZcOrderRefuse(obj);
        }

        public ZcOrderRefuse FindById(string id)
        {
            BranchZcOrderRefuseDao dao = new BranchZcOrderRefuseDao();
            return dao.FindById(id);
        }
    }
}
