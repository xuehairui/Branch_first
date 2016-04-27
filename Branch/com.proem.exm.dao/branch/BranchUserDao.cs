using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using System.Data;
using log4net;
using MySql.Data.MySqlClient;

namespace Branch.com.proem.exm.dao.branch
{
    /// <summary>
    /// 本地sqlite userDao实现
    /// </summary>
    public class BranchUserDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(BranchUserDao));

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(List<User> list)
        {
            string sql = "insert into ctp_user values (@id,@createTime,@updateTime,@gender,@name,@password)";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                foreach (User user in list)
                {
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new MySqlParameter("@id", user.Id));
                    cmd.Parameters.Add(new MySqlParameter("@createTime", user.CreateTime));
                    cmd.Parameters.Add(new MySqlParameter("@updateTime", user.UpdateTime));
                    cmd.Parameters.Add(new MySqlParameter("@gender", user.Gender));
                    cmd.Parameters.Add(new MySqlParameter("@name", user.Name));
                    cmd.Parameters.Add(new MySqlParameter("@password", user.Password));
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("新增user数据异常", ex);
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
