using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.domain;
using MySql.Data.MySqlClient;
using Branch.com.proem.exm.util;
using log4net;
using Oracle.ManagedDataAccess.Client;

namespace Branch.com.proem.exm.dao.branch
{
    public class DownloadIdenifyDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(DownloadIdenifyDao));

        /// <summary>
        /// 查询标识
        /// </summary>
        /// <returns></returns>
        public DownloadIdentify FindIdentify()
        { 
            DownloadIdentify obj = new DownloadIdentify();
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand();
            string sql = "select * from download_identify where id = 1";
            try
            {
                conn = GetConnection();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                var reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    obj.Id = reader.IsDBNull(0) ? default(int) : reader.GetInt32(0);
                    obj.UpdateTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(1);
                }
            }
            catch (Exception ex)
            {
                log.Error("获取下载数据标识发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                CloseConnection(conn);
            }
            return obj;
        }

        /// <summary>
        /// 修改标识
        /// </summary>
        /// <param name="time"></param>
        public void UpdateIdentify(DateTime time)
        {
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            string sql = "update download_identify set update_time = @time, first_flag = '1' where id = 1";
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@time", time);
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("修改最近下载数据的时间", ex);
            }
            finally 
            {
                tran.Dispose();
                cmd.Dispose();
                CloseConnection(conn);
            }
        }

        /// <summary>
        /// 获取first_flag 标识
        /// </summary>
        /// <returns></returns>
        public int FindFlag()
        {
            int flag = 0;
            MySqlConnection conn = null;
            string sql = "select first_flag from download_identify where id = 1";
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                var reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    flag = reader.IsDBNull(0) ? default(int) : reader.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                log.Error("获取是否是第一次初始化判断标识", ex);
            }
            finally
            {
                CloseConnection(conn);
            }
            return flag;
        }

        /// <summary>
        /// 亭点是否收货
        /// </summary>
        /// <returns></returns>
        public bool IsHarvest()
        {
            bool flag = false;
            string sql = "select harvest_flag from download_identify where id =1";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection conn = null;
            try
            {
                conn = GetConnection();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        flag = reader.GetBoolean(0);
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("获取亭点是否收货标识失败", ex);
            }
            finally
            {
                cmd.Dispose();
                CloseConnection(conn);
            }
            return flag;
        }

        /// <summary>
        /// 更新亭长收货标识
        /// </summary>
        /// <param name="p"></param>
        public void UpdateHarvestFlag(bool p)
        {
            string sql = "update download_identify set harvest_flag = @flag where id =1";
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand();
            MySqlTransaction tran = null;
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@flag", p);
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("更新亭长收获标识失败", ex);
            }
            finally
            {
                tran.Dispose();
                cmd.Dispose();
                CloseConnection(conn);
            }

        }

        public DateTime GetLastUpdate()
        {
            DateTime last = new DateTime();
            string sql = "select update_time from download_identify where id = 1";
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    last = reader.IsDBNull(0) ? default(DateTime) : reader.GetDateTime(0); 
                }
            }
            catch (Exception ex)
            {
                log.Error("获取最后一次下载时间失败", ex);
            }
            finally
            {
                cmd.Dispose();
                CloseConnection(conn);
            }
            return last;
        }

        /// <summary>
        /// 获取系统编码
        /// </summary>
        /// <returns></returns>
        public string GetIdCode()
        {
            string code = "";
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand();
            string sql = "select idCode from download_identify where id = 1";
            try
            {
                conn = GetConnection();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    code = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                }
            }
            catch (Exception ex)
            {
                log.Error("获取系统编码发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                CloseConnection(conn);
            }
            return code;
        }


        /// <summary>
        /// 设置系统编码
        /// </summary>
        public void SetIdCode(string code)
        {
            string sql = "update download_identify set idCode = '" + code + "' where id = 1 ";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("设置系统编码发生异常", ex);
            }
            finally
            {
                tran.Dispose();
                cmd.Dispose();
                CloseConnection(conn);
            }
        }

        public void setBranchTotalId()
        {
            string sql = "update download_identify set branch_id = '" + LoginUserInfo.branchId + "' where id = 1 ";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("设置系统分店id发生异常", ex);
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
