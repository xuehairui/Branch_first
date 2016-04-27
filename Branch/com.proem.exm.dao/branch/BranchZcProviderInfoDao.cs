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
    public class BranchZcProviderInfoDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(BranchZcProviderInfoDao));

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="list"></param>
        public void AddZcProviderInfo(List<ZcProviderInfo> list)
        {
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                string sql = "insert into zc_provider_info values (@id,@name)";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach (ZcProviderInfo obj in list)
                {
                    cmd.Parameters.AddWithValue("@id", obj.Id);
                    cmd.Parameters.AddWithValue("@name", obj.ProviderNickName);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("添加zc_provider_info发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                CloseConnection(conn);
            }
        }

    }
}
