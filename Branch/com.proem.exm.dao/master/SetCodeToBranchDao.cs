using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using log4net;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Branch.com.proem.exm.dao.master
{
    public class SetCodeToBranchDao
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(SetCodeToBranchDao));

        public void setIdCodeToBranch(string code, ZcBranchTotal zcBranchTotal, string id)
        {
            OracleConnection conn = null;
            OracleTransaction tran = null;
            OracleCommand cmd = new OracleCommand();
            string sql = "insert into zc_branchId_info (id,createTime, updateTime,branch_name_id, branch_selfcode) values (:id, :createTime, :updataTime,:branch_name, :branch_selfcode)";
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.Add(":id", Guid.NewGuid().ToString());
                cmd.Parameters.Add(":createTime", DateTime.Now);
                cmd.Parameters.Add(":updateTime", DateTime.Now);
                cmd.Parameters.Add(":branch_name", zcBranchTotal.Id);
                cmd.Parameters.Add(":branch_selfcode", code);
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("上传系统编码信息发生异常", ex);
            }
            finally
            {
                tran.Dispose();
                cmd.Dispose();
                OracleUtil.CloseConn(conn);
            }
        }
    }
}
