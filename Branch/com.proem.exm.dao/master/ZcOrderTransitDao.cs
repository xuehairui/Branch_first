using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Branch.com.proem.exm.dao.branch;

namespace Branch.com.proem.exm.dao.master
{
    public class ZcOrderTransitDao
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(ZcOrderTransitDao));

        public List<ZcOrderTransit> FindAll()
        { 
            List<ZcOrderTransit> list = new List<ZcOrderTransit>();
            OracleConnection conn = null;
            try
            {
                conn = OracleUtil.OpenConn();
                string sql = "select ID, CREATETIME, UPDATETIME, BRANCHID, CANSIGNPHONE, CONSIGNEE, "
                    + " GOODSNUM, ISGIFT, MEMBERCARDNUMBER, ORDERAMOUNT, ORDERCOME, ORDERDATE, ORDERNUM, ORDERREDUCEAMOUNT, "
                    + " ORDERSTATUS, ORDERTOTALVALUE, PULLFLAG, MEMBER_ID, ZCZONING_ID from zc_order_transit where branchid ='" + LoginUserInfo.street + "'";
                OracleCommand command = new OracleCommand(sql);
                command.Connection = conn;
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ZcOrderTransit obj = new ZcOrderTransit();
                    obj.Id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    obj.CreateTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(1);
                    obj.UpdateTime = reader.IsDBNull(2) ? default(DateTime) : reader.GetDateTime(2);
                    obj.BranchId = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    obj.Cansignphone = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    obj.Consignee = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                    obj.GoodSnum = reader.IsDBNull(6) ? default(int) : reader.GetInt32(6);
                    obj.IsGift = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                    obj.MemberCardNumber = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);
                    obj.OrderAmount = reader.IsDBNull(9) ? default(float) : reader.GetFloat(9);
                    obj.OrderCome = reader.IsDBNull(10) ? string.Empty : reader.GetString(10);
                    obj.OrderDate = reader.IsDBNull(11) ? default(DateTime) : reader.GetDateTime(11);
                    obj.OrderNum = reader.IsDBNull(12) ? string.Empty : reader.GetString(12);
                    obj.OrderRedUceAmount = reader.IsDBNull(13) ? default(float) : reader.GetFloat(13);
                    obj.OrderStatus = reader.IsDBNull(14) ? string.Empty : reader.GetString(14);
                    obj.OrderTotalValue = reader.IsDBNull(15) ? default(float) : reader.GetFloat(15);
                    obj.PullFlag = reader.IsDBNull(16) ? string.Empty : reader.GetString(16);
                    obj.MemberId = reader.IsDBNull(17) ? string.Empty : reader.GetString(17);
                    obj.ZczoingId = reader.IsDBNull(18) ? string.Empty : reader.GetString(18);
                    list.Add(obj);
                }
            }
            catch (Exception ex)
            {
                log.Error("从远处服务器查询订单信息失败", ex);
            }
            finally
            {
                OracleUtil.CloseConn(conn);
            }
            return list;
        }

        /// <summary>
        /// 更新状态
        /// </summary>
        /// <param name="tranlist"></param>
        public void UpdateStatus(List<ZcOrderTransit> tranlist)
        {
            string sql = "update zc_order_transit set orderstatus = :status where id = :id";
            OracleConnection conn = null;
            OracleCommand cmd = new OracleCommand();
            OracleTransaction tran = null;
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach(ZcOrderTransit obj in tranlist)
                {
                    cmd.Parameters.Add(":status", obj.OrderStatus);
                    cmd.Parameters.Add(":id", obj.Id);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                List<UploadInfo> uploadList = new List<UploadInfo>();
                foreach (ZcOrderTransit obj in tranlist)
                {
                    UploadInfo uploadInfo = new UploadInfo();
                    uploadInfo.Id = obj.Id;
                    uploadInfo.CreateTime = DateTime.Now;
                    uploadInfo.UpdateTime = DateTime.Now;
                    uploadInfo.Type = Constant.ZC_ORDER_TRANSIT_UPDATE;
                    uploadList.Add(uploadInfo);
                }
                log.Error("收获完成后上传订单信息失败", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                OracleUtil.CloseConn(conn);
            }
        }

        public void DeleteByOrderId(string orderNumber)
        {
            OracleConnection conn = null;
            OracleTransaction tran = null;
            OracleCommand cmd = new OracleCommand();
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                string sql = "delete from zc_order_transit where id = :id";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.Add(":id", orderNumber);
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                List<UploadInfo> list = new List<UploadInfo>();
                UploadDao dao = new UploadDao();
                UploadInfo obj = new UploadInfo();
                obj.Id = orderNumber;
                obj.CreateTime = DateTime.Now;
                obj.UpdateTime = DateTime.Now;
                obj.Type = Constant.ZC_ORDER_TRANSIT_DELETE;
                list.Add(obj);
                dao.AddUploadInfo(list);
                log.Error("服务器订单号删除订单失败", ex);
            }
            finally
            {
                tran.Dispose();
                cmd.Dispose();
                OracleUtil.CloseConn(conn);
            }
        }

        public bool UpdateStatus(string p1, string p2)
        {
            bool flag = false;
            OracleConnection conn = null;
            OracleTransaction tran = null;
            OracleCommand cmd = new OracleCommand();
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                string sql = "update zc_order_transit set orderstatus = :status, updateTime = :updateTime where id = :id";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.Add(":status", p2);
                cmd.Parameters.Add(":updateTime", DateTime.Now);
                cmd.Parameters.Add(":id", p1);
                cmd.ExecuteNonQuery();
                tran.Commit();
                flag = true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                flag = false;
                log.Error("服务器订单号删除订单失败", ex);
            }
            finally
            {
                tran.Dispose();
                cmd.Dispose();
                OracleUtil.CloseConn(conn);
            }
            return flag;
        }

        public bool DeleteById(string id)
        {
            bool flag = false;
            OracleConnection conn = null;
            OracleTransaction tran = null;
            OracleCommand cmd = new OracleCommand();
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                string sql = "delete from zc_order_transit where id = :id";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.Add(":id", id);
                cmd.ExecuteNonQuery();
                tran.Commit();
                flag = true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                flag = false;
                log.Error("服务器订单号删除订单失败", ex);
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
