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
    class UserDao
    {
        /// <summary>
        /// 从线上服务器获取所有的用户
        /// </summary>
        /// <returns></returns>
        public List<User> FindAll() 
        {
            List<User> list = new List<User>();
            OracleConnection conn = null;
            try
            {
                conn = OracleUtil.OpenConn();
                string sql = "select ID,CREATETIME, UPDATETIME, GENDER, NAME, PASSWORD  from ctp_user";
                OracleCommand command = new OracleCommand(sql);
                command.Connection = conn;
                var reader = command.ExecuteReader();
                while(reader.Read())
                {
                    User user = new User();
                    user.Id = reader.IsDBNull(0)? string.Empty : reader.GetString(0);
                    user.CreateTime = reader.IsDBNull(1)? default(DateTime) : reader.GetDateTime(1);
                    user.UpdateTime = reader.IsDBNull(2) ? default(DateTime) : reader.GetDateTime(2);
                    user.Gender = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    user.Name = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    user.Password = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                    list.Add(user);
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
