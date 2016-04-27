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
    public class BranchZcOrderRefuseItemDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(BranchZcOrderRefuseItemDao));

        public void AddZcOrderRefuseItems(List<ZcOrderRefuseItem> list)
        {
            string sql = "insert into zc_order_refuse_item values (@id, @create, @update, @serialNumber, @order_id, @order_nums, @refuse_nums, "
                +"@price, @refuse_amount, @salesman_id, @hand_date, @street, @goodsFile_id, @refuse_id, @reason)";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach (ZcOrderRefuseItem obj in list)
                {
                    cmd.Parameters.AddWithValue("@id", obj.id);
                    cmd.Parameters.AddWithValue("@create", obj.createTime);
                    cmd.Parameters.AddWithValue("@update", obj.updateTime);
                    cmd.Parameters.AddWithValue("@serialNumber", obj.serialNumber);
                    cmd.Parameters.AddWithValue("@order_id", obj.orderId);
                    cmd.Parameters.AddWithValue("@order_nums", obj.orderNums);
                    cmd.Parameters.AddWithValue("@refuse_nums", obj.refuseNums);
                    cmd.Parameters.AddWithValue("@price", obj.price);
                    cmd.Parameters.AddWithValue("@refuse_amount", obj.refuseAmount);
                    cmd.Parameters.AddWithValue("@salesman_id", obj.salesmanId);
                    cmd.Parameters.AddWithValue("@hand_date", obj.handDate);
                    cmd.Parameters.AddWithValue("@street", obj.street);
                    cmd.Parameters.AddWithValue("@goodsFile_id", obj.goodsFileId);
                    cmd.Parameters.AddWithValue("@refuse_id", obj.refuseId);
                    cmd.Parameters.AddWithValue("@reason", obj.refuseReason);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("新增拒收明细发生异常", ex);
            }
            finally
            {
                tran.Dispose();
                cmd.Dispose();
                CloseConnection(conn);
            }
        }

        public ZcOrderRefuseItem FindById(string p)
        {
            ZcOrderRefuseItem obj = new ZcOrderRefuseItem();
            string sql = "select * from zc_order_refuse_item where id = @id";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@id", p);
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    obj.id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    obj.createTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(1);
                    obj.updateTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(2);
                    obj.serialNumber = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    obj.orderId = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    obj.orderNums = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                    obj.refuseNums = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                    obj.price = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                    obj.refuseAmount = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);
                    obj.salesmanId = reader.IsDBNull(9) ? string.Empty : reader.GetString(9);
                    obj.handDate = reader.IsDBNull(10) ? default(DateTime) : reader.GetDateTime(10);
                    obj.street = reader.IsDBNull(11) ? string.Empty : reader.GetString(11);
                    obj.goodsFileId = reader.IsDBNull(12) ? string.Empty : reader.GetString(12);
                    obj.refuseId = reader.IsDBNull(13) ? string.Empty : reader.GetString(13);
                    obj.refuseReason = reader.IsDBNull(14) ? string.Empty : reader.GetString(14);
                }
            }
            catch (Exception ex)
            {
                log.Error("根据id获取拒收详细信息失败", ex);
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
