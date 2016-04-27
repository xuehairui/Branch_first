using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using MySql.Data.MySqlClient;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;

namespace Branch.com.proem.exm.dao.branch
{
    public class BranchDailyReceiveGoodsDao : MysqlDBHelper
    {
        private readonly ILog log = LogManager.GetLogger(typeof(BranchDailyReceiveGoodsDao));

        public void AddDailyReceiveGoods(List<DailyReceiveGoods> list)
        {
            string sql = "insert into daily_receive_goods values(@id ,@createTime, @updateTime ,@number, @name, @classify, @unit, @goods_specifications, @price, @nums, @sortenum, @actual_quantity, @order_amount, @receive_amount, @salesman, @branchId, @receiveDate)";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach (DailyReceiveGoods obj in list)
                {
                    cmd.Parameters.AddWithValue("@id", obj.Id);
                    cmd.Parameters.AddWithValue("@createTime", obj.CreateTime);
                    cmd.Parameters.AddWithValue("@updateTime", obj.UpdateTime);
                    cmd.Parameters.AddWithValue("@number", obj.SerialNumber);
                    cmd.Parameters.AddWithValue("@name", obj.Name);
                    cmd.Parameters.AddWithValue("@classify", obj.Classify);
                    cmd.Parameters.AddWithValue("@unit", obj.GoodsUnit);
                    cmd.Parameters.AddWithValue("@goods_specifications", obj.GoodsSpecifications);
                    cmd.Parameters.AddWithValue("@price", obj.GooodsPrice);
                    cmd.Parameters.AddWithValue("@nums", obj.Nums);
                    cmd.Parameters.AddWithValue("@sortenum", obj.sortenum);
                    cmd.Parameters.AddWithValue("@actual_quantity", obj.ActualQuantity);
                    cmd.Parameters.AddWithValue("@order_amount", obj.OrderAmount);
                    cmd.Parameters.AddWithValue("@receive_amount", obj.ReceiveAmount);
                    cmd.Parameters.AddWithValue("@salesman", obj.Salesman);
                    cmd.Parameters.AddWithValue("@branchId", obj.BranchId);
                    cmd.Parameters.AddWithValue("@receiveDate", obj.receiveDate);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch(Exception ex)
            {
                tran.Rollback();
                log.Error("插入数据到daily_receive_goods表发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                cmd.Dispose();
                CloseConnection(conn);
            }
        }

        public DailyReceiveGoods FindById(string p)
        {
            DailyReceiveGoods obj = new DailyReceiveGoods();
            string sql = "select * from daily_receive_goods where id = @id";
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
                    obj.SerialNumber = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    obj.Name = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    obj.Classify = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                    obj.GoodsUnit = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                    obj.GoodsSpecifications = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                    obj.GooodsPrice = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);
                    obj.Nums = reader.IsDBNull(9) ? string.Empty : reader.GetString(9);
                    obj.sortenum = reader.IsDBNull(10) ? string.Empty : reader.GetString(10);
                    obj.ActualQuantity = reader.IsDBNull(11) ? string.Empty : reader.GetString(11);
                    obj.OrderAmount = reader.IsDBNull(12) ? string.Empty : reader.GetString(12);
                    obj.ReceiveAmount = reader.IsDBNull(13) ? string.Empty : reader.GetString(13);
                    obj.Salesman = reader.IsDBNull(14) ? string.Empty : reader.GetString(14);
                    obj.BranchId = reader.IsDBNull(15) ? string.Empty : reader.GetString(15);
                    obj.receiveDate = reader.IsDBNull(16) ? default(DateTime) : reader.GetDateTime(16);
                }
            }
            catch (Exception ex)
            {
                log.Error("根据id获取收货信息失败", ex);
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
