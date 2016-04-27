using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCdpAdvertiseCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCdpAdvertiseCreateModel : AopObject
    {
        /// <summary>
        /// 用户点击广告后，跳转URL地址，必须为https协议。
        /// </summary>
        [XmlElement("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 广告位标识码，目前开放的广告位是钱包APP/口碑TAB/商家详情页中，传值：CDP_OPEN_MERCHANT
        /// </summary>
        [XmlElement("ad_code")]
        public string AdCode { get; set; }

        /// <summary>
        /// 广告展示规则。该规则用于商家设置对用户是否展示广告的校验条件，目前支持设置城市规则、商家店铺规则。按业务要求应用对应规则即可。
        /// </summary>
        [XmlElement("ad_rules")]
        public string AdRules { get; set; }

        /// <summary>
        /// 广告内容。如果广告类型是HTML5，则传入H5链接地址，必须为https协议。最大尺寸不得超过1242px＊242px，小屏幕将按分辨率宽度同比例放大缩小；如果类型是图片，则传入图片ID标识。如何获取图片ID参考图片上传接口：alipay.offline.material.image.upload。图片尺寸为1242px＊290px。图片大小不能超过50kb。
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 广告类型，目前包括HTML5和图片，分别传入：URL和PIC.
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 当广告类型是H5时，必须传入内容高度。对于广告位CDP_OPEN_MERCHANT的内容高度不能高于钱包要求的展位高度242px。  当广告类型是图片时，不需要传入内容高度(height)，系统会检查用户上传的图片尺寸是否符合要求，对于广告位CDP_OPEN_MERCHANT的图片尺寸要求：宽1242px, 高290px,大小50kb，实际上传图片与图片标准宽高必须一致，图片大小不能超过50kb。
        /// </summary>
        [XmlElement("height")]
        public string Height { get; set; }
    }
}
