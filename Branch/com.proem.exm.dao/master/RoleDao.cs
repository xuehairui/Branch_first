using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.domain;
using Oracle.ManagedDataAccess.Client;
using Branch.com.proem.exm.util;

namespace Branch.com.proem.exm.dao.master
{
    class RoleDao
    {
        public List<Role> FindAll()
        {
            List<Role> list = new List<Role>();
            OracleConnection conn = null;
            try
            {
                conn = OracleUtil.OpenConn();
                string sql = "select ID,CREATETIME,UPDATETIME, BPMLOCKED, CREATER, DESCRIPTION, NAME, NOTEDITABLE  from ctp_role";
                OracleCommand command = new OracleCommand(sql);
                command.Connection = conn;
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Role role = new Role();
                    role.Id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    role.CreateTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(1);
                    role.UpdateTime = reader.IsDBNull(2) ? default(DateTime) : reader.GetDateTime(2);
                    role.Bpmlocked = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    role.Creater = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    role.Description = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                    role.Name = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                    role.Noteditable = reader.IsDBNull(7) ? default(int) : reader.GetInt32(7);
                    list.Add(role);
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
