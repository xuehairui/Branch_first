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
    public class ZcOrderRefuseItemDao
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(ZcOrderRefuseItemDao));

        public void AddZcOrderRefuseItem(List<ZcOrderRefuseItem> list)
        {
            string sql = "insert into zc_order_refuse_item (ID, CREATETIME, UPDATETIME, HAND_DATE, ORDER_ID, ORDER_NUMS, "
                    + " PRICE, REFUSE_AMOUNT, REFUSE_NUMS, REFUSE_REASON, SALESMAN_ID, SERIALNUMBER, STREET, GOODSFILE_ID, REFUSE_ID ) "
                    + " values (:id, :createTime, :updateTime, :hand_date, :order_id, :order_nums, :price,  "
                    + " :refuse_amount, :refuse_nums, :reason, :salesman_id , :serialNumber, :street, :goodsFile_id, :refuse_id)";
            OracleConnection conn = null;
            OracleTransaction tran = null;
            OracleCommand cmd = new OracleCommand();
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach (ZcOrderRefuseItem obj in list)
                {
                    cmd.Parameters.Add(":id", obj.id);
                    cmd.Parameters.Add(":createTime", obj.createTime);
                    cmd.Parameters.Add(":updateTime", obj.updateTime);
                    cmd.Parameters.Add(":hand_date", obj.handDate);
                    cmd.Parameters.Add(":order_id", obj.orderId);
                    cmd.Parameters.Add(":order_nums", obj.orderNums);
                    cmd.Parameters.Add(":price", obj.price);
                    cmd.Parameters.Add(":refuse_amount", obj.refuseAmount);
                    cmd.Parameters.Add(":refuse_nums", obj.refuseNums);
                    cmd.Parameters.Add(":reason", obj.refuseReason);
                    cmd.Parameters.Add(":salesman_id", obj.salesmanId);
                    cmd.Parameters.Add(":serialNumber", obj.serialNumber);
                    cmd.Parameters.Add(":street", obj.street);
                    cmd.Parameters.Add(":goodsFile_id", obj.goodsFileId);
                    cmd.Parameters.Add(":refuse_id", obj.refuseId);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                List<UploadInfo> uploadList = new List<UploadInfo>();
                UploadDao dao = new UploadDao();
                foreach (ZcOrderRefuseItem obj in list)
                {
                    UploadInfo obj2 = new UploadInfo();
                    obj2.Id = obj.id;
                    obj2.CreateTime = DateTime.Now;
                    obj2.UpdateTime = DateTime.Now;
                    obj2.Type = Constant.ZC_ORDER_REFUSE_ITEM;
                    uploadList.Add(obj2);
                }
                dao.AddUploadInfo(uploadList);
                log.Error("新增拒收明细发生异常", ex);
            }
            finally
            {
                tran.Dispose();
                cmd.Dispose();
                OracleUtil.CloseConn(conn);
            }
        }


        public bool AddZcOrderRefuseItemI(ZcOrderRefuseItem obj)
        {
            bool flag = false;
            string sql = "insert into zc_order_refuse_item (ID, CREATETIME, UPDATETIME, HAND_DATE, ORDER_ID, ORDER_NUMS, "
                     + " PRICE, REFUSE_AMOUNT, REFUSE_NUMS, REFUSE_REASON, SALESMAN_ID, SERIALNUMBER, STREET, GOODSFILE_ID, REFUSE_ID ) "
                     + " values (:id, :createTime, :updateTime, :hand_date, :order_id, :order_nums, :price,  "
                     + " :refuse_amount, :refuse_nums, :reason, :salesman_id , :serialNumber, :street, :goodsFile_id, :refuse_id)";
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
                cmd.Parameters.Add(":hand_date", obj.handDate);
                cmd.Parameters.Add(":order_id", obj.orderId);
                cmd.Parameters.Add(":order_nums", obj.orderNums);
                cmd.Parameters.Add(":price", obj.price);
                cmd.Parameters.Add(":refuse_amount", obj.refuseAmount);
                cmd.Parameters.Add(":refuse_nums", obj.refuseNums);
                cmd.Parameters.Add(":reason", obj.refuseReason);
                cmd.Parameters.Add(":salesman_id", obj.salesmanId);
                cmd.Parameters.Add(":serialNumber", obj.serialNumber);
                cmd.Parameters.Add(":street", obj.street);
                cmd.Parameters.Add(":goodsFile_id", obj.goodsFileId);
                cmd.Parameters.Add(":refuse_id", obj.refuseId);
                cmd.ExecuteNonQuery();
                tran.Commit();
                flag = true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                flag = false;
                log.Error("新增拒收明细发生异常", ex);
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
