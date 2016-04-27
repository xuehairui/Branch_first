using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using log4net;
using MySql.Data.MySqlClient;

namespace Branch.com.proem.exm.dao.branch
{
    public class BranchZcStoreHouseDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(BranchZcStoreHouseDao));

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="obj"></param>
        public void AddZcStoreHouse(List<ZcStoreHouse> list)
        {
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                string sql = "insert into zc_storehouse values(@id, @create, @update, @status, @store, @branchId, @createUserId, @goodsFileId)";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                foreach (ZcStoreHouse obj in list)
                {
                    cmd.Parameters.AddWithValue("@id", obj.Id);
                    cmd.Parameters.AddWithValue("@create", obj.CreateTime);
                    cmd.Parameters.AddWithValue("@update", obj.UpdateTime);
                    cmd.Parameters.AddWithValue("@status", obj.Status);
                    cmd.Parameters.AddWithValue("@store", obj.Store);
                    cmd.Parameters.AddWithValue("@branchId", obj.BranchId);
                    cmd.Parameters.AddWithValue("@createUserId", obj.CreateUserId);
                    cmd.Parameters.AddWithValue("@goodsFileId", obj.GoodsFileId);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("添加zc_storehouse数据异常", ex);
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
