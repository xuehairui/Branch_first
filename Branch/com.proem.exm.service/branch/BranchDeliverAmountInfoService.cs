using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.dao.branch;

namespace Branch.com.proem.exm.service.branch
{
    public class BranchDeliverAmountInfoService
    {

        public void AddDeliverAmountInfo(DeliverAmountInfo obj) 
        {
            BranchDeliverAmountInfoDao dao = new BranchDeliverAmountInfoDao();
            dao.AddDeliverAmountInfoDao(obj);
        }


        public bool isExist(DateTime first, DateTime last, string p)
        {
            BranchDeliverAmountInfoDao dao = new BranchDeliverAmountInfoDao();
            return dao.isExist(first, last, p);
        }
    }
}
