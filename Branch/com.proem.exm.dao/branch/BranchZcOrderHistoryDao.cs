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
    public class BranchZcOrderHistoryDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(BranchZcOrderHistoryDao));

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="obj"></param>
        public void AddZcOrderHistory(List<ZcOrderHistory> list)
        {
            string sql = "insert into zc_order_history values (@id,@createTime,@updateTime,@branchId,@phone,@consignee,@goodsnum,@isgift,"
                    + "@cardNum,@orderAmount,@orderCome,@orderDate,@orderNum,@uceAmount,@status,@total,@flag,@memberId,@zczoningId,@actual_money, @actual_nums)";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach(ZcOrderHistory obj in list)
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
                    cmd.Parameters.AddWithValue("@actual_money", obj.ActualMoney);
                    cmd.Parameters.AddWithValue("@actual_nums", obj.ActualNums);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("新增zcOrderHistory发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                CloseConnection(conn);
            }
        }

        /// <summary>
        /// 根据订单号更新订单状态
        /// </summary>
        /// <param name="list"></param>
        /// <param name="status"></param>
        public void UpdateOrderStatusByIds(List<string> list, string status)
        {
            string sql = "update zc_order_history set orderstatus = '"+status+"' where id in ("+string.Join(",", list)+")";
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
                log.Error("根据订单号更新订单状态发生异常", ex);
            }
            finally
            {
                tran.Dispose();
                cmd.Dispose();
                CloseConnection(conn);
            }
        }

        public void AddZcOrderHistory(ZcOrderHistory obj)
        {
            string sql = "insert into zc_order_history values (@id,@createTime,@updateTime,@branchId,@phone,@consignee,@goodsnum,@isgift,"
                    + "@cardNum,@orderAmount,@orderCome,@orderDate,@orderNum,@uceAmount,@status,@total,@flag,@memberId,@zczoningId, @actual_money, @actual_nums)";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                
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
                    cmd.Parameters.AddWithValue("@actual_money", obj.ActualMoney);
                    cmd.Parameters.AddWithValue("@actual_nums", obj.ActualNums);
                    cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("新增zcOrderHistory发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                CloseConnection(conn);
            }
        }

        /// <summary>
        /// 根据id查询历史订单信息
        /// </summary>
        /// <param name="id">订单号</param>
        /// <returns>该订单号下的历史订单信息</returns>
        internal ZcOrderHistory FindById(string id)
        {
            ZcOrderHistory obj = new ZcOrderHistory();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = GetConnection();
                String sql = "select * from zc_order_history where id = @id";
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
                    obj.ActualMoney = reader.IsDBNull(19) ? string.Empty : reader.GetString(19);
                    obj.ActualNums = reader.IsDBNull(20) ? string.Empty : reader.GetString(20);
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

        /// <summary>
        /// 根据订单号更新订单状态
        /// </summary>
        /// <param name="history"></param>
        /// <param name="status"></param>
        internal void UpdateOrderStatusByIds(string id, string status)
        {
            string sql = "update zc_order_history set orderstatus = '" + status + "' where id =" + id + "";
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
                log.Error("根据订单号更新订单状态发生异常", ex);
            }
            finally
            {
                tran.Dispose();
                cmd.Dispose();
                CloseConnection(conn);
            }
        }
    }
}
