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
    public class BranchZcOrderTransitDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(BranchZcOrderTransitDao));

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="obj"></param>
        public void AddZcOrderTransit(List<ZcOrderTransit> list)
        {
            string sql = "insert into zc_order_transit values (@id,@createTime,@updateTime,@branchId,@phone,@consignee,@goodsnum,@isgift,"
                    + "@cardNum,@orderAmount,@orderCome,@orderDate,@orderNum,@uceAmount,@status,@total,@flag,@memberId,@zczoningId)";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach (ZcOrderTransit obj in list)
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", obj.Id));
                    cmd.Parameters.Add(new MySqlParameter("@createTime", obj.CreateTime));
                    cmd.Parameters.Add(new MySqlParameter("@updateTime", obj.UpdateTime));
                    cmd.Parameters.Add(new MySqlParameter("@branchId", obj.BranchId));
                    cmd.Parameters.Add(new MySqlParameter("@phone", obj.Cansignphone));
                    cmd.Parameters.Add(new MySqlParameter("@consignee", obj.Consignee));
                    cmd.Parameters.Add(new MySqlParameter("@goodsnum", obj.GoodSnum));
                    cmd.Parameters.Add(new MySqlParameter("@isgift", obj.IsGift));
                    cmd.Parameters.Add(new MySqlParameter("@cardNum", obj.MemberCardNumber));
                    cmd.Parameters.Add(new MySqlParameter("@orderAmount", obj.OrderAmount));
                    cmd.Parameters.Add(new MySqlParameter("@orderCome", obj.OrderCome));
                    cmd.Parameters.Add(new MySqlParameter("@orderDate", obj.OrderDate));
                    cmd.Parameters.Add(new MySqlParameter("@orderNum", obj.OrderNum));
                    cmd.Parameters.Add(new MySqlParameter("@uceAmount", obj.OrderRedUceAmount));
                    cmd.Parameters.Add(new MySqlParameter("@status", obj.OrderStatus));
                    cmd.Parameters.Add(new MySqlParameter("@total", obj.OrderTotalValue));
                    cmd.Parameters.Add(new MySqlParameter("@flag", obj.PullFlag));
                    cmd.Parameters.Add(new MySqlParameter("@memberId", obj.MemberId));
                    cmd.Parameters.Add(new MySqlParameter("@zczoningId", obj.ZczoingId));
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("添加一条数据到zc_order_transit发生错误", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                CloseConnection(conn);
            }
        }

        public ZcOrderTransit FindById(string id)
        {
            ZcOrderTransit obj = new ZcOrderTransit();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = GetConnection();
                String sql = "select * from zc_order_transit where id = @id";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", id);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    obj.Id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    obj.CreateTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(1);
                    obj.UpdateTime = reader.IsDBNull(2) ? default(DateTime) : reader.GetDateTime(2);
                    obj.BranchId = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    obj.Cansignphone = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    obj.Consignee = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                    obj.GoodSnum = reader.IsDBNull(6) ? default(int) : reader.GetInt32(6);
                    obj.IsGift = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                    obj.MemberCardNumber = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);
                    obj.OrderAmount = reader.IsDBNull(9) ? default(float) : reader.GetFloat(9);
                    obj.OrderCome = reader.IsDBNull(10) ? string.Empty : reader.GetString(10);
                    obj.OrderDate = reader.IsDBNull(11) ? default(DateTime) : reader.GetDateTime(11);
                    obj.OrderNum = reader.IsDBNull(12) ? string.Empty : reader.GetString(12);
                    obj.OrderRedUceAmount = reader.IsDBNull(13) ? default(float) : reader.GetFloat(13);
                    obj.OrderStatus = reader.IsDBNull(14) ? string.Empty : reader.GetString(14);
                    obj.OrderTotalValue = reader.IsDBNull(15) ? default(float) : reader.GetFloat(15);
                    obj.PullFlag = reader.IsDBNull(16) ? string.Empty : reader.GetString(16);
                    obj.MemberId = reader.IsDBNull(17) ? string.Empty : reader.GetString(17);
                    obj.ZczoingId = reader.IsDBNull(18) ? string.Empty : reader.GetString(18);
                }
            }
            catch (Exception ex)
            {
                log.Error("根据id获取订单信息异常", ex);
            }
            finally
            {
                cmd.Dispose();
                CloseConnection(conn);
            }
            return obj;
        }

        public void Update(ZcOrderTransit obj)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = GetConnection();
                string sql = "update zc_order_transit set updateTime = @time, goodsnum = @goodsnum, orderAmount= @orderAmount, orderstatus = @orderstatus where id = @id ";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@time", obj.UpdateTime);
                cmd.Parameters.AddWithValue("@goodsnum", obj.GoodSnum);
                cmd.Parameters.AddWithValue("@orderAmount", obj.OrderAmount);
                cmd.Parameters.AddWithValue("@orderstatus", obj.OrderStatus);
                cmd.Parameters.AddWithValue("@id", obj.Id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                log.Error("更新zc_order_transit 订单时发生错误", ex);
            }
            finally
            {
                cmd.Dispose();
                CloseConnection(conn);
            }
        }

        public void DeleteById(string orderNumber)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = GetConnection();
                string sql = "delete from zc_order_transit where id = @id";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", orderNumber);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                log.Error("根据订单号删除订单失败", ex);
            }
            finally
            {
                cmd.Dispose();
                CloseConnection(conn);
            }
        }

        /// <summary>
        /// 收货完成后，将全部订单的状态改为待提货
        /// </summary>
        public void UpdateOrderStatus(string orderstatus)
        {
            string sql = "update zc_order_transit set orderstatus = '"+orderstatus+"'";
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand(); ;
            MySqlTransaction tran = null;
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
                log.Error("收货完成后，将全部订单的状态改为待提货发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                CloseConnection(conn);
            }
        }

        public List<ZcOrderTransit> FindByIds(List<string> Idlist)
        {
            List<ZcOrderTransit> list = new List<ZcOrderTransit>();
            string sql = "select * from zc_order_transit where id in ("+string.Join(",", Idlist)+")";
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ZcOrderTransit obj = new ZcOrderTransit();
                    obj.Id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    obj.CreateTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(1);
                    obj.UpdateTime = reader.IsDBNull(2) ? default(DateTime) : reader.GetDateTime(2);
                    obj.BranchId = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    obj.Cansignphone = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    obj.Consignee = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                    obj.GoodSnum = reader.IsDBNull(6) ? default(int) : reader.GetInt32(6);
                    obj.IsGift = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                    obj.MemberCardNumber = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);
                    obj.OrderAmount = reader.IsDBNull(9) ? default(float) : reader.GetFloat(9);
                    obj.OrderCome = reader.IsDBNull(10) ? string.Empty : reader.GetString(10);
                    obj.OrderDate = reader.IsDBNull(11) ? default(DateTime) : reader.GetDateTime(11);
                    obj.OrderNum = reader.IsDBNull(12) ? string.Empty : reader.GetString(12);
                    obj.OrderRedUceAmount = reader.IsDBNull(13) ? default(float) : reader.GetFloat(13);
                    obj.OrderStatus = reader.IsDBNull(14) ? string.Empty : reader.GetString(14);
                    obj.OrderTotalValue = reader.IsDBNull(15) ? default(float) : reader.GetFloat(15);
                    obj.PullFlag = reader.IsDBNull(16) ? string.Empty : reader.GetString(16);
                    obj.MemberId = reader.IsDBNull(17) ? string.Empty : reader.GetString(17);
                    obj.ZczoingId = reader.IsDBNull(18) ? string.Empty : reader.GetString(18);
                    list.Add(obj);
                }
            }
            catch (Exception ex)
            {
                log.Error("根据订单号查询订单信息发生异常", ex);
            }
            finally 
            {
                cmd.Dispose();
                CloseConnection(conn);
            }
            return list;
        }

        /// <summary>
        /// 根据订单号集合删除订单
        /// </summary>
        /// <param name="list"></param>
        public void DeleteByIds(List<string> list)
        {
            string sql = "delete from zc_order_transit where id in ("+string.Join(",", list)+")";
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
                log.Error("根据订单号集合删除订单失败", ex);
            }
            finally
            {
                tran.Dispose();
                cmd.Dispose();
                CloseConnection(conn);
            }
        }

        public List<ZcOrderTransit> FindAll()
        {
            List<ZcOrderTransit> list = new List<ZcOrderTransit>();
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand();
            string sql = "select * from zc_order_transit";
            try
            {
                conn = GetConnection();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ZcOrderTransit obj = new ZcOrderTransit();
                    obj.Id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    obj.CreateTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(1);
                    obj.UpdateTime = reader.IsDBNull(2) ? default(DateTime) : reader.GetDateTime(2);
                    obj.BranchId = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    obj.Cansignphone = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    obj.Consignee = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                    obj.GoodSnum = reader.IsDBNull(6) ? default(int) : reader.GetInt32(6);
                    obj.IsGift = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                    obj.MemberCardNumber = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);
                    obj.OrderAmount = reader.IsDBNull(9) ? default(float) : reader.GetFloat(9);
                    obj.OrderCome = reader.IsDBNull(10) ? string.Empty : reader.GetString(10);
                    obj.OrderDate = reader.IsDBNull(11) ? default(DateTime) : reader.GetDateTime(11);
                    obj.OrderNum = reader.IsDBNull(12) ? string.Empty : reader.GetString(12);
                    obj.OrderRedUceAmount = reader.IsDBNull(13) ? default(float) : reader.GetFloat(13);
                    obj.OrderStatus = reader.IsDBNull(14) ? string.Empty : reader.GetString(14);
                    obj.OrderTotalValue = reader.IsDBNull(15) ? default(float) : reader.GetFloat(15);
                    obj.PullFlag = reader.IsDBNull(16) ? string.Empty : reader.GetString(16);
                    obj.MemberId = reader.IsDBNull(17) ? string.Empty : reader.GetString(17);
                    obj.ZczoingId = reader.IsDBNull(18) ? string.Empty : reader.GetString(18);
                    list.Add(obj);
                }
            }
            catch (Exception ex)
            {
                log.Error("获取订单信息失败", ex);
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

