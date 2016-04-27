using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.dao.master;
using Branch.com.proem.exm.domain;

namespace Branch.com.proem.exm.service.master
{
    public class AssociatorInfoService
    {
        public List<AssociatorInfo> FindAll()
        {
            AssociatorInfoDao dao = new AssociatorInfoDao();
            return dao.FindAll();
        }
    }
}
