using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using log4net;

namespace Branch.com.proem.exm.dao.branch
{
    public class BranchRoleDao : MysqlDBHelper
    {
        private readonly ILog log = LogManager.GetLogger(typeof(BranchRoleDao));

        /// <summary>
        /// 新增角色
        /// </summary>
        /// <param name="role"></param>
        public void AddRole(List<Role> list)
        {
            string sql = "insert into ctp_role values (@id,@createTime,@updateTime,@bpmlocked,@creater,@description, @name, @noteditable)";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach (Role role in list)
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", role.Id));
                    cmd.Parameters.Add(new MySqlParameter("@createTime", role.CreateTime));
                    cmd.Parameters.Add(new MySqlParameter("@updateTime", role.UpdateTime));
                    cmd.Parameters.Add(new MySqlParameter("@bpmlocked", role.Bpmlocked));
                    cmd.Parameters.Add(new MySqlParameter("@creater", role.Creater));
                    cmd.Parameters.Add(new MySqlParameter("@description", role.Description));
                    cmd.Parameters.Add(new MySqlParameter("@name", role.Name));
                    cmd.Parameters.Add(new MySqlParameter("@noteditable", role.Noteditable));
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("新增role发生异常", ex);
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
