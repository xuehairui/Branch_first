using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.dao.master;

namespace Branch.com.proem.exm.service.master
{
    public class ZcOrderRefuseService
    {
        public void AddZcOrderRefuse(ZcOrderRefuse obj) 
        {
            ZcOrderRefuseDao dao = new ZcOrderRefuseDao();
            dao.AddZcOrderRefuse(obj);
        }

        public bool AddZcOrderRefuseI(ZcOrderRefuse refuse)
        {
            ZcOrderRefuseDao dao = new ZcOrderRefuseDao();
            return dao.AddZcOrderRefuseI(refuse);
        }
    }
}
