using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using Oracle.ManagedDataAccess.Client;
using Branch.com.proem.exm.dao.branch;

namespace Branch.com.proem.exm.dao.master
{
    public class PayInfoDao
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(PayInfoDao));

        /// <summary>
        /// 添加付款信息
        /// </summary>
        /// <param name="payinfo"></param>
        public void AddPayInfo(PayInfo obj)
        {
            OracleConnection conn = null;
            OracleTransaction tran = null;
            OracleCommand cmd = new OracleCommand();
            string sql = "insert into zc_payinfo (id, createTime, updateTime, branch_id, memberid, orderid, payamount, paydate, paymode, salesman) values (:id, :createTime, :updateTime, :branchId, :memberId, :orderId, :payAmount, :payDate, :payMode, :salesman)";
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.Add(":id", obj.Id);
                cmd.Parameters.Add(":createTime", obj.CreateTime);
                cmd.Parameters.Add(":updateTime", obj.UpdateTime);
                cmd.Parameters.Add(":branchId", obj.BranchId);
                cmd.Parameters.Add(":memberId", obj.MemberId);
                cmd.Parameters.Add(":orderId", obj.orderId);
                cmd.Parameters.Add(":payAmount", obj.PayAmount);
                cmd.Parameters.Add(":payDate", obj.payDate);
                cmd.Parameters.Add(":payMode", obj.PayMode);
                cmd.Parameters.Add(":salesman", obj.salesmanId);
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("添加付款信息发生异常", ex);
            }
            finally
            {
                tran.Dispose();
                cmd.Dispose();
                OracleUtil.CloseConn(conn);
            }
        }

        public void AddPayInfo(List<PayInfo> payList)
        {
            OracleConnection conn = null;
            OracleTransaction tran = null;
            OracleCommand cmd = new OracleCommand();
            string sql = "insert into zc_payinfo (id, createTime, updateTime, branch_id, memberid, orderid, payamount, paydate, paymode, salesman) values (:id, :createTime, :updateTime, :branchId, :memberId, :orderId, :payAmount, :payDate, :payMode, :salesman)";
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach(PayInfo obj in payList)
                {
                    cmd.Parameters.Add(":id", obj.Id);
                    cmd.Parameters.Add(":createTime", obj.CreateTime);
                    cmd.Parameters.Add(":updateTime", obj.UpdateTime);
                    cmd.Parameters.Add(":branchId", obj.BranchId);
                    cmd.Parameters.Add(":memberId", obj.MemberId);
                    cmd.Parameters.Add(":orderId", obj.orderId);
                    cmd.Parameters.Add(":payAmount", obj.PayAmount);
                    cmd.Parameters.Add(":payDate", obj.payDate);
                    cmd.Parameters.Add(":payMode", obj.PayMode);
                    cmd.Parameters.Add(":salesman", obj.salesmanId);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                List<UploadInfo> list = new List<UploadInfo>();
                foreach (PayInfo obj in payList)
                {
                    UploadInfo uploadInfo = new UploadInfo();
                    uploadInfo.Id = obj.Id;
                    uploadInfo.CreateTime = DateTime.Now;
                    uploadInfo.UpdateTime = DateTime.Now;
                    uploadInfo.Type = Constant.PAY_INFO;
                    list.Add(uploadInfo);
                }
                UploadDao uploadDao = new UploadDao();
                uploadDao.AddUploadInfo(list);
                log.Error("添加付款信息发生异常", ex);
            }
            finally
            {
                tran.Dispose();
                cmd.Dispose();
                OracleUtil.CloseConn(conn);
            }
        }

        public bool AddPayInfoI(PayInfo obj)
        {
            bool flag = false;
            OracleConnection conn = null;
            OracleTransaction tran = null;
            OracleCommand cmd = new OracleCommand();
            string sql = "insert into zc_payinfo (id, createTime, updateTime, branch_id, memberid, orderid, payamount, paydate, paymode, salesman) values (:id, :createTime, :updateTime, :branchId, :memberId, :orderId, :payAmount, :payDate, :payMode, :salesman)";
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;

                cmd.Parameters.Add(":id", obj.Id);
                cmd.Parameters.Add(":createTime", obj.CreateTime);
                cmd.Parameters.Add(":updateTime", obj.UpdateTime);
                cmd.Parameters.Add(":branchId", obj.BranchId);
                cmd.Parameters.Add(":memberId", obj.MemberId);
                cmd.Parameters.Add(":orderId", obj.orderId);
                cmd.Parameters.Add(":payAmount", obj.PayAmount);
                cmd.Parameters.Add(":payDate", obj.payDate);
                cmd.Parameters.Add(":payMode", obj.PayMode);
                cmd.Parameters.Add(":salesman", obj.salesmanId);
                cmd.ExecuteNonQuery();
                tran.Commit();
                flag = true;
            }
            catch (Exception ex)
            {
                tran.Rollback();

                flag = false;
                log.Error("添加付款信息发生异常", ex);
            }
            finally
            {
                tran.Dispose();
                cmd.Dispose();
                OracleUtil.CloseConn(conn);
            }
            return flag;
        }
    }
}
