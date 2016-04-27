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
    class ZcUserInfoDao
    {
        public List<ZcUserInfo> FindAll()
        {
            List<ZcUserInfo> list = new List<ZcUserInfo>();
            OracleConnection conn = null;
            try
            {
                conn = OracleUtil.OpenConn();
                string sql = "select ID, CREATETIME, UPDATETIME, EMAIL, MOBILEPHONE, SEXTYPE, USERNAME, ZIPCODE, ROLE_ID, USER_ID, ZONING_ID, BRANCH_NAME_ID  from zc_user_info";
                OracleCommand command = new OracleCommand(sql);
                command.Connection = conn;
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ZcUserInfo obj = new ZcUserInfo();
                    obj.Id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    obj.CreateTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(1);
                    obj.UpdateTime = reader.IsDBNull(2) ? default(DateTime) : reader.GetDateTime(2);
                    obj.Email = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    obj.MobilePhone = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    obj.SexType = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                    obj.UserName = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                    obj.ZipCode = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                    obj.RoleId = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);
                    obj.UserId = reader.IsDBNull(9) ? string.Empty : reader.GetString(9);
                    obj.ZoningId = reader.IsDBNull(10) ? string.Empty : reader.GetString(10);
                    obj.branchTotalId = reader.IsDBNull(11) ? string.Empty : reader.GetString(11);
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
    }
}
