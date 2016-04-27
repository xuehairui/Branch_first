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
    class ZcClassifyInfoDao
    {
        public List<ZcClassIfyInfo> FindAll()
        {
            List<ZcClassIfyInfo> list = new List<ZcClassIfyInfo>();
            OracleConnection conn = null;
            try
            {
                conn = OracleUtil.OpenConn();
                string sql = "select ID,CREATETIME,UPDATETIME,CHILDCOUNT,CLASSIFY_CODE,CLASSIFY_LEVEL, "
                    + " CLASSIFY_NAME, CLASSIFY_TYPE, COMMISSION, DELFLAG, ORDER_INDEX, PARENTID, PARENTPATH, TYPEID  from zc_classify_info";
                OracleCommand command = new OracleCommand(sql);
                command.Connection = conn;
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ZcClassIfyInfo obj = new ZcClassIfyInfo();
                    obj.Id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    obj.CreateTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(1);
                    obj.UpdateTime = reader.IsDBNull(2) ? default(DateTime) : reader.GetDateTime(2);
                    obj.ChildCount = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    obj.ClassifyCode = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    obj.ClassifyLevel = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                    obj.ClassifyName = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                    obj.ClassifyType = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                    obj.Commission = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);
                    obj.DelFlag = reader.IsDBNull(9) ? string.Empty : reader.GetString(9);
                    obj.OrderIndex = reader.IsDBNull(10) ? string.Empty : reader.GetString(10);
                    obj.ParentId = reader.IsDBNull(11) ? string.Empty : reader.GetString(11);
                    obj.ParentPath = reader.IsDBNull(12) ? string.Empty : reader.GetString(12);
                    obj.TypeId = reader.IsDBNull(13) ? string.Empty : reader.GetString(13);
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
