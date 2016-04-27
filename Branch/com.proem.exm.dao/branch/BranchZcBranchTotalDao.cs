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
    public class BranchZcBranchTotalDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(BranchZcBranchTotalDao));

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="list"></param>
        public void AddZcBranchTotal(List<ZcBranchTotal> list)
        {
            string sql = "insert into ZC_BRANCH_TOTAL values (@id,@createTime,@updateTime,@code,@name,@flag, @money,@customerId,@zoningId)";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach(ZcBranchTotal obj in list)
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", obj.Id));
                    cmd.Parameters.Add(new MySqlParameter("@createTime", obj.CreateTime));
                    cmd.Parameters.Add(new MySqlParameter("@updateTime", obj.UpdateTime));
                    cmd.Parameters.Add(new MySqlParameter("@code", obj.BranchCode));
                    cmd.Parameters.Add(new MySqlParameter("@name", obj.BranchName));
                    cmd.Parameters.Add(new MySqlParameter("@flag", obj.DelFlag));
                    cmd.Parameters.AddWithValue("@money", obj.Money);
                    cmd.Parameters.Add(new MySqlParameter("@customerId", obj.CustomerId));
                    cmd.Parameters.Add(new MySqlParameter("@zoningId", obj.ZoningId));
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("新增zcBranchTotal发生异常", ex);
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
