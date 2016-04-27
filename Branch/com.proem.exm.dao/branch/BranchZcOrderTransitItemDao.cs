using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using log4net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.dao.branch
{
    public class BranchZcOrderTransitItemDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(BranchZcOrderTransitItemDao));

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="list"></param>
        public void AddZcOrderTransitItem(List<ZcOrderTransitItem> list)
        {
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                string sql = "insert into zc_order_transit_item values (@id,@createTime,@updateTime,@addOn,@amount,@bn,@cost,@gPrice,@goodsState,@itemType," 
                    + "@name,@nums,@objId,@orderId,@price,@productId,@score,@sendNum,@TypeId,@weight,@fileId,@providerId)";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach (ZcOrderTransitItem obj in list)
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", obj.Id));
                    cmd.Parameters.Add(new MySqlParameter("@createTime", obj.CreateTime));
                    cmd.Parameters.Add(new MySqlParameter("@updateTime", obj.UpdateTime));
                    cmd.Parameters.Add(new MySqlParameter("@addOn", obj.AddOn));
                    cmd.Parameters.Add(new MySqlParameter("@amount", obj.Amount));
                    cmd.Parameters.Add(new MySqlParameter("@bn", obj.Bn));
                    cmd.Parameters.Add(new MySqlParameter("@cost", obj.Cost));
                    cmd.Parameters.Add(new MySqlParameter("@gPrice", obj.GPrice));
                    cmd.Parameters.Add(new MySqlParameter("@goodsState", obj.GoodsState));
                    cmd.Parameters.Add(new MySqlParameter("@itemType", obj.ItemType));
                    cmd.Parameters.Add(new MySqlParameter("@name", obj.Name));
                    cmd.Parameters.Add(new MySqlParameter("@nums", obj.Nums));
                    cmd.Parameters.Add(new MySqlParameter("@objId", obj.ObjId));
                    cmd.Parameters.Add(new MySqlParameter("@orderId", obj.OrderId));
                    cmd.Parameters.Add(new MySqlParameter("@price", obj.Price));
                    cmd.Parameters.Add(new MySqlParameter("@productId", obj.ProductId));
                    cmd.Parameters.Add(new MySqlParameter("@score", obj.Score));
                    cmd.Parameters.Add(new MySqlParameter("@sendNum", obj.SendNum));
                    cmd.Parameters.Add(new MySqlParameter("@TypeId", obj.TypeId));
                    cmd.Parameters.Add(new MySqlParameter("@weight", obj.Weight));
                    cmd.Parameters.Add(new MySqlParameter("@fileId", obj.GoodsFileId));
                    cmd.Parameters.Add(new MySqlParameter("@providerId", obj.ProviderId));
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("新增zc_order_transit_item发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                CloseConnection(conn);
            }
        }

        public void DeleteById(string id)
        {
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                string sql = "delete from zc_order_transit_item where id = @id";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("根据id 删除订单商品发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                CloseConnection(conn);
            }
        }

        public void UpdateNumsAndAmountById(string id, string nums, string amount)
        {
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                string sql = "update zc_order_transit_item set amount=@amount, nums =@nums where id =@id";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@nums", nums);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("更新订单中的商品数量发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                CloseConnection(conn);
            }
        }

        public void DeleteByOrderId(string orderNumber)
        {
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            string sql = "delete from zc_order_transit_item where order_id = @orderId";
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("orderId", orderNumber);
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("根据订单号删除订单商品信息失败", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                CloseConnection(conn);
            }
        }

        /// <summary>
        /// 根据订单号的集合获取订单里的商品信息
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public List<ZcOrderTransitItem> FindByOrderIds(List<string> Idlist)
        {
            List<ZcOrderTransitItem> list = new List<ZcOrderTransitItem>();
            MySqlConnection conn = null;
            string sql = "select * from zc_order_transit_item where order_id in ("+string.Join("," ,Idlist)+")";
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                var reader = cmd.ExecuteReader();
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
                log.Error("根据订单号获取订单下商品信息失败", ex);
            }
            finally
            {
                cmd.Dispose();
                CloseConnection(conn);
            }
            return list;
        }

        /// <summary>
        /// 根据订单号删除订单下商品信息
        /// </summary>
        /// <param name="list"></param>
        public void DeleteByOrderIds(List<string> list)
        {
            string sql = "delete from zc_order_transit_item where order_id in ("+string.Join(",", list)+")";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("根据订单号删除订单下商品信息失败", ex);
            }
            finally
            {
                tran.Dispose();
                cmd.Dispose();
                CloseConnection(conn);
            }
        }

        public List<ZcOrderTransitItem> FindByOrderId(string orderId)
        {
            List<ZcOrderTransitItem> list = new List<ZcOrderTransitItem>();
            MySqlConnection conn = null;
            string sql = "select * from zc_order_transit_item where order_id = '"+orderId+"'";
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                var reader = cmd.ExecuteReader();
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
                log.Error("根据订单号获取订单下商品信息失败", ex);
            }
            finally
            {
                cmd.Dispose();
                CloseConnection(conn);
            }
            return list;
        }
    }
}
