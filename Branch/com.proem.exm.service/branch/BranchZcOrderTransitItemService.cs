using Branch.com.proem.exm.dao.branch;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.branch
{
    public class BranchZcOrderTransitItemService
    {
        public void AddZcOrderTransitItem(List<ZcOrderTransitItem> list)
        {
            BranchZcOrderTransitItemDao dao = new BranchZcOrderTransitItemDao();
            dao.AddZcOrderTransitItem(list);
        }

        public void DeleteAll()
        {
            BranchZcOrderTransitItemDao dao = new BranchZcOrderTransitItemDao();
            dao.DeleteAll("zc_order_transit_item");
        }

        public void DeleteById(string id)
        {
            BranchZcOrderTransitItemDao dao = new BranchZcOrderTransitItemDao();
            dao.DeleteById(id);
        }

        public void UpdateNumsAndAmountById(string id, string nums, string amount)
        {
            BranchZcOrderTransitItemDao dao = new BranchZcOrderTransitItemDao();
            dao.UpdateNumsAndAmountById(id, nums, amount);
        }

        public void DeleteByOrderId(string orderNumber)
        {
            BranchZcOrderTransitItemDao dao = new BranchZcOrderTransitItemDao();
            dao.DeleteByOrderId(orderNumber);
        }

        /// <summary>
        /// 根据订单号的集合获取订单里的商品信息
        /// </summary>
        /// <typeparam name="ZcOrderTransitItem"></typeparam>
        /// <param name="?"></param>
        /// <returns></returns>
        public List<ZcOrderTransitItem> FindByOrderIds(List<string> list)
        {
            BranchZcOrderTransitItemDao dao = new BranchZcOrderTransitItemDao();
            return dao.FindByOrderIds(list);
        }

        /// <summary>
        /// 根据订单号删除订单下商品信息
        /// </summary>
        /// <param name="list"></param>
        public void DeleteByOrderIds(List<string> list)
        {
            BranchZcOrderTransitItemDao dao = new BranchZcOrderTransitItemDao();
            dao.DeleteByOrderIds(list);
        }

        /// <summary>
        /// 根据订单号获取详细商品信息
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public List<ZcOrderTransitItem> FindByOrderId(string orderId)
        {
            BranchZcOrderTransitItemDao dao = new BranchZcOrderTransitItemDao();
            return dao.FindByOrderId(orderId);
        }
    }
}
