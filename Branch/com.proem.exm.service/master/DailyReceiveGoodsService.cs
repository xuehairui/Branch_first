using Branch.com.proem.exm.dao.master;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.master
{
    public class DailyReceiveGoodsService
    {
        public void AddDailyReceiveGoods(List<DailyReceiveGoods> list)
        {
            DailyReceiveGoodsDao dao = new DailyReceiveGoodsDao();
            dao.AddDailyReceiveGoods(list);
        }

        public bool AddDailyReceiveGoods(DailyReceiveGoods drg)
        {
            DailyReceiveGoodsDao dao = new DailyReceiveGoodsDao();
            return dao.AddDailyReceiveGoods(drg);
        }
    }
}
