using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace Branch.com.proem.exm.util
{
    class OracleUtil
    {
        /// <summary>
        /// open 一个 conn
        /// </summary>
        /// <returns></returns>
        public static OracleConnection OpenConn()
        {
            OracleConnection conn = new OracleConnection(ConfigurationManager.ConnectionStrings["OracleDB"].ConnectionString);
             conn.Open();
             return conn;
         }

        /// <summary>
        /// 关闭conn 释放资源
        /// </summary>
        /// <param name="conn"></param>
        public static void CloseConn(OracleConnection conn)
         {
             if (conn == null) { return; }
             try
             {
                 if (conn.State != ConnectionState.Closed)
                 {
                     conn.Close();
                 }
             }
             catch (Exception e)
             {
                 Console.WriteLine(e.Message);
             }
             finally
             {
                 conn.Dispose();
             }
         }
        
    }
}
