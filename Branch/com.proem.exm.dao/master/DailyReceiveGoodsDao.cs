using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Oracle.ManagedDataAccess.Client;
using Branch.com.proem.exm.util;

namespace Branch.com.proem.exm.dao.master
{
    public class DailyReceiveGoodsDao
    {
        /// <summary>
        /// 日志
        /// </summary>
        private ILog log = LogManager.GetLogger(typeof(DailyReceiveGoodsDao));

        /// <summary>
        /// 添加收获信息
        /// </summary>
        /// <param name="list"></param>
        public void AddDailyReceiveGoods(List<DailyReceiveGoods> list)
        {
            string sql = "insert into zc_daily_receive (id, createTime, updateTime,actmoney, actnums, goodsname, goodsordernums, goodsprice, ordermoney, receivedate, salesman, serialnumber, specifications, unit, branch_id, classify_id, sortenum) values "
                + " (:id ,:createTime, :updateTime, :receive_amount , :actual_quantity, :name, :nums, :price, :order_amount, :receiveDate,:salesman, :serialnumber, :goods_specifications , :unit, :branchId, :classify , :sortenum)";
            OracleConnection conn = null;
            OracleCommand cmd = new OracleCommand();
            OracleTransaction tran = null;
            try
            {
                conn = OracleUtil.OpenConn();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach (DailyReceiveGoods obj in list)
                {
                    cmd.Parameters.Add(":id", obj.Id);
                    cmd.Parameters.Add(":createTime", obj.CreateTime);
                    cmd.Parameters.Add(":updateTime", obj.UpdateTime);
                    cmd.Parameters.Add(":receive_amount", obj.ReceiveAmount);
                    cmd.Parameters.Add(":actual_quantity", obj.ActualQuantity);
                    cmd.Parameters.Add(":name", obj.Name);
                    cmd.Parameters.Add(":nums", obj.Nums);
                    cmd.Parameters.Add(":price", obj.GooodsPrice);
                    cmd.Parameters.Add(":order_amount", obj.OrderAmount);
                    cmd.Parameters.Add(":receiveDate", obj.receiveDate);
                    cmd.Parameters.Add(":salesman", obj.Salesman);
                    cmd.Parameters.Add(":serialnumber", obj.SerialNumber);
                    cmd.Parameters.Add(":goods_specifications", obj.GoodsSpecifications);
                    cmd.Parameters.Add(":unit", obj.GoodsUnit);
                    cmd.Parameters.Add(":branchId", obj.BranchId);
                    cmd.Parameters.Add(":classify", obj.Classify);
                    cmd.Parameters.Add(":sortenum", obj.sortenum);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                List<UploadInfo> uploadList = new List<UploadInfo>();
                foreach (DailyReceiveGoods obj in list)
                {
                    UploadInfo uploadInfo = new UploadInfo();
                    uploadInfo.Id = obj.Id;
                    uploadInfo.CreateTime = DateTime.Now;
                    uploadInfo.UpdateTime = DateTime.Now;
                    uploadInfo.Type = Constant.DAILY_RECEIVE_GOODS;
                    uploadList.Add(uploadInfo);
                }
                log.Error("插入数据到daily_receive_goods表发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                cmd.Dispose();
                OracleUtil.CloseConn(conn);
            }
        }

        public bool AddDailyReceiveGoods(DailyReceiveGoods obj)
        {
            bool flag = false;
            string sql = "insert into zc_daily_receive (id, createTime, updateTime,actmoney, actnums, goodsname, goodsordernums, goodsprice, ordermoney, receivedate, salesman, serialnumber, specifications, unit, branch_id, classify_id, sortenum) values "
                + " (:id ,:createTime, :updateTime, :receive_amount , :actual_quantity, :name, :nums, :price, :order_amount, :receiveDate,:salesman, :serialnumber, :goods_specifications , :unit, :branchId, :classify , :sortenum)";
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
                cmd.Parameters.Add(":receive_amount", obj.ReceiveAmount);
                cmd.Parameters.Add(":actual_quantity", obj.ActualQuantity);
                cmd.Parameters.Add(":name", obj.Name);
                cmd.Parameters.Add(":nums", obj.Nums);
                cmd.Parameters.Add(":price", obj.GooodsPrice);
                cmd.Parameters.Add(":order_amount", obj.OrderAmount);
                cmd.Parameters.Add(":receiveDate", obj.receiveDate);
                cmd.Parameters.Add(":salesman", obj.Salesman);
                cmd.Parameters.Add(":serialnumber", obj.SerialNumber);
                cmd.Parameters.Add(":goods_specifications", obj.GoodsSpecifications);
                cmd.Parameters.Add(":unit", obj.GoodsUnit);
                cmd.Parameters.Add(":branchId", obj.BranchId);
                cmd.Parameters.Add(":classify", obj.Classify);
                cmd.Parameters.Add(":sortenum", obj.sortenum);
                cmd.ExecuteNonQuery();
                tran.Commit();
                flag = true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                flag = false;
                log.Error("插入数据到daily_receive_goods表发生异常", ex);
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
