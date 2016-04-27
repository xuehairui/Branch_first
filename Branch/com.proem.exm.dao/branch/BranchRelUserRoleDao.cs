using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using MySql.Data.MySqlClient;

namespace Branch.com.proem.exm.dao.branch
{
    public class BranchRelUserRoleDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(BranchRelUserRoleDao));

        /// <summary>
        /// 新增RelUserRole
        /// </summary>
        /// <param name="list"></param>
        public void AddRelUserRole(List<RelUserRole> list)
        {
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = null;
            string sql = "insert into ctp_rel_user_role values (@id,@createTime,@updateTime,@left,@leftId, @notde, @right, @rightId)";
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd = new MySqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach(RelUserRole obj in list)
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", obj.Id));
                    cmd.Parameters.Add(new MySqlParameter("@createTime", obj.CreateTime));
                    cmd.Parameters.Add(new MySqlParameter("@updateTime", obj.UpdateTime));
                    cmd.Parameters.Add(new MySqlParameter("@left", obj.LeftClassId));
                    cmd.Parameters.Add(new MySqlParameter("@leftId", obj.LeftId));
                    cmd.Parameters.Add(new MySqlParameter("@notde", obj.NotdeLeteRel));
                    cmd.Parameters.Add(new MySqlParameter("@right", obj.RigthClassId));
                    cmd.Parameters.Add(new MySqlParameter("@rightId", obj.RightId));
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("向ctp_user_role_rel新增数据", ex);
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
