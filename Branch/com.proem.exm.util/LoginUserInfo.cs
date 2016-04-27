using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.util
{
    /// <summary>
    /// 登录用户信息存储类
    /// </summary>
    public static class LoginUserInfo
    {
        /// <summary>
        /// 登录用户Id 
        /// </summary>
        public static string id
        {
            get;
            set;
        }
        /// <summary>
        /// 登录用户姓名
        /// </summary>
        public static string name
        {
            get;
            set;
        }
        /// <summary>
        /// 分店编码
        /// </summary>
        public static string branchCode
        {
            get;
            set;
        }
        /// <summary>
        /// 分店名称
        /// </summary>
        public static string branchName
        { 
            get; 
            set; 
        }
        /// <summary>
        /// 分店id
        /// </summary>
        public static string branchId;

        /// <summary>
        /// 分店streetid
        /// </summary>
        public static string street;
    }
}
