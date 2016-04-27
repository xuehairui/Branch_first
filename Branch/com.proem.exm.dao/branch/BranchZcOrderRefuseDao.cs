using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.domain;
using log4net;
using MySql.Data.MySqlClient;
using Branch.com.proem.exm.util;

namespace Branch.com.proem.exm.dao.branch
{
    public class BranchZcOrderRefuseDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(BranchZcOrderRefuseDao));

        public void AddZcOrderRefuse(ZcOrderRefuse obj)
        {
            string sql = "insert into zc_order_refuse values (@id, @create, @update, @order_id, @order_amount, @actual_amount)";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@id", obj.id);
                cmd.Parameters.AddWithValue("@create", obj.createTime);
                cmd.Parameters.AddWithValue("@update", obj.updateTime);
                cmd.Parameters.AddWithValue("@order_id", obj.orderId);
                cmd.Parameters.AddWithValue("@order_amount", obj.orderAmount);
                cmd.Parameters.AddWithValue("@actual_amount", obj.actualAmount);
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("添加拒收订单信息异常", ex);
            }
            finally
            {
                tran.Dispose();
                cmd.Dispose();
                CloseConnection(conn);
            }
        }

        public ZcOrderRefuse FindById(string id)
        {
            ZcOrderRefuse obj = new ZcOrderRefuse();
            string sql = "select * from zc_order_refuse where id = @id";
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    obj.id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    obj.createTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(1);
                    obj.updateTime = reader.IsDBNull(2) ? default(DateTime) : reader.GetDateTime(2);
                    obj.orderId = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    obj.orderAmount = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    obj.actualAmount = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                }
            }
            catch (Exception ex)
            {
                log.Error("根据id获取拒收主表信息失败", ex);
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
