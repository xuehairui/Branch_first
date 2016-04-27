using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.util
{
    /// <summary>
    /// 订单状态枚举类
    /// </summary>
    public enum OrderEnum
    {

        /// <summary>
        /// 订单状态1：待处理
        /// </summary>
        [StringValue("1")]
        ORDER_STATUS_HANDLE = 1,
        /// <summary>
        /// 订单状态2：待采购
        /// </summary>
        [StringValue("2")]
        ORDER_STATUS_PURCHASE = 2,
        /// <summary>
        /// 订单状态3：待加工
        /// </summary>
        [StringValue("3")]
        ORDER_STATUS_PROCESSING = 3,
        /// <summary>
        /// 订单状态4：待分拣
        /// </summary>
        [StringValue("4")]
        ORDER_STATUS_SORTING = 4,
        /// <summary>
        /// 订单状态5：待配送
        /// </summary>
        [StringValue("5")]
        ORDER_STATUS_DISTRIBUTION = 5,
        /// <summary>
        /// 订单状态6：代提货
        /// </summary>
        [StringValue("6")]
        ORDER_STATUS_RECEIPT = 6,
        /// <summary>
        /// 订单状态：完成
        /// </summary>
        [StringValue("7")]
        ORDER_STATUS_FININSH = 7,
        /// <summary>
        /// 订单状态：待客服
        /// </summary>
        [StringValue("8")]
        ORDER_STATUS_SERVICE = 8,


    }
    public class StringValue : System.Attribute  
    {  
        private string _value;  
  
        public StringValue(string value)  
        {  
            _value = value;  
        }  
  
        public string Value  
        {  
            get { return _value; }  
        }  
  
    }  
  
    public static class OrderStatusEnum  
    {  
        public static string GetStringValue(Enum value)  
        {  
            string output = null;  
            Type type = value.GetType();  
  
            System.Reflection.FieldInfo fi = type.GetField(value.ToString());  
            StringValue[] attrs =  
               fi.GetCustomAttributes(typeof(StringValue),  
                                       false) as StringValue[];  
            if (attrs.Length > 0)  
            {  
                output = attrs[0].Value;  
            }  
  
            return output;  
        }  
    }  
}
