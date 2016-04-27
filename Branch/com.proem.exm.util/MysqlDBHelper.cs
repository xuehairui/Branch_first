using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using log4net;
using System.Data;
using System.Configuration;

namespace Branch.com.proem.exm.util
{
    /// <summary>
    /// mysql  Dbhelper
    /// </summary>
    public class MysqlDBHelper : DBHelper
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["MysqlDB"].ConnectionString;

        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(MysqlDBHelper));

        /// <summary>
        /// 打开mysql 连接
        /// </summary>
        /// <returns></returns>
        public MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }

        /// <summary>
        /// 关闭mysql 连接
        /// </summary>
        /// <param name="conn"></param>
        public void CloseConnection(MySqlConnection conn)
        { 
            if(conn != null)
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 删除表中全部数据
        /// </summary>
        /// <param name="table">表名</param>
        public void DeleteAll(string table)
        {
            string sql = "TRUNCATE " + table;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = sql;
            MySqlTransaction tran = conn.BeginTransaction();
            try
            {
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("删除" + table + "中数据异常", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                CloseConnection(conn);
            }
        }

        /// <summary>
        /// 返回一个DataSet
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        public DataSet GetDataSet(string sql, string table)
        {
            DataSet ds = new DataSet();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataAdapter da = null;
            try
            {
                conn = GetConnection();
                cmd = new MySqlCommand(sql, conn);
                da = new MySqlDataAdapter(cmd);
                da.Fill(ds, table);
            }
            catch (Exception ex)
            {
                log.Error("获取" + table + "dataset异常", ex);
            }
            finally
            {
                da.Dispose();
                cmd.Dispose();
                CloseConnection(conn);
            }
            return ds;
        }

        /// <summary>
        /// 返回reader
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public MySqlDataReader GetReader(string sql, MySqlConnection conn)
        {
            MySqlDataReader reader = null; 
            MySqlCommand cmd = new MySqlCommand();;
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = sql;
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                log.Error("获取MySqlDataReader发生异常", ex);
            }
            return reader;
        }
    }
}
