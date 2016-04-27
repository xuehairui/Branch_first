using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Branch.com.proem.exm.util
{
    /// <summary>
    /// Md5 工具类
    /// </summary>
    class MD5Util
    {
        /// <summary>
        /// 返回md5加密后的字符串
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string GetMd5(string password) 
        {
            byte[] result = Encoding.Default.GetBytes(password);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            //打印出md5加密后的密码
            return BitConverter.ToString(output).Replace("-", "").ToLower(); 
        }
    }
}
