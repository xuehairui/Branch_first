using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Oracle.ManagedDataAccess.Client;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using Branch.com.proem.exm.dao.branch;

namespace Branch.com.proem.exm.dao.master
{
    public class ZcOrderRefuseDao
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(ZcOrderRefuseDao));

        public void AddZcOrderRefuse(ZcOrderRefuse obj)
        {
            string sql = "insert into zc_order_refuse (id, CREATETIME, UPDATETIME, ACTUAL_AMOUNT, ORDER_AMOUNT, ORDER_ID) values (:id, :createTime, :updateTime, :actual_amount, :order_amount, :order_id)";
            OracleConnection conn = null;
            OracleTransaction tran = null;
            OracleCommand cmd = new OracleCommand();
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.Add(":id", obj.id);
                cmd.Parameters.Add(":createTime", obj.createTime);
                cmd.Parameters.Add(":updateTime", obj.updateTime);
                cmd.Parameters.Add(":actual_amount", obj.actualAmount);
                cmd.Parameters.Add(":order_amount", obj.orderAmount);
                cmd.Parameters.Add(":order_id", obj.orderId);
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                UploadDao dao = new UploadDao();
                List<UploadInfo> list = new List<UploadInfo>();
                UploadInfo obj1 = new UploadInfo();
                obj1.Id = obj.id;
                obj1.CreateTime = DateTime.Now;
                obj1.UpdateTime = DateTime.Now;
                obj1.Type = Constant.ZC_ORDER_REFUSE;
                list.Add(obj1);
                dao.AddUploadInfo(list);
                log.Error("上传拒收订单信息异常", ex);
            }
            finally
            {
                tran.Dispose();
                cmd.Dispose();
                OracleUtil.CloseConn(conn);
            }
            
        }

        public bool AddZcOrderRefuseI(ZcOrderRefuse obj)
        {
            bool flag = false;
            string sql = "insert into zc_order_refuse (id, CREATETIME, UPDATETIME, ACTUAL_AMOUNT, ORDER_AMOUNT, ORDER_ID) values (:id, :createTime, :updateTime, :actual_amount, :order_amount, :order_id)";
            OracleConnection conn = null;
            OracleTransaction tran = null;
            OracleCommand cmd = new OracleCommand();
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.Add(":id", obj.id);
                cmd.Parameters.Add(":createTime", obj.createTime);
                cmd.Parameters.Add(":updateTime", obj.updateTime);
                cmd.Parameters.Add(":actual_amount", obj.actualAmount);
                cmd.Parameters.Add(":order_amount", obj.orderAmount);
                cmd.Parameters.Add(":order_id", obj.orderId);
                cmd.ExecuteNonQuery();
                tran.Commit();
                flag = true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                flag = false;
                log.Error("上传拒收订单信息异常", ex);
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
;