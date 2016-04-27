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
    class RelUserRoleDao
    {

        public List<RelUserRole> FindAll()
        {
            List<RelUserRole> list = new List<RelUserRole>();
            OracleConnection conn = null;
            try
            {
                conn = OracleUtil.OpenConn();
                string sql = "select ID,CREATETIME, UPDATETIME, LEFTCLASSID, LEFTID, NOTDELETEREL, RIGHTCLASSID, RIGHTID from ctp_rel_user_role";
                OracleCommand command = new OracleCommand(sql);
                command.Connection = conn;
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    RelUserRole obj = new RelUserRole();
                    obj.Id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    obj.CreateTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(1);
                    obj.UpdateTime = reader.IsDBNull(2) ? default(DateTime) : reader.GetDateTime(2);
                    obj.LeftClassId = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    obj.LeftId = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    obj.NotdeLeteRel = reader.IsDBNull(5) ? default(int) : reader.GetInt32(5);
                    obj.RigthClassId = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                    obj.RightId = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
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
