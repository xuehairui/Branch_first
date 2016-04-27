using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.util;
using MySql.Data.MySqlClient;
using Branch.com.proem.exm.domain;
using log4net;
using System.Windows.Forms;

namespace Branch.com.proem.exm.dao.branch 
{
    /// <summary>
    /// pay_info操作类
    /// </summary>
    public class BranchPayInfoDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(BranchPayInfoDao));

        /// <summary>
        /// 添加收银信息
        /// </summary>
        /// <param name="obj"></param>
        public void AddPayInfo(PayInfo obj)
        {
            string sql = "insert into pay_info values(@id,@createTime, @updateTime, @amount ,@orderId, @salesmanId,@payDate,@payMode,@memberId,@branchId)";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@id", obj.Id);
                cmd.Parameters.AddWithValue("@createTime", obj.CreateTime);
                cmd.Parameters.AddWithValue("@updateTime", obj.UpdateTime);
                cmd.Parameters.AddWithValue("@amount", obj.PayAmount);
                cmd.Parameters.AddWithValue("@orderId", obj.orderId);
                cmd.Parameters.AddWithValue("@salesmanId", obj.salesmanId);
                cmd.Parameters.AddWithValue("@payDate", obj.payDate);
                cmd.Parameters.AddWithValue("@payMode", obj.PayMode);
                cmd.Parameters.AddWithValue("@memberId", obj.MemberId);
                cmd.Parameters.AddWithValue("@branchId", obj.BranchId);
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("保存收银信息发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                CloseConnection(conn);
            }
        }

        /// <summary>
        /// 获取当天收银员收银总额
        /// </summary>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public string FindAmountCashier(DateTime first, DateTime last, string p)
        {
            string sum = "";
            string sql = "select sum(pay_amount) from pay_info where salesman_id = @p and pay_date BETWEEN @first and @last;";
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@p", p);
                cmd.Parameters.AddWithValue("@first", first);
                cmd.Parameters.AddWithValue("@last", last);
                var reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    sum = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                }
            }
            catch (Exception ex)
            {
                log.Error("获取当天收银员收银总额失败", ex);
            }
            finally 
            {
                cmd.Dispose();
                CloseConnection(conn);
            }
            return sum;
        }

        public bool isExist(string orderId)
        {
            bool flag = false;
            string sql = "select count(1) from pay_info where order_id = @id";
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", orderId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    int count = reader.IsDBNull(0) ? default(int) : reader.GetInt32(0);
                    if (count > 0)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("查询订单号为"+ orderId + "的订单是否付款失败", ex);
            }
            finally
            {
                cmd.Dispose();
                CloseConnection(conn);
            }
            return flag;
        }

        public void AddPayInfo(List<PayInfo> payList)
        {
            string sql = "insert into pay_info values(@id,@createTime, @updateTime, @amount ,@orderId, @salesmanId,@payDate,@payMode,@memberId,@branchId)";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach(PayInfo obj in payList)
                {
                    cmd.Parameters.AddWithValue("@id", obj.Id);
                    cmd.Parameters.AddWithValue("@createTime", obj.CreateTime);
                    cmd.Parameters.AddWithValue("@updateTime", obj.UpdateTime);
                    cmd.Parameters.AddWithValue("@amount", obj.PayAmount);
                    cmd.Parameters.AddWithValue("@orderId", obj.orderId);
                    cmd.Parameters.AddWithValue("@salesmanId", obj.salesmanId);
                    cmd.Parameters.AddWithValue("@payDate", obj.payDate);
                    cmd.Parameters.AddWithValue("@payMode", obj.PayMode);
                    cmd.Parameters.AddWithValue("@memberId", obj.MemberId);
                    cmd.Parameters.AddWithValue("@branchId", obj.BranchId);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("保存收银信息发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                CloseConnection(conn);
            }
        }

        public PayInfo FindById(string p)
        {
            PayInfo obj = new PayInfo();
            string sql = "select * from pay_info where id= @id";
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", p);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    obj.Id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    obj.CreateTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(1);
                    obj.UpdateTime = reader.IsDBNull(2) ? default(DateTime) : reader.GetDateTime(2);
                    obj.PayAmount = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    obj.orderId = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    obj.salesmanId = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                    obj.payDate = reader.IsDBNull(6) ? default(DateTime) : reader.GetDateTime(6);
                    obj.PayMode = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                    obj.MemberId = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);
                    obj.BranchId = reader.IsDBNull(9) ? string.Empty : reader.GetString(9);
                }
            }
            catch (Exception ex)
            {
                log.Error("根据id获取支付信息失败", ex);
            }
            finally
            {
                cmd.Dispose();
                CloseConnection(conn);
            }
            return obj;
        }

        /// <summary>
        /// 获取该订单现金付款金额
        /// </summary>
        /// <param name="orderid"></param>
        /// <returns></returns>
        public string FindCashPayment(string orderid)
        {
            string money = "";
            string sql = "select sum(a.pay_amount) from pay_info a where order_id = @orderid and  a.pay_mode = 1; ";
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@orderid", orderid);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    money = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                }
            }
            catch (Exception ex)
            {
                log.Error("根据订单号获取现金支付金额发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                CloseConnection(conn);
            }
            return money;
        }

        /// <summary>
        /// 获取该订单付款方式
        /// </summary>
        /// <param name="orderid"></param>
        /// <returns></returns>
        internal List<string> FindModePayment(string orderid)
        {
            List<string> list = new List<string>();
            string mode = "";
            string sql = "select pay_mode from pay_info where order_id = @orderid ; ";
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@orderid", orderid);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    mode = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    list.Add(mode);
                }
            }
            catch (Exception ex)
            {
                log.Error("根据订单号获取现金支付金额发生异常", ex);
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
