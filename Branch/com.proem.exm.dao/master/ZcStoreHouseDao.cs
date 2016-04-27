using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using log4net;
using Oracle.ManagedDataAccess.Client;

namespace Branch.com.proem.exm.dao.master
{
    public class ZcStoreHouseDao
    {
        private ILog log = LogManager.GetLogger(typeof(ZcStoreHouseDao));

        /// <summary>
        /// 根据分店信息下载数据
        /// </summary>
        /// <returns></returns>
        public List<ZcStoreHouse> FindByBranchId()
        {
            List<ZcStoreHouse> list = new List<ZcStoreHouse>();
            OracleConnection conn = null;
            try
            {
                conn = OracleUtil.OpenConn();
                string sql = "select a.ID, a.CREATETIME, a.UPDATETIME, a.STATUS, a.STORE, a.STOREMONEY, a.BRANCH_ID, a.CREATEUSER_ID, a.GOODSFILE_ID  from ZC_STOREHOUSE a left join ZC_BRANCH_INFO b "
                +"on a.BRANCH_ID = b.id LEFT JOIN ZC_BRANCH_TOTAL c "
                +"on b.branchtotal_id = c.id where c.id = '"+LoginUserInfo.branchId+"'";
                OracleCommand cmd = new OracleCommand(sql, conn);
                var reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    ZcStoreHouse obj = new ZcStoreHouse();
                    obj.Id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    obj.CreateTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(1);
                    obj.UpdateTime = reader.IsDBNull(2) ? default(DateTime) : reader.GetDateTime(2);
                    obj.Status = reader.IsDBNull(3) ? default(int) : reader.GetInt32(3);
                    obj.Store = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    obj.BranchId = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                    obj.CreateUserId = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                    obj.GoodsFileId = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                    list.Add(obj);
                }
            }
            catch(Exception ex)
            {
                log.Error("下载分店相关库存信息异常", ex);
            }
            finally
            {
                OracleUtil.CloseConn(conn);
            }
            return list;
        }

    }
}
