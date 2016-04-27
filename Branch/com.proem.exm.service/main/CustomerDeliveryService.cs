using Branch.com.proem.exm.dao.branch;
using Branch.com.proem.exm.service.branch;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.util;

namespace Branch.com.proem.exm.service.main
{
    public class CustomerDeliveryService
    {

        public List<string> FindOrderIdBySql(string sql)
        {
            CustomerDeliveryDao dao = new CustomerDeliveryDao();
            return dao.FindOrderIdBySql(sql);
        }

        /// <summary>
        /// 将用户提货完成后的订单和订单详情 挪动到history表中
        /// </summary>
        /// <param name="list"></param>
        public void UpdateStatusAndMoveOrder(List<string> list)
        {
            BranchZcOrderTransitService transitService = new BranchZcOrderTransitService();
            BranchZcOrderTransitItemService transitItemService = new BranchZcOrderTransitItemService();
            BranchZcOrderHistoryService historyService = new BranchZcOrderHistoryService();
            BranchZcOrderHistoryItemService historyItemService = new BranchZcOrderHistoryItemService();
            //获取提货的订单信息
            List<ZcOrderTransit> transitlist = transitService.FindByIds(list);
            List<ZcOrderTransitItem> transitItemlist = transitItemService.FindByOrderIds(list);
            //将数据转移到history 系列表中
            historyService.AddZcOrderHistory(Transfrom(transitlist));
            historyItemService.AddZcOrderHistoryItem(Transform(transitItemlist));
            historyService.UpdateOrderStatusByIds(list, Constant.ORDER_STATUS_FININSH);
            //删除订单和订单下的商品
            transitItemService.DeleteByOrderIds(list);
            transitService.DeleteByIds(list);
        }

        /// <summary>
        /// 将zcOrderTransit 转换为 ZcOrderHistory
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public List<ZcOrderHistory> Transfrom(List<ZcOrderTransit> list)
        { 
            List<ZcOrderHistory> rlist = new List<ZcOrderHistory>();
            foreach(ZcOrderTransit obj in list)
            {
                ZcOrderHistory history = new ZcOrderHistory();
                history.Id = obj.Id;
                history.CreateTime = obj.CreateTime;
                history.UpdateTime = obj.UpdateTime;
                history.BranchId = obj.BranchId;
                history.Cansignphone = obj.Cansignphone;
                history.Consignee = obj.Consignee;
                history.GoodSnum = obj.GoodSnum;
                history.IsGift = obj.IsGift;
                history.MemberCardNumber = obj.MemberCardNumber;
                history.OrderAmount = obj.OrderAmount;
                history.OrderCome = obj.OrderCome;
                history.OrderDate = obj.OrderDate;
                history.OrderNum = obj.OrderNum;
                history.OrderRedUceAmount = obj.OrderRedUceAmount;
                history.OrderStatus = obj.OrderStatus;
                history.OrderTotalValue = obj.OrderTotalValue;
                history.PullFlag = obj.PullFlag;
                history.MemberId = obj.MemberId;
                history.ZczoingId = obj.ZczoingId;
                rlist.Add(history);
            }
            return rlist;
        }

        /// <summary>
        /// 将ZcOrderTransitItem 转换为 ZcOrderHistoryItem
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public List<ZcOrderHistoryItem> Transform(List<ZcOrderTransitItem> list)
        {
            List<ZcOrderHistoryItem> rlist = new List<ZcOrderHistoryItem>();
            foreach (ZcOrderTransitItem obj in list)
            {
                ZcOrderHistoryItem item = new ZcOrderHistoryItem();
                item.Id = obj.Id;
                item.CreateTime = obj.CreateTime;
                item.UpdateTime = obj.UpdateTime;
                item.AddOn = obj.AddOn;
                item.Amount = obj.Amount;
                item.Bn = obj.Bn;
                item.Cost = obj.Cost;
                item.GPrice = obj.GPrice;
                item.GoodsState = obj.GoodsState;
                item.ItemType = obj.ItemType;
                item.Name = obj.Name;
                item.Nums = obj.Nums;
                item.ObjId = obj.ObjId;
                item.OrderId = obj.OrderId;
                item.Price = obj.Price;
                item.ProductId = obj.ProductId;
                item.Score = obj.Score;
                item.SendNum = obj.SendNum;
                item.TypeId = obj.TypeId;
                item.Weight = obj.Weight;
                item.GoodsFileId = obj.GoodsFileId;
                item.ProviderId = obj.ProviderId;
                rlist.Add(item);
            }
            return rlist;
        }
    }
}
