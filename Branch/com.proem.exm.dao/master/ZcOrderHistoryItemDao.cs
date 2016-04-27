using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Branch.com.proem.exm.dao.branch;

namespace Branch.com.proem.exm.dao.master
{
    public class ZcOrderHistoryItemDao
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(ZcOrderHistoryItemDao));

        public void AddZcOrderHistoryItem(List<ZcOrderHistoryItem> historyItemlist)
        {
            string sql = "insert into zc_order_history_item values (:id,:createTime,:updateTime, :actual_money, :actual_nums,:addOn,:amount,:bn,:cost,:gPrice,:goodsState,:itemType,"
                    + ":name,:nums,:objId,:orderId,:price,:productId,:score,:sendNum,:TypeId,:weight,:fileId,:providerId)";
            OracleConnection conn = null;
            OracleTransaction tran = null;
            OracleCommand cmd = new OracleCommand();
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach (ZcOrderHistoryItem obj in historyItemlist)
                {
                    cmd.Parameters.Add(new OracleParameter(":id", obj.Id));
                    cmd.Parameters.Add(new OracleParameter(":createTime", obj.CreateTime));
                    cmd.Parameters.Add(new OracleParameter(":updateTime", obj.UpdateTime));
                    cmd.Parameters.Add(":actual_money", obj.actualMoney);
                    cmd.Parameters.Add(":actual_nums", obj.actualNums);
                    cmd.Parameters.Add(new OracleParameter(":addOn", obj.AddOn));
                    cmd.Parameters.Add(new OracleParameter(":amount", obj.Amount));
                    cmd.Parameters.Add(new OracleParameter(":bn", obj.Bn));
                    cmd.Parameters.Add(new OracleParameter(":cost", obj.Cost));
                    cmd.Parameters.Add(new OracleParameter(":gPrice", obj.GPrice));
                    cmd.Parameters.Add(new OracleParameter(":goodsState", obj.GoodsState));
                    cmd.Parameters.Add(new OracleParameter(":itemType", obj.ItemType));
                    cmd.Parameters.Add(new OracleParameter(":name", obj.Name));
                    cmd.Parameters.Add(new OracleParameter(":nums", obj.Nums));
                    cmd.Parameters.Add(new OracleParameter(":objId", obj.ObjId));
                    cmd.Parameters.Add(new OracleParameter(":orderId", obj.OrderId));
                    cmd.Parameters.Add(new OracleParameter(":price", obj.Price));
                    cmd.Parameters.Add(new OracleParameter(":productId", obj.ProductId));
                    cmd.Parameters.Add(new OracleParameter(":score", obj.Score));
                    cmd.Parameters.Add(new OracleParameter(":sendNum", obj.SendNum));
                    cmd.Parameters.Add(new OracleParameter(":TypeId", obj.TypeId));
                    cmd.Parameters.Add(new OracleParameter(":weight", obj.Weight));
                    cmd.Parameters.Add(new OracleParameter(":fileId", obj.GoodsFileId));
                    cmd.Parameters.Add(new OracleParameter(":providerId", obj.ProviderId));
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                List<UploadInfo> list = new List<UploadInfo>();
                UploadDao dao = new UploadDao();
                foreach (ZcOrderHistoryItem obj in historyItemlist)
                {
                    UploadInfo obj1 = new UploadInfo();
                    obj1.Id = obj.Id;
                    obj1.CreateTime = DateTime.Now;
                    obj1.UpdateTime = DateTime.Now;
                    obj1.Type = Constant.ZC_ORDER_HISTORY_ITEM;
                    list.Add(obj1);
                }
                dao.AddUploadInfo(list);
                log.Error("新增zc_order_history_item发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                OracleUtil.CloseConn(conn);
            }
        }

        public bool AddZcOrderHistoryItemI(ZcOrderHistoryItem obj)
        {
            bool flag = false;
            string sql = "insert into zc_order_history_item values (:id,:createTime,:updateTime, :actual_money, :actual_nums,:addOn,:amount,:bn,:cost,:gPrice,:goodsState,:itemType,"
                    + ":name,:nums,:objId,:orderId,:price,:productId,:score,:sendNum,:TypeId,:weight,:fileId,:providerId)";
            OracleConnection conn = null;
            OracleTransaction tran = null;
            OracleCommand cmd = new OracleCommand();
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.Add(new OracleParameter(":id", obj.Id));
                cmd.Parameters.Add(new OracleParameter(":createTime", obj.CreateTime));
                cmd.Parameters.Add(new OracleParameter(":updateTime", obj.UpdateTime));
                cmd.Parameters.Add(":actual_money", obj.actualMoney);
                cmd.Parameters.Add(":actual_nums", obj.actualNums);
                cmd.Parameters.Add(new OracleParameter(":addOn", obj.AddOn));
                cmd.Parameters.Add(new OracleParameter(":amount", obj.Amount));
                cmd.Parameters.Add(new OracleParameter(":bn", obj.Bn));
                cmd.Parameters.Add(new OracleParameter(":cost", obj.Cost));
                cmd.Parameters.Add(new OracleParameter(":gPrice", obj.GPrice));
                cmd.Parameters.Add(new OracleParameter(":goodsState", obj.GoodsState));
                cmd.Parameters.Add(new OracleParameter(":itemType", obj.ItemType));
                cmd.Parameters.Add(new OracleParameter(":name", obj.Name));
                cmd.Parameters.Add(new OracleParameter(":nums", obj.Nums));
                cmd.Parameters.Add(new OracleParameter(":objId", obj.ObjId));
                cmd.Parameters.Add(new OracleParameter(":orderId", obj.OrderId));
                cmd.Parameters.Add(new OracleParameter(":price", obj.Price));
                cmd.Parameters.Add(new OracleParameter(":productId", obj.ProductId));
                cmd.Parameters.Add(new OracleParameter(":score", obj.Score));
                cmd.Parameters.Add(new OracleParameter(":sendNum", obj.SendNum));
                cmd.Parameters.Add(new OracleParameter(":TypeId", obj.TypeId));
                cmd.Parameters.Add(new OracleParameter(":weight", obj.Weight));
                cmd.Parameters.Add(new OracleParameter(":fileId", obj.GoodsFileId));
                cmd.Parameters.Add(new OracleParameter(":providerId", obj.ProviderId));
                cmd.ExecuteNonQuery();
                tran.Commit();
                flag = true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                flag = false;
                log.Error("新增zc_order_history_item发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                OracleUtil.CloseConn(conn);
            }
            return flag;
        }
    }
}
