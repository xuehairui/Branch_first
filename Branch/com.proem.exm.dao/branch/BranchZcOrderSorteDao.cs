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
    public class BranchZcOrderSorteDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(BranchZcOrderSorteDao));

        public void AddZcOrdeSorte(List<ZcOrderSorte> list)
        {
            string sql = "insert into zc_order_sorte values (@id, @createTime, @updateTime, @address, @goods_id, @goods_name, @ordersnums, @sortenum, @weight)";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach (ZcOrderSorte obj in list)
                {
                    cmd.Parameters.AddWithValue("@id", obj.Id);
                    cmd.Parameters.AddWithValue("@createTime", obj.CreateTime);
                    cmd.Parameters.AddWithValue("@updateTime", obj.UpdateTime);
                    cmd.Parameters.AddWithValue("@address", obj.Address);
                    cmd.Parameters.AddWithValue("@goods_id", obj.GoodsId);
                    cmd.Parameters.AddWithValue("@goods_name", obj.GoodsName);
                    cmd.Parameters.AddWithValue("@ordersnums", obj.OrdersNum);
                    cmd.Parameters.AddWithValue("@sortenum", obj.SorteNum);
                    cmd.Parameters.AddWithValue("@weight", obj.Weight);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("插入分拣信息失败", ex);
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
