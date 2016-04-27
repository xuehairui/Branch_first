using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.dao.master;

namespace Branch.com.proem.exm.service.master
{
    class ZcClassifyInfoService
    {
        public List<ZcClassIfyInfo> FindAll()
        {
            ZcClassifyInfoDao dao = new ZcClassifyInfoDao();
            return dao.FindAll();
        }
    }
}
