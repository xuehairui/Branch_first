using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.util
{
    public class ZcOrderHelper
    {
        /// <summary>
        /// 将zcOrderTransit 转化为zcOrderHistory
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static ZcOrderHistory Tranform(ZcOrderTransit obj)
        {
            ZcOrderHistory history = new ZcOrderHistory();
            history.Id = obj.Id;
            history.CreateTime = obj.CreateTime;
            history.UpdateTime = DateTime.Now;
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
            return history;
        }

        /// <summary>
        /// 将ZcOrderTransitItem 转换为 ZcOrderHistoryItem
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<ZcOrderHistoryItem> Transform(List<ZcOrderTransitItem> list)
        {
            List<ZcOrderHistoryItem> rlist = new List<ZcOrderHistoryItem>();
            foreach (ZcOrderTransitItem obj in list)
            {
                ZcOrderHistoryItem item = new ZcOrderHistoryItem();
                item.Id = obj.Id;
                item.CreateTime = obj.CreateTime;
                item.UpdateTime = DateTime.Now;
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
