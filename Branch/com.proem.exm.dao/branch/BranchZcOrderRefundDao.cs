using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using log4net;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.dao.branch
{
    /// <summary>
    /// 订单退款
    /// </summary>
    class BranchZcOrderRefundDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(BranchZcOrderRefundDao));

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="list"></param>
        public void AddZcOrderRefund(List<ZcOrderRefund> list)
        {
            string sql = "insert into zc_order_refund values (@id,@createTime,@updateTime,@order_id,@order_amount,@actual_amount,@order_refund_status,@hand_date)";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach (ZcOrderRefund obj in list)
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", obj.Id));
                    cmd.Parameters.Add(new MySqlParameter("@createTime", obj.CreateTime));
                    cmd.Parameters.Add(new MySqlParameter("@updateTime", obj.UpdateTime));
                    cmd.Parameters.Add(new MySqlParameter("@order_id", obj.Order_id));
                    cmd.Parameters.Add(new MySqlParameter("@order_amount", obj.Order_amount));
                    cmd.Parameters.Add(new MySqlParameter("@actual_amount", obj.Actual_amount));
                    cmd.Parameters.Add(new MySqlParameter("@order_refund_status", obj.Order_refund_status));
                    cmd.Parameters.Add(new MySqlParameter("@hand_date", obj.Hand_date));
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("新增ZcOrderRefund发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                CloseConnection(conn);
            }
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="obj"></param>
        public void AddZcOrderRefund(ZcOrderRefund obj)
        {
            string sql = "insert into zc_order_refund values (@id,@createTime,@updateTime,@order_id,@order_amount,@actual_amount,@order_refund_status,@hand_date)";
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
                cmd.Parameters.Add(new MySqlParameter("@order_id", obj.Order_id));
                cmd.Parameters.Add(new MySqlParameter("@order_amount", obj.Order_amount));
                cmd.Parameters.Add(new MySqlParameter("@actual_amount", obj.Actual_amount));
                cmd.Parameters.Add(new MySqlParameter("@order_refund_status", obj.Order_refund_status));
                cmd.Parameters.Add(new MySqlParameter("@hand_date", obj.Hand_date));
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("新增ZcOrderRefund发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                CloseConnection(conn);
            }
        }


        public ZcOrderRefund FindById(string p)
        {
            ZcOrderRefund obj = new ZcOrderRefund();
            string sql = "select * from zc_order_refund where id = @id";
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@id", p);
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    obj.Id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    obj.CreateTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(1);
                    obj.UpdateTime = reader.IsDBNull(2) ? default(DateTime) : reader.GetDateTime(2);
                    obj.Order_id = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    obj.Order_amount = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    obj.Actual_amount = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                    obj.Order_refund_status = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                    obj.Hand_date = reader.IsDBNull(7) ? default(DateTime) : reader.GetDateTime(7);
                }
            }
            catch (Exception ex)
            {
                log.Error("根据id获取退款信息失败", ex);
            }
            finally
            {
                cmd.Dispose();
                CloseConnection(conn);
            }
            return obj;
        }

        
    }
}