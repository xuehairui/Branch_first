using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using Oracle.ManagedDataAccess.Client;

namespace Branch.com.proem.exm.dao.master
{
    public class DeliverAmountInfoDao
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(DeliverAmountInfoDao));

        /// <summary>
        /// 上传交班信息
        /// </summary>
        /// <param name="obj"></param>
        public void AddDeliverAmountInfo(DeliverAmountInfo obj)
        {
            string sql = "insert into zc_deliver_amountinfo (id, createTime, updateTime, amountcashier, branch_id, exchangedate, salesman) values (:id, :createTime, :updateTime, :amount, :branchId, :exdate, :salesman)";
            OracleConnection conn = null;
            OracleTransaction tran = null;
            OracleCommand cmd = new OracleCommand();
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.Add(":id", obj.Id);
                cmd.Parameters.Add(":createTime", obj.CreateTime);
                cmd.Parameters.Add(":updateTime", obj.UpdateTime);
                cmd.Parameters.Add(":amount", obj.AmountCashier);
                cmd.Parameters.Add(":branchId", obj.BranchId);
                cmd.Parameters.Add(":exdate", obj.Date);
                cmd.Parameters.Add(":salesman", obj.Salesman);
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("上传交班信息到服务器失败", ex);
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
