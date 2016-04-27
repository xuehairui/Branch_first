using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.dao.master;

namespace Branch.com.proem.exm.service.master
{
    public class DeliverAmountInfoService
    {
        public void AddDeliverAmountInfo(DeliverAmountInfo obj)
        {
            DeliverAmountInfoDao dao = new DeliverAmountInfoDao();
            dao.AddDeliverAmountInfo(obj);
        }
    }
}
