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
    public class ZcOrderSorteDao
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(ZcOrderSorteDao));

        public List<ZcOrderSorte> FindByStreet(DateTime lastUpdateTime)
        {
            List<ZcOrderSorte> list = new List<ZcOrderSorte>();
            string sql = "select ID, CREATETIME, UPDATETIME, ADDRESS, GOODS_ID, GOODS_NAME, ORDERSNUM, SORTENUM, WEIGHT  from zc_orders_sorte where address= :street and updateTime > :lastUpdateTime";
            OracleConnection conn = null;
            OracleCommand cmd = new OracleCommand();
            try
            {
                conn = OracleUtil.OpenConn();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.Add(":street", LoginUserInfo.street);
                cmd.Parameters.Add(":lastUpdateTime", lastUpdateTime);
                OracleDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    ZcOrderSorte obj = new ZcOrderSorte();
                    obj.Id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    obj.CreateTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(1);
                    obj.UpdateTime = reader.IsDBNull(2) ? default(DateTime) : reader.GetDateTime(2);
                    obj.Address = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    obj.GoodsId = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    obj.GoodsName = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                    obj.OrdersNum = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                    obj.SorteNum = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                    obj.Weight = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);
                    list.Add(obj);
                }
            }
            catch (Exception ex)
            {
                log.Error("下载分拣信息失败", ex);
            }
            finally
            {
                cmd.Dispose();
                OracleUtil.CloseConn(conn);
            }
            return list;
        }

    }
}
