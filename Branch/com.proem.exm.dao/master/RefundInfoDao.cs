using Branch.com.proem.exm.dao.branch;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using log4net;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.dao.master
{
    /// <summary>
    /// 上传退款信息
    /// </summary>
    class RefundInfoDao
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(RefundInfoDao));

        /// <summary>
        /// 上传退款信息
        /// </summary>
        /// <param name="obj"></param>
        public void AddZcOrderRefund(ZcOrderRefund obj)
        {
            string sql = "insert into zc_order_refund (id, createTime, updateTime, order_id, order_amount, actual_amount, order_refund_status, hand_date) values (:id,:createTime,:updateTime,:order_id,:order_amount,:actual_amount,:order_refund_status,:hand_date)";
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
                cmd.Parameters.Add(":order_id", obj.Order_id);
                cmd.Parameters.Add(":order_amount", obj.Order_amount);
                cmd.Parameters.Add(":actual_amount", obj.Actual_amount);
                cmd.Parameters.Add(":order_refund_status", obj.Order_refund_status);
                cmd.Parameters.Add(":hand_date", obj.Hand_date);
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                List<UploadInfo> uploadList = new List<UploadInfo>();
                UploadDao dao = new UploadDao();
                UploadInfo obj1 = new UploadInfo();
                obj1.Id = obj.Id;
                obj1.CreateTime = DateTime.Now;
                obj1.UpdateTime = DateTime.Now;
                obj1.Type = Constant.ZC_ORDER_REFUND;
                uploadList.Add(obj1);
                dao.AddUploadInfo(uploadList);
                log.Error("上传退款信息到服务器失败", ex);
            }
            finally
            {
                tran.Dispose();
                cmd.Dispose();
                OracleUtil.CloseConn(conn);
            }
        }

        /// <summary>
        /// 上传退款明细信息
        /// </summary>
        /// <param name="list"></param>
        public void AddZcOrderRefundItem(List<ZcOrderRefundItem> list)
        {//
            string sql = "insert into zc_order_refund_item (id, createTime, updateTime, serialNumber, order_id, order_nums, refund_nums, price, refund_amount, salesman_id, hand_date, street, goodsFile_id, refund_id, refund_reason) values (:id,:createTime,:updateTime,:serialNumber,:order_id,:order_nums,:refund_nums,:price,:refund_amount,:salesman_id,:hand_date,:street,:goodsFile_id,:refund_id,:refund_reason)";
            OracleConnection conn = null;
            OracleCommand cmd = new OracleCommand();
            OracleTransaction tran = null;
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach (ZcOrderRefundItem obj in list)
                {
                    cmd.Parameters.Add(":id", obj.Id);
                    cmd.Parameters.Add(":createTime", obj.CreateTime);
                    cmd.Parameters.Add(":updateTime", obj.UpdateTime);
                    cmd.Parameters.Add(":serialNumber", obj.SerialNumber);
                    cmd.Parameters.Add(":order_id", obj.Order_id);
                    cmd.Parameters.Add(":order_nums", obj.Order_nums);
                    cmd.Parameters.Add(":refund_nums", obj.Refund_nums);
                    cmd.Parameters.Add(":price", obj.Price);
                    cmd.Parameters.Add(":refund_amount", obj.Refund_amount);
                    cmd.Parameters.Add(":salesman_id", obj.Salesman_id);
                    cmd.Parameters.Add(":hand_date", obj.Hand_date);
                    cmd.Parameters.Add(":street", obj.Street);
                    cmd.Parameters.Add(":goodsFile_id", obj.GoodsFile_id);
                    cmd.Parameters.Add(":refund_id", obj.Refund_id);
                    cmd.Parameters.Add(":refund_reason", obj.Refund_reason);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                List<UploadInfo> uploadList = new List<UploadInfo>();
                UploadDao uploadDao = new UploadDao();
                foreach (ZcOrderRefundItem obj in list)
                {
                    UploadInfo obj2 = new UploadInfo();
                    obj2.Id = obj.Id;
                    obj2.CreateTime = DateTime.Now;
                    obj2.UpdateTime = DateTime.Now;
                    obj2.Type = Constant.ZC_ORDER_REFUND_ITEM;
                    uploadList.Add(obj2);
                }
                uploadDao.AddUploadInfo(uploadList);
                log.Error("上传退款明细数据到服务器发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                cmd.Dispose();
                OracleUtil.CloseConn(conn);
            }
        }

        public bool AddZcOrderRefundI(ZcOrderRefund obj)
        {
            bool flag = false;
            string sql = "insert into zc_order_refund (id, createTime, updateTime, order_id, order_amount, actual_amount, order_refund_status, hand_date) values (:id,:createTime,:updateTime,:order_id,:order_amount,:actual_amount,:order_refund_status,:hand_date)";
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
                cmd.Parameters.Add(":order_id", obj.Order_id);
                cmd.Parameters.Add(":order_amount", obj.Order_amount);
                cmd.Parameters.Add(":actual_amount", obj.Actual_amount);
                cmd.Parameters.Add(":order_refund_status", obj.Order_refund_status);
                cmd.Parameters.Add(":hand_date", obj.Hand_date);
                cmd.ExecuteNonQuery();
                tran.Commit();
                flag = true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                flag = false;
                log.Error("上传退款信息到服务器失败", ex);
            }
            finally
            {
                tran.Dispose();
                cmd.Dispose();
                OracleUtil.CloseConn(conn);
            }
            return flag;
        }

        public bool AddZcOrderRefundItemI(ZcOrderRefundItem obj)
        {
            bool flag = false;
            string sql = "insert into zc_order_refund_item (id, createTime, updateTime, serialNumber, order_id, order_nums, refund_nums, price, refund_amount, salesman_id, hand_date, street, goodsFile_id, refund_id, refund_reason) values (:id,:createTime,:updateTime,:serialNumber,:order_id,:order_nums,:refund_nums,:price,:refund_amount,:salesman_id,:hand_date,:street,:goodsFile_id,:refund_id,:refund_reason)";
            OracleConnection conn = null;
            OracleCommand cmd = new OracleCommand();
            OracleTransaction tran = null;
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.Add(":id", obj.Id);
                cmd.Parameters.Add(":createTime", obj.CreateTime);
                cmd.Parameters.Add(":updateTime", obj.UpdateTime);
                cmd.Parameters.Add(":serialNumber", obj.SerialNumber);
                cmd.Parameters.Add(":order_id", obj.Order_id);
                cmd.Parameters.Add(":order_nums", obj.Order_nums);
                cmd.Parameters.Add(":refund_nums", obj.Refund_nums);
                cmd.Parameters.Add(":price", obj.Price);
                cmd.Parameters.Add(":refund_amount", obj.Refund_amount);
                cmd.Parameters.Add(":salesman_id", obj.Salesman_id);
                cmd.Parameters.Add(":hand_date", obj.Hand_date);
                cmd.Parameters.Add(":street", obj.Street);
                cmd.Parameters.Add(":goodsFile_id", obj.GoodsFile_id);
                cmd.Parameters.Add(":refund_id", obj.Refund_id);
                cmd.Parameters.Add(":refund_reason", obj.Refund_reason);
                cmd.ExecuteNonQuery();
                tran.Commit();
                flag = true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                flag = false;
                log.Error("上传退款明细数据到服务器发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                cmd.Dispose();
                OracleUtil.CloseConn(conn);
            }
            return flag;
        }
    }
}
