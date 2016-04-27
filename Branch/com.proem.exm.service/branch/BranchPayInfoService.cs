using Branch.com.proem.exm.dao.branch;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.branch
{
    public class BranchPayInfoService
    {
        public void AddPayInfo(PayInfo obj) 
        {
            BranchPayInfoDao dao = new BranchPayInfoDao();
            dao.AddPayInfo(obj);
        }

        /// <summary>
        /// 获取当天此收银员的收银总额
        /// </summary>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public string FindAmountCashier(DateTime first, DateTime last, string p)
        {
            BranchPayInfoDao dao = new BranchPayInfoDao();
            return dao.FindAmountCashier(first, last, p);
        }

        /// <summary>
        /// 判断当前订单是否付款
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public bool isExist(string orderId)
        {
            BranchPayInfoDao dao = new BranchPayInfoDao();
            return dao.isExist(orderId);
        }

        public void AddPayInfo(List<PayInfo> payList)
        {
            BranchPayInfoDao dao = new BranchPayInfoDao();
            dao.AddPayInfo(payList);
        }


        public PayInfo FindById(string p)
        {
            BranchPayInfoDao dao = new BranchPayInfoDao();
            return dao.FindById(p);
        }

        /// <summary>
        /// 获取该订单现金付款金额
        /// </summary>
        /// <param name="orderid"></param>
        /// <returns></returns>
        public string FindCashPayment(string orderid)
        {
            BranchPayInfoDao dao = new BranchPayInfoDao();
            return dao.FindCashPayment(orderid);
        }

        /// <summary>
        /// 获取该订单付款方式
        /// </summary>
        /// <param name="orderid"></param>
        /// <returns></returns>
        public List<string> FindModePayment(string orderid)
        {
            BranchPayInfoDao dao = new BranchPayInfoDao();
            return dao.FindModePayment(orderid);
        }
    }
}
