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
    public class ZcOrderHistoryDao
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(ZcOrderHistoryDao));

        /// <summary>
        /// 添加数据到服务器
        /// </summary>
        /// <param name="history"></param>
        public void AddZcOrderHistory(ZcOrderHistory obj)
        {
            string sql = "insert into zc_order_history (id, createTime, updateTime, branchId, cansignphone, consignee, goodsnum, isgift, membercardnumber, orderamount, ordercome, orderdate, ordernum, orderreduceamount, orderstatus, ordertotalvalue, pullflag, member_Id, zczoning_id, actual_money, actual_nums) values (:id,:createTime,:updateTime,:branchId,:phone,:consignee,:goodsnum,:isgift,"
                    + ":cardNum,:orderAmount,:orderCome,:orderDate,:orderNum,:uceAmount,:status,:total,:flag,:memberId,:zczoningId, :actual_money, :actual_nums)";
            OracleConnection conn = null;
            OracleTransaction tran = null;
            OracleCommand cmd = new OracleCommand();
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.Add(new OracleParameter(":id", obj.Id));
                cmd.Parameters.Add(new OracleParameter(":createTime", obj.CreateTime));
                cmd.Parameters.Add(new OracleParameter(":updateTime", obj.UpdateTime));
                cmd.Parameters.Add(new OracleParameter(":branchId", obj.BranchId));
                cmd.Parameters.Add(new OracleParameter(":phone", obj.Cansignphone));
                cmd.Parameters.Add(new OracleParameter(":consignee", obj.Consignee));
                cmd.Parameters.Add(new OracleParameter(":goodsnum", obj.GoodSnum));
                cmd.Parameters.Add(new OracleParameter(":isgift", obj.IsGift));
                cmd.Parameters.Add(new OracleParameter(":cardNum", obj.MemberCardNumber));
                cmd.Parameters.Add(new OracleParameter(":orderAmount", obj.OrderAmount));
                cmd.Parameters.Add(new OracleParameter(":orderCome", obj.OrderCome));
                cmd.Parameters.Add(new OracleParameter(":orderDate", obj.OrderDate));
                cmd.Parameters.Add(new OracleParameter(":orderNum", obj.OrderNum));
                cmd.Parameters.Add(new OracleParameter(":uceAmount", obj.OrderRedUceAmount));
                cmd.Parameters.Add(new OracleParameter(":status", obj.OrderStatus));
                cmd.Parameters.Add(new OracleParameter(":total", obj.OrderTotalValue));
                cmd.Parameters.Add(new OracleParameter(":flag", obj.PullFlag));
                cmd.Parameters.Add(new OracleParameter(":memberId", obj.MemberId));
                cmd.Parameters.Add(new OracleParameter(":zczoningId", obj.ZczoingId));
                cmd.Parameters.Add(":actual_money", obj.ActualMoney);
                cmd.Parameters.Add(":actual_nums", obj.ActualNums);
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                List<UploadInfo> uploadList = new List<UploadInfo>();
                UploadDao uploadDao = new UploadDao();
                UploadInfo obj1 = new UploadInfo();
                obj1.Id = obj.Id;
                obj1.CreateTime = DateTime.Now;
                obj1.UpdateTime = DateTime.Now;
                obj1.Type = Constant.ZC_ORDER_HISTORY;
                uploadList.Add(obj1);
                uploadDao.AddUploadInfo(uploadList);
                log.Error("上传zcOrderHistory发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                OracleUtil.CloseConn(conn);
            }
        }

        /// <summary>
        /// 更新历史订单状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        public void UpdateOrderStatusByIds(string id, string status)
        {
            string sql = "update zc_order_history set orderstatus = '" + status + "' where id =" + id + "";
            OracleConnection conn = null;
            OracleTransaction tran = null;
            OracleCommand cmd = new OracleCommand();
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                List<UploadInfo> uploadList = new List<UploadInfo>();
                UploadDao DAO = new UploadDao();
                UploadInfo obj3 = new UploadInfo();
                obj3.Id = id;
                obj3.CreateTime = DateTime.Now;
                obj3.UpdateTime = DateTime.Now;
                obj3.Type = Constant.ZC_ORDER_HISTORY_UPDATE;
                uploadList.Add(obj3);
                DAO.AddUploadInfo(uploadList);
                log.Error("上传zcOrderHistory发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                OracleUtil.CloseConn(conn);
            }
        }

        public bool AddZcOrderHistoryI(ZcOrderHistory obj)
        {
            bool flag = false;
            string sql = "insert into zc_order_history (id, createTime, updateTime, branchId, cansignphone, consignee, goodsnum, isgift, membercardnumber, orderamount, ordercome, orderdate, ordernum, orderreduceamount, orderstatus, ordertotalvalue, pullflag, member_Id, zczoning_id, actual_money, actual_nums) values (:id,:createTime,:updateTime,:branchId,:phone,:consignee,:goodsnum,:isgift,"
                   + ":cardNum,:orderAmount,:orderCome,:orderDate,:orderNum,:uceAmount,:status,:total,:flag,:memberId,:zczoningId, :actual_money, :actual_nums)";
            OracleConnection conn = null;
            OracleTransaction tran = null;
            OracleCommand cmd = new OracleCommand();
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.Add(new OracleParameter(":id", obj.Id));
                cmd.Parameters.Add(new OracleParameter(":createTime", obj.CreateTime));
                cmd.Parameters.Add(new OracleParameter(":updateTime", obj.UpdateTime));
                cmd.Parameters.Add(new OracleParameter(":branchId", obj.BranchId));
                cmd.Parameters.Add(new OracleParameter(":phone", obj.Cansignphone));
                cmd.Parameters.Add(new OracleParameter(":consignee", obj.Consignee));
                cmd.Parameters.Add(new OracleParameter(":goodsnum", obj.GoodSnum));
                cmd.Parameters.Add(new OracleParameter(":isgift", obj.IsGift));
                cmd.Parameters.Add(new OracleParameter(":cardNum", obj.MemberCardNumber));
                cmd.Parameters.Add(new OracleParameter(":orderAmount", obj.OrderAmount));
                cmd.Parameters.Add(new OracleParameter(":orderCome", obj.OrderCome));
                cmd.Parameters.Add(new OracleParameter(":orderDate", obj.OrderDate));
                cmd.Parameters.Add(new OracleParameter(":orderNum", obj.OrderNum));
                cmd.Parameters.Add(new OracleParameter(":uceAmount", obj.OrderRedUceAmount));
                cmd.Parameters.Add(new OracleParameter(":status", obj.OrderStatus));
                cmd.Parameters.Add(new OracleParameter(":total", obj.OrderTotalValue));
                cmd.Parameters.Add(new OracleParameter(":flag", obj.PullFlag));
                cmd.Parameters.Add(new OracleParameter(":memberId", obj.MemberId));
                cmd.Parameters.Add(new OracleParameter(":zczoningId", obj.ZczoingId));
                cmd.Parameters.Add(":actual_money", obj.ActualMoney);
                cmd.Parameters.Add(":actual_nums", obj.ActualNums);
                cmd.ExecuteNonQuery();
                tran.Commit();
                flag = true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                flag = false;
                log.Error("上传zcOrderHistory发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                OracleUtil.CloseConn(conn);
            }
            return flag;
        }


        public bool UpdateOrderStatusByIdsI(string id, string status)
        {
            bool flag = false;
            string sql = "update zc_order_history set orderstatus = '" + status + "' where id =" + id + "";
            OracleConnection conn = null;
            OracleTransaction tran = null;
            OracleCommand cmd = new OracleCommand();
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                tran.Commit();
                flag = true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                flag = false;
                log.Error("上传zcOrderHistory发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                tran.Dispose();
                OracleUtil.CloseConn(conn);
            }
            return flag;
        }
    }
}
