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
    public class BranchZcUserInfoDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(BranchZcUserInfoDao));

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="list"></param>
        public void AddZcUserInfo(List<ZcUserInfo> list) 
        {
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                string sql = "insert into zc_user_info values (@id,@createTime,@updateTime,@email,@phone,@sex,@userName,@zipCode,@roleId,@userId,@zoningId, @branchInfoID)";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach(ZcUserInfo obj in list)
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", obj.Id));
                    cmd.Parameters.Add(new MySqlParameter("@createTime", obj.CreateTime));
                    cmd.Parameters.Add(new MySqlParameter("@updateTime", obj.UpdateTime));
                    cmd.Parameters.Add(new MySqlParameter("@email", obj.Email));
                    cmd.Parameters.Add(new MySqlParameter("@phone", obj.MobilePhone));
                    cmd.Parameters.Add(new MySqlParameter("@sex", obj.SexType));
                    cmd.Parameters.Add(new MySqlParameter("@userName", obj.UserName));
                    cmd.Parameters.Add(new MySqlParameter("@zipCode", obj.ZipCode));
                    cmd.Parameters.Add(new MySqlParameter("@roleId", obj.RoleId));
                    cmd.Parameters.Add(new MySqlParameter("@userId", obj.UserId));
                    cmd.Parameters.Add(new MySqlParameter("@zoningId", obj.ZoningId));
                    cmd.Parameters.AddWithValue("@branchInfoID", obj.branchTotalId);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("新增zc_user_Info发生异常", ex);
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
