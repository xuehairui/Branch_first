using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Branch.com.proem.exm.dao.master
{
    public class ZcZoningDao
    {
        private readonly ILog log = LogManager.GetLogger(typeof(ZcZoningDao));

        public List<ZcZoning> FindAll()
        {
            List<ZcZoning> list = new List<ZcZoning>();
            OracleConnection conn = null;
            try
            {
                conn = OracleUtil.OpenConn();
                string sql = "select * from ZC_ZONING";
                OracleCommand command = new OracleCommand(sql);
                command.Connection = conn;
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ZcZoning obj = new ZcZoning();
                    obj.Id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    obj.CreateTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(1);
                    obj.UpdateTime = reader.IsDBNull(2) ? default(DateTime) : reader.GetDateTime(2);
                    obj.City = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    obj.County = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    obj.Province = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                    obj.Street = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                    list.Add(obj);
                }
            }
            catch (Exception ex)
            {
                log.Error("下载全部数据失败", ex);
            }
            finally
            {
                OracleUtil.CloseConn(conn);
            }
            return list;
        }

        public List<ZcZoning> FindUpdate(DateTime lastUpdate)
        {
            List<ZcZoning> list = new List<ZcZoning>();
            string sql = "select * from zc_zoning where updatetime > :last";
            OracleConnection conn = null;
            OracleCommand cmd = new OracleCommand();
            try
            {
                conn = OracleUtil.OpenConn();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(":last", lastUpdate);
                OracleDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    ZcZoning obj = new ZcZoning();
                    obj.Id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    obj.CreateTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(1);
                    obj.UpdateTime = reader.IsDBNull(2) ? default(DateTime) : reader.GetDateTime(2);
                    obj.City = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    obj.County = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    obj.Province = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                    obj.Street = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                    list.Add(obj);
                }
            }
            catch (Exception ex)
            {
                log.Error("下载区域更新的数据失败", ex);
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
