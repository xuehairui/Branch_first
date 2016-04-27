using Branch.com.proem.exm.dao.master;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.master
{
    public class PayInfoService
    {
        /// <summary>
        /// 添加付款信息
        /// </summary>
        /// <param name="payinfo"></param>
        public void AddPayInfo(PayInfo payinfo)
        {
            PayInfoDao dao = new PayInfoDao();
            dao.AddPayInfo(payinfo);
        }

        public void AddPayInfo(List<PayInfo> payList)
        {
            PayInfoDao dao = new PayInfoDao();
            dao.AddPayInfo(payList);
        }


        public bool AddPayInfoI(PayInfo payInfo)
        {
            PayInfoDao dao = new PayInfoDao();
            return dao.AddPayInfoI(payInfo);
        }
    }
}
