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
    /// 订单退款明细
    /// </summary>
    class BranchZcOrderRefundItemDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(BranchZcOrderRefundItemDao));

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="list"></param>
        public void AddZcOrderRefundItem(List<ZcOrderRefundItem> list)
        {
            string sql = "insert into zc_order_refund_item values (@id,@createTime,@updateTime,@serialNumber,@order_id,@order_nums,@refund_nums,@price,@refund_amount,@salesman_id,@hand_date,@street,@goodsFile_id,@refund_id,@refund_reason)";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach (ZcOrderRefundItem obj in list)
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", obj.Id));
                    cmd.Parameters.Add(new MySqlParameter("@createTime", obj.CreateTime));
                    cmd.Parameters.Add(new MySqlParameter("@updateTime", obj.UpdateTime));
                    cmd.Parameters.Add(new MySqlParameter("@serialNumber", obj.SerialNumber));
                    cmd.Parameters.Add(new MySqlParameter("@order_id", obj.Order_id));
                    cmd.Parameters.Add(new MySqlParameter("@order_nums", obj.Order_nums));
                    cmd.Parameters.Add(new MySqlParameter("@refund_nums", obj.Refund_nums));
                    cmd.Parameters.Add(new MySqlParameter("@price", obj.Price));
                    cmd.Parameters.Add(new MySqlParameter("@refund_amount", obj.Refund_amount));
                    cmd.Parameters.Add(new MySqlParameter("@salesman_id", obj.Salesman_id));
                    cmd.Parameters.Add(new MySqlParameter("@hand_date", obj.Hand_date));
                    cmd.Parameters.Add(new MySqlParameter("@street", obj.Street));
                    cmd.Parameters.Add(new MySqlParameter("@goodsFile_id", obj.GoodsFile_id));
                    cmd.Parameters.Add(new MySqlParameter("@refund_id", obj.Refund_id));
                    cmd.Parameters.Add(new MySqlParameter("@refund_reason", obj.Refund_reason));
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("新增zc_order_refund_item发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                CloseConnection(conn);
            }
        }

        public ZcOrderRefundItem FindById(string p)
        {
            ZcOrderRefundItem obj = new ZcOrderRefundItem();
            string sql = "select * from zc_order_refund_item where id = @id";
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
                    obj.UpdateTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(2);
                    obj.SerialNumber = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    obj.Order_id = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    obj.Order_nums = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                    obj.Refund_nums = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                    obj.Price = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                    obj.Refund_amount = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);
                    obj.Salesman_id = reader.IsDBNull(9) ? string.Empty : reader.GetString(9);
                    obj.Hand_date = reader.IsDBNull(10) ? default(DateTime) : reader.GetDateTime(10);
                    obj.Street = reader.IsDBNull(11) ? string.Empty : reader.GetString(11);
                    obj.GoodsFile_id = reader.IsDBNull(12) ? string.Empty : reader.GetString(12);
                    obj.Refund_id = reader.IsDBNull(13) ? string.Empty : reader.GetString(13);
                    obj.Refund_reason = reader.IsDBNull(14) ? string.Empty : reader.GetString(14);
                }
            }
            catch (Exception ex)
            {
                log.Error("根据id获取退款详细信息失败", ex);
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
