using Branch.com.proem.exm.dao.master;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service
{
    class ZcUserInfoService
    {
        public List<ZcUserInfo> FindAll()
        {
            ZcUserInfoDao dao = new ZcUserInfoDao();
            return dao.FindAll();
        }
    }
}
