using Branch.com.proem.exm.dao.branch;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.branch
{
    public class BranchDailyReceiveGoodsService
    {
        public void AddDailyReceiveGoods(List<DailyReceiveGoods> list)
        {
            BranchDailyReceiveGoodsDao dao = new BranchDailyReceiveGoodsDao();
            dao.AddDailyReceiveGoods(list);
        }

        public void DeleteAll()
        {
            BranchDailyReceiveGoodsDao dao = new BranchDailyReceiveGoodsDao();
            dao.DeleteAll("daily_receive_goods");
        }
    }
}
