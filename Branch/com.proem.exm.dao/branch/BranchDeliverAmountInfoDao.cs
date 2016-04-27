using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using MySql.Data.MySqlClient;

namespace Branch.com.proem.exm.dao.branch
{
    public class BranchDeliverAmountInfoDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(BranchDeliverAmountInfoDao));

        public void AddDeliverAmountInfoDao(DeliverAmountInfo obj) 
        {
            string sql = "insert into deliver_amount_info values (@id,@createTime, @updateTime, @salesman, @amount, @date,@branchId)";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", obj.Id);
                cmd.Parameters.AddWithValue("@createTime", obj.CreateTime);
                cmd.Parameters.AddWithValue("@updateTime", obj.UpdateTime);
                cmd.Parameters.AddWithValue("@salesman", obj.Salesman);
                cmd.Parameters.AddWithValue("@amount", obj.AmountCashier);
                cmd.Parameters.AddWithValue("@date", obj.Date);
                cmd.Parameters.AddWithValue("@branchId", obj.BranchId);
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("添加交班信息失败", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                CloseConnection(conn);
            }
        }

        /// <summary>
        /// 判断当前收银员是否已经交班
        /// </summary>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool isExist(DateTime first, DateTime last, string p)
        {
            bool flag = false;
            string sql = "select count(1) from deliver_amount_info where salesman = @p and date BETWEEN @first and @last;";
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
                if (reader.Read())
                {
                    int count = reader.IsDBNull(0) ? default(int) : reader.GetInt32(0);
                    if (count != 0)
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
                log.Error("判断当前收银员是否已经交班发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                CloseConnection(conn);
            }
            return flag;
        }

    }
}
