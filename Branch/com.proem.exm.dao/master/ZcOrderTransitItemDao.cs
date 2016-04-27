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
    public class ZcOrderTransitItemDao
    {
        private readonly ILog log = LogManager.GetLogger(typeof(ZcOrderTransitItemDao));

        public List<ZcOrderTransitItem> FindAll()
        {
            List<ZcOrderTransitItem> list = new List<ZcOrderTransitItem>();
            OracleConnection conn = null;
            try
            {
                conn = OracleUtil.OpenConn();
                string sql = "select ID, CREATETIME, UPDATETIME, ADDON, AMOUNT, BN, COST, G_PRICE, GOODS_STATE, ITEM_TYPE, "
                    + " NAME, NUMS, OBJ_ID, ORDER_ID, PRICE, PRODUCT_ID, SCORE, SENDNUM, TYPE_ID, WEIGHT, GOODSFILE_ID, PROVIDER_ID  from ZC_ORDER_TRANSIT_ITEM where ORDER_ID in "
                    +" (select a.id from ZC_ORDER_TRANSIT a where a.BRANCHID = '"+LoginUserInfo.street+"')";
                OracleCommand command = new OracleCommand(sql);
                command.Connection = conn;
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ZcOrderTransitItem obj = new ZcOrderTransitItem();
                    obj.Id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    obj.CreateTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(1);
                    obj.UpdateTime = reader.IsDBNull(2) ? default(DateTime) : reader.GetDateTime(2);
                    obj.AddOn = reader.IsDBNull(3) ? default(float) : reader.GetFloat(3);
                    obj.Amount = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    obj.Bn = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                    obj.Cost = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                    obj.GPrice = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                    obj.GoodsState = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);
                    obj.ItemType = reader.IsDBNull(9) ? string.Empty : reader.GetString(9);
                    obj.Name = reader.IsDBNull(10) ? string.Empty : reader.GetString(10);
                    obj.Nums = reader.IsDBNull(11) ? string.Empty : reader.GetString(11);
                    obj.ObjId = reader.IsDBNull(12) ? string.Empty : reader.GetString(12);
                    obj.OrderId = reader.IsDBNull(13) ? string.Empty : reader.GetString(13);
                    obj.Price = reader.IsDBNull(14) ? string.Empty : reader.GetString(14);
                    obj.ProductId = reader.IsDBNull(15) ? string.Empty : reader.GetString(15);
                    obj.Score = reader.IsDBNull(16) ? string.Empty : reader.GetString(16);
                    obj.SendNum = reader.IsDBNull(17) ? string.Empty : reader.GetString(17);
                    obj.TypeId = reader.IsDBNull(18) ? string.Empty : reader.GetString(18);
                    obj.Weight = reader.IsDBNull(19) ? string.Empty : reader.GetString(19);
                    obj.GoodsFileId = reader.IsDBNull(20) ? string.Empty : reader.GetString(20);
                    obj.ProviderId = reader.IsDBNull(21) ? string.Empty : reader.GetString(21);
                    list.Add(obj);
                }
            }
            catch (Exception ex)
            {
                log.Error("下载zc_order_transit_item数据异常", ex);
            }
            finally
            {
                OracleUtil.CloseConn(conn);
            }
            return list;
        }

        public void DeleteByOrderId(string orderNumber)
        {
            OracleConnection conn = null;
            OracleTransaction tran = null;
            OracleCommand cmd = new OracleCommand();
            string sql = "delete from zc_order_transit_item where order_id = :orderId";
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.Add(":orderId", orderNumber);
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                List<UploadInfo> list = new List<UploadInfo>();
                UploadDao dao = new UploadDao();
                UploadInfo obj = new UploadInfo();
                obj.Id = orderNumber;
                obj.CreateTime = DateTime.Now;
                obj.UpdateTime = DateTime.Now;
                obj.Type = Constant.ZC_ORDER_TRANSIT_ITEM_DELETE;
                list.Add(obj);
                dao.AddUploadInfo(list);
                log.Error("上传订单号删除订单商品信息失败", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                OracleUtil.CloseConn(conn);
            }
        }

        public bool DeleteByOrderIdI(string p)
        {
            bool flag = false;
            OracleConnection conn = null;
            OracleTransaction tran = null;
            OracleCommand cmd = new OracleCommand();
            string sql = "delete from zc_order_transit_item where order_id = :orderId";
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.Add(":orderId", p);
                cmd.ExecuteNonQuery();
                tran.Commit();
                flag = true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                flag = false;
                log.Error("上传订单号删除订单商品信息失败", ex);
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
