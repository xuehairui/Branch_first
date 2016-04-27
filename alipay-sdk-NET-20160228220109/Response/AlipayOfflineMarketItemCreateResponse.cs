using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketItemCreateResponse.
    /// </summary>
    public class AlipayOfflineMarketItemCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 传入的请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
