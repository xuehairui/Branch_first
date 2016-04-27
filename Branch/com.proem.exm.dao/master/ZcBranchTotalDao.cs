using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.dao.master
{
    class ZcBranchTotalDao
    {
        public List<ZcBranchTotal> FindAll()
        {
            List<ZcBranchTotal> list = new List<ZcBranchTotal>();
            OracleConnection conn = null;
            try
            {
                conn = OracleUtil.OpenConn();
                string sql = "select ID,CREATETIME,UPDATETIME,BRANCH_CODE,BRANCH_NAME,DELFLAG,MONEY,CUSTOMER_ID,ZONING_ID  from ZC_BRANCH_TOTAL";
                OracleCommand command = new OracleCommand(sql);
                command.Connection = conn;
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ZcBranchTotal obj = new ZcBranchTotal();
                    obj.Id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    obj.CreateTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(1);
                    obj.UpdateTime = reader.IsDBNull(2) ? default(DateTime) : reader.GetDateTime(2);
                    obj.BranchCode = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    obj.BranchName = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    obj.DelFlag = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                    obj.Money = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                    obj.CustomerId = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                    obj.ZoningId = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);
                    list.Add(obj);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                OracleUtil.CloseConn(conn);
            }
            return list;
        }

        public ZcBranchTotal FindOfAll(string id)
        {
            OracleConnection conn = null;
            ZcBranchTotal obj = new ZcBranchTotal();
            try
            {
                conn = OracleUtil.OpenConn();
                string sql = "select * from ZC_BRANCH_TOTAL where branch_code ='" + id + "'";
                OracleCommand command = new OracleCommand(sql);
                command.Connection = conn;
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    obj.Id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    obj.CreateTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(1);
                    obj.UpdateTime = reader.IsDBNull(2) ? default(DateTime) : reader.GetDateTime(2);
                    obj.BranchCode = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    obj.BranchName = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    obj.DelFlag = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                    obj.Money = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                    obj.CustomerId = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                    obj.ZoningId = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                OracleUtil.CloseConn(conn);
            }
            return obj;
        }
    }
}
