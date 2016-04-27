using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.util
{
    public class BranchPay
    {
        /// <summary>
        /// 现金支付
        /// </summary>
        public const string money = "1";

        /// <summary>
        /// 会员卡支付
        /// </summary>
        public const string card = "2";

        /// <summary>
        /// 微信支付
        /// </summary>
        public const string WxPay = "3";

        /// <summary>
        /// 支付宝支付
        /// </summary>
        public const string ZFBPay = "4";

        /// <summary>
        /// 现金退款
        /// </summary>
        public const string money_refund = "5";
    }
}
