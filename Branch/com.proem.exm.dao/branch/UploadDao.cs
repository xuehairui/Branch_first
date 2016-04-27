using Branch.com.proem.exm.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using log4net;
using Branch.com.proem.exm.domain;

namespace Branch.com.proem.exm.dao.branch
{
    public class UploadDao : MysqlDBHelper
    {
        private readonly ILog log = LogManager.GetLogger(typeof(UploadDao));

        public void AddUploadInfo(List<UploadInfo> list) 
        {
            string sql = "insert into upload values(@id, @createTime, @updateTime, @type)";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                foreach (UploadInfo obj in list)
                {
                    cmd.Parameters.AddWithValue("@id", obj.Id);
                    cmd.Parameters.AddWithValue("@createTime", obj.CreateTime);
                    cmd.Parameters.AddWithValue("@updateTime", obj.UpdateTime);
                    cmd.Parameters.AddWithValue("@type", obj.Type);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("存储待上传关联信息失败", ex);
            }
            finally
            {
                cmd.Dispose();
                CloseConnection(conn);
            }
        }

        public int QueryCount()
        {
            int count = 0;
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand();
            string sql = "select count(1) from upload";
            try
            {
                conn = GetConnection();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    count = reader.IsDBNull(0) ? default(int) : reader.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                log.Error("查询待上传记录数信息失败", ex);
            }
            finally
            {
                cmd.Dispose();
                CloseConnection(conn);
            }
            return count;
        }

        public List<UploadInfo> FindAll()
        {
            List<UploadInfo> list = new List<UploadInfo>();
            string sql = "select * from upload order by createTime";
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    UploadInfo obj = new UploadInfo();
                    obj.Id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    obj.CreateTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(1);
                    obj.UpdateTime = reader.IsDBNull(2) ? default(DateTime) : reader.GetDateTime(2);
                    obj.Type = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    list.Add(obj);
                }
            }
            catch (Exception ex)
            {
                log.Error("查询所有待上传信息失败", ex);
            }
            finally
            {
                cmd.Dispose();
                CloseConnection(conn);
            }
            return list;
        }

        public void DeleteByIdAndType(string p1, string p2)
        {
            string sql = "delete from upload where id = @id and type = @type";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", p1);
                cmd.Parameters.AddWithValue("@type", p2);
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("删除待上传信息表数据失败", ex);
            }
            finally
            {
                cmd.Dispose();
                CloseConnection(conn);
            }
        }
    }
}
