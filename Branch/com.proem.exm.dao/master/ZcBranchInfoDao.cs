using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Branch.com.proem.exm.domain;
using Oracle.ManagedDataAccess.Client;
using Branch.com.proem.exm.util;

namespace Branch.com.proem.exm.dao.master
{
    public class ZcBranchInfoDao
    {
        private ILog log = LogManager.GetLogger(typeof(ZcBranchInfoDao));

        public List<ZcBranchInfo> FindAll()
        {
            List<ZcBranchInfo> list = new List<ZcBranchInfo>();
            OracleConnection conn = null;
            try
            {
                conn = OracleUtil.OpenConn();
                string sql = "select ID,CREATETIME,UPDATETIME,APPROVEHOUSE,BRANCH_CODE,BRANCH_NAME,DELFLAG,BRANCHTOTAL_ID,CUSTOMER_ID,ZONING_ID  from zc_branch_info";
                OracleCommand cmd = new OracleCommand(sql, conn);
                var reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    ZcBranchInfo obj = new ZcBranchInfo();
                    obj.Id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    obj.CreateTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(1);
                    obj.UpdateTime = reader.IsDBNull(2) ? default(DateTime) : reader.GetDateTime(2);
                    obj.ApproveHouse = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    obj.BranchCode = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    obj.BranchName = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                    obj.DelFlag = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                    obj.BranchTotalId = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                    obj.CustomerId = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);
                    obj.ZoningId = reader.IsDBNull(9) ? string.Empty : reader.GetString(9);
                    list.Add(obj);
                }
            }
            catch (Exception ex)
            {
                log.Error("获取zcBranchInfo全部信息失败", ex);
            }
            finally
            {
                OracleUtil.CloseConn(conn);
            }
            return list;
        }
    }
}
