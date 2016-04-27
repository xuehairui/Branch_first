using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using log4net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Branch.com.proem.exm.dao.branch
{
    public class BranchZcGoodsMasterDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private ILog log = LogManager.GetLogger(typeof(BranchZcGoodsMasterDao));

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="list"></param>
        public void AddZcGoodsMaster(List<ZcGoodsMaster> list)
        {
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            string sql = "insert into zc_goods_master values (@id,@createTime,@updateTime,@a2,@a3,@a4,@a7,@a8,@a10,@a11,@a12,@a13,@a14," 
                    + "@a16,@a17,@a18,@a19,@a20,@a21,@a22,@a23,@a24,@a25,@a26,@a27,@a28,@a29,@a30,@a31,@a32,@a33,@a35,@a36,@a37,@a38,@a39,@a40,@a41,@a42," 
                    + "@a43,@a44,@a45,@a46,@a47,@a48,@a49,@a50,@a51,@a52,@a53,@a54,@a55,@a58,@a59,@a60,@a61)";
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach(ZcGoodsMaster obj in list)
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", obj.Id));
                    cmd.Parameters.Add(new MySqlParameter("@createTime", obj.CreateTime));
                    cmd.Parameters.Add(new MySqlParameter("@updateTime", obj.UpdateTime));
                    cmd.Parameters.Add(new MySqlParameter("@a2", obj.DistributionPrice));
                    cmd.Parameters.Add(new MySqlParameter("@a3", obj.EarlyWarningDays));
                    cmd.Parameters.Add(new MySqlParameter("@a4", obj.EarlyWarningDays2));
                    cmd.Parameters.Add(new MySqlParameter("@a7", obj.GoodsCode));
                    cmd.Parameters.Add(new MySqlParameter("@a8", obj.GoodsName));
                    cmd.Parameters.Add(new MySqlParameter("@a10", obj.GoodsOrigin));
                    cmd.Parameters.Add(new MySqlParameter("@a11", obj.GoodsPrice));
                    cmd.Parameters.Add(new MySqlParameter("@a12", obj.GoodsProperty));
                    cmd.Parameters.Add(new MySqlParameter("@a13", obj.GoodsPurchasePrice));
                    cmd.Parameters.Add(new MySqlParameter("@a14", obj.GoodsSpecifications));
                    cmd.Parameters.Add(new MySqlParameter("@a16", obj.GoodsType));
                    cmd.Parameters.Add(new MySqlParameter("@a17", obj.GoodsUnit));
                    cmd.Parameters.Add(new MySqlParameter("@a18", obj.GrossMargin));
                    cmd.Parameters.Add(new MySqlParameter("@a19", obj.InputTax));
                    cmd.Parameters.Add(new MySqlParameter("@a20", obj.JoinRate));
                    cmd.Parameters.Add(new MySqlParameter("@a21", obj.LowestPrice));
                    cmd.Parameters.Add(new MySqlParameter("@a22", obj.ManagementInventory));
                    cmd.Parameters.Add(new MySqlParameter("@a23", obj.MemberPrice));
                    cmd.Parameters.Add(new MySqlParameter("@a24", obj.MemberPrice2));
                    cmd.Parameters.Add(new MySqlParameter("@a25", obj.MemberPrice3));
                    cmd.Parameters.Add(new MySqlParameter("@a26", obj.MemberPrice4));
                    cmd.Parameters.Add(new MySqlParameter("@a27", obj.MemberPrice5));
                    cmd.Parameters.Add(new MySqlParameter("@a28", obj.OutTax));
                    cmd.Parameters.Add(new MySqlParameter("@a29", obj.PointOrNot));
                    cmd.Parameters.Add(new MySqlParameter("@a30", obj.PointsValue));
                    cmd.Parameters.Add(new MySqlParameter("@a31", obj.ProcurementStatus));
                    cmd.Parameters.Add(new MySqlParameter("@a32", obj.PurchaseSpecifications));
                    cmd.Parameters.Add(new MySqlParameter("@a33", obj.Remark));
                    cmd.Parameters.Add(new MySqlParameter("@a35", obj.ValidityPeriod));
                    cmd.Parameters.Add(new MySqlParameter("@a36", obj.ValucationMethod));
                    cmd.Parameters.Add(new MySqlParameter("@a37", obj.WholeSalePrice));
                    cmd.Parameters.Add(new MySqlParameter("@a38", obj.WholeSalePrice2));
                    cmd.Parameters.Add(new MySqlParameter("@a39", obj.WholeSalePrice3));
                    cmd.Parameters.Add(new MySqlParameter("@a40", obj.WholeSalePrice4));
                    cmd.Parameters.Add(new MySqlParameter("@a41", obj.WholeSalePrice5));
                    cmd.Parameters.Add(new MySqlParameter("@a42", obj.WholeSalePrice6));
                    cmd.Parameters.Add(new MySqlParameter("@a43", obj.WholeSalePrice7));
                    cmd.Parameters.Add(new MySqlParameter("@a44", obj.WholeSalePrice8));
                    cmd.Parameters.Add(new MySqlParameter("@a45", obj.DelFlag));
                    cmd.Parameters.Add(new MySqlParameter("@a46", obj.GoodsBrandId));
                    cmd.Parameters.Add(new MySqlParameter("@a47", obj.GoodsClassId));
                    cmd.Parameters.Add(new MySqlParameter("@a48", obj.GoodsSupplierId));
                    cmd.Parameters.Add(new MySqlParameter("@a49", obj.GoodsState));
                    cmd.Parameters.Add(new MySqlParameter("@a50", obj.SerialNumber));
                    cmd.Parameters.Add(new MySqlParameter("@a51", obj.GoodsDiscountRate));
                    cmd.Parameters.Add(new MySqlParameter("@a52", obj.GoodsPyCode));
                    cmd.Parameters.Add(new MySqlParameter("@a53", obj.ZcUserInfoId));
                    cmd.Parameters.Add(new MySqlParameter("@a54", obj.Store));
                    cmd.Parameters.Add(new MySqlParameter("@a55", obj.GoodsFileUserId));
                    cmd.Parameters.Add(new MySqlParameter("@a58", obj.GoodsTypeId));
                    cmd.Parameters.Add(new MySqlParameter("@a59", obj.GoodsAttribute));
                    cmd.Parameters.Add(new MySqlParameter("@a60", obj.ProductGoodsId));
                    cmd.Parameters.Add(new MySqlParameter("@a61", obj.WasteRate));
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("批量插入zc_goods_master异常", ex);
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
