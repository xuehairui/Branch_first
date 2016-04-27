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
    public class BranchZcBranchInfoDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private ILog log = LogManager.GetLogger(typeof(BranchZcBranchInfoDao));

        public void AddZcBranchInfo(List<ZcBranchInfo> list)
        {
            string sql = "insert into zc_branch_info values (@id, @createTime, @updateTime, @code, @name, @flag, @cust, @zoning, @app, @total)";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach(ZcBranchInfo obj in list)
                {
                    cmd.Parameters.AddWithValue("@id", obj.Id);
                    cmd.Parameters.AddWithValue("@createTime", obj.CreateTime);
                    cmd.Parameters.AddWithValue("@updateTime", obj.UpdateTime);
                    cmd.Parameters.AddWithValue("@code", obj.BranchCode);
                    cmd.Parameters.AddWithValue("@name", obj.BranchName);
                    cmd.Parameters.AddWithValue("@flag", obj.DelFlag);
                    cmd.Parameters.AddWithValue("@cust", obj.CustomerId);
                    cmd.Parameters.AddWithValue("@zoning", obj.ZoningId);
                    cmd.Parameters.AddWithValue("@app", obj.ApproveHouse);
                    cmd.Parameters.AddWithValue("@total", obj.BranchTotalId);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("新增zcBranchInfo数据异常", ex);
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
