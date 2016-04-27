using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using System;
using System.Collections.Generic;
using log4net;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.dao.branch
{
    public class BranchZcClassifyInfoDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(BranchZcClassifyInfoDao));

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="list"></param>
        public void AddZcClassifyInfo(List<ZcClassIfyInfo> list)
        {
            string sql = "insert into zc_classify_info values (@id,@createTime,@updateTime,@child,@code,@level,@name,@type,@commission,@flag,@index,@parentId,@path,@typeId)";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach(ZcClassIfyInfo obj in list)
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", obj.Id));
                    cmd.Parameters.Add(new MySqlParameter("@createTime", obj.CreateTime));
                    cmd.Parameters.Add(new MySqlParameter("@updateTime", obj.UpdateTime));
                    cmd.Parameters.Add(new MySqlParameter("@child", obj.ChildCount));
                    cmd.Parameters.Add(new MySqlParameter("@code", obj.ClassifyCode));
                    cmd.Parameters.Add(new MySqlParameter("@level", obj.ClassifyLevel));
                    cmd.Parameters.Add(new MySqlParameter("@name", obj.ClassifyName));
                    cmd.Parameters.Add(new MySqlParameter("@type", obj.ClassifyType));
                    cmd.Parameters.Add(new MySqlParameter("@commission", obj.Commission));
                    cmd.Parameters.Add(new MySqlParameter("@flag", obj.DelFlag));
                    cmd.Parameters.Add(new MySqlParameter("@index", obj.OrderIndex));
                    cmd.Parameters.Add(new MySqlParameter("@parentId", obj.ParentId));
                    cmd.Parameters.Add(new MySqlParameter("@path", obj.ParentPath));
                    cmd.Parameters.Add(new MySqlParameter("@typeId", obj.TypeId));
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("新增zcClassIfyInfo发生异常", ex);
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
