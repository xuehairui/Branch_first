using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Diagnostics;

namespace Branch.com.proem.exm.dao.branch
{
    public class BranchZcZoningDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private ILog log = LogManager.GetLogger(typeof(BranchZcZoningDao));

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="list"></param>
        public void AddZcZoning(List<ZcZoning> list)
        {
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            string sql = "insert into ZC_ZONING values (@id,@createTime,@updateTime,@city,@county,@province,@street)";
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                foreach(ZcZoning obj in list)
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", obj.Id));
                    cmd.Parameters.Add(new MySqlParameter("@createTime", obj.CreateTime));
                    cmd.Parameters.Add(new MySqlParameter("@updateTime", obj.UpdateTime));
                    cmd.Parameters.Add(new MySqlParameter("@city", obj.City));
                    cmd.Parameters.Add(new MySqlParameter("@county", obj.County));
                    cmd.Parameters.Add(new MySqlParameter("@province", obj.Province));
                    cmd.Parameters.Add(new MySqlParameter("@street", obj.Street));
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("批量插入zc_zoning数据失败", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                CloseConnection(conn);
            }
        }

        public void DeleteBy(List<ZcZoning> list)
        {
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            string sql = "delete from zc_zoning where id = @id";
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                foreach (ZcZoning obj in list)
                {
                    cmd.Parameters.AddWithValue("@id", obj.Id);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("根据id删除zc_zoning 失败", ex);
            }
            finally
            {
                tran.Dispose();
                cmd.Dispose();
                CloseConnection(conn);
            }
        }
    }
}
