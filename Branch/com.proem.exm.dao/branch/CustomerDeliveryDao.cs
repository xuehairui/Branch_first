using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Branch.com.proem.exm.util;
using log4net;

namespace Branch.com.proem.exm.dao.branch
{
    public class CustomerDeliveryDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(CustomerDeliveryDao));

        /// <summary>
        /// 根据用户查找用户的订单号集合
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<string> FindOrderIdBySql(string sql)
        {
            List<string> list = new List<string>();
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    string orderId = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    list.Add(orderId);
                }
            }
            catch (Exception ex)
            {
                log.Error("获取指定用户信息的订单号", ex);
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
