using Branch.com.proem.exm.dao.branch;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.branch
{
    public class BranchZcOrderTransitService
    {
        public void AddZcOrderTransit(List<ZcOrderTransit> list)
        {
            BranchZcOrderTransitDao dao = new BranchZcOrderTransitDao();
            dao.AddZcOrderTransit(list);
        }

        public void DeleteAll()
        {
            BranchZcOrderTransitDao dao = new BranchZcOrderTransitDao();
            dao.DeleteAll("zc_order_transit");
        }

        public ZcOrderTransit FindById(string id)
        {
            BranchZcOrderTransitDao dao = new BranchZcOrderTransitDao();
            return dao.FindById(id);
        }

        public void Update(ZcOrderTransit obj)
        {
            BranchZcOrderTransitDao dao = new BranchZcOrderTransitDao();
            dao.Update(obj);
        }

        public void DeleteById(string orderNumber)
        {
            BranchZcOrderTransitDao dao = new BranchZcOrderTransitDao();
            dao.DeleteById(orderNumber);
        }

        public void UpdateOrderStatus(string orderstatus)
        {
            BranchZcOrderTransitDao dao = new BranchZcOrderTransitDao();
            dao.UpdateOrderStatus(orderstatus);
        }

        public List<ZcOrderTransit> FindByIds(List<string> list)
        {
            BranchZcOrderTransitDao dao = new BranchZcOrderTransitDao();
            return dao.FindByIds(list);
        }

        /// <summary>
        /// 根据订单号集合删除订单
        /// </summary>
        /// <param name="list"></param>
        public void DeleteByIds(List<string> list)
        {
            BranchZcOrderTransitDao dao = new BranchZcOrderTransitDao();
            dao.DeleteByIds(list);
        }

        /// <summary>
        /// 获取全部订单信息
        /// </summary>
        /// <returns></returns>
        public List<ZcOrderTransit> FindAll()
        {
            BranchZcOrderTransitDao dao = new BranchZcOrderTransitDao();
            return dao.FindAll();
        }

    }
}
