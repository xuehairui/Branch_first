using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using Branch.com.proem.exm.window.order;
using Branch.com.proem.exm.window.receive;
using Branch.com.proem.exm.window.retreat;
using log4net;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Branch.com.proem.exm.window.util
{
    /// <summary>
    /// 查询商品
    /// </summary>
    class QueryGoods
    {

        private DeliveryGoods deliveryGoods;
        private ReturnGoods returnGoods;
        private CustomerDelivery customerDelivery;

        /// <summary>
        /// 扫描的条码
        /// </summary>
        private string bar = "";
        /// <summary>
        /// 数量
        /// </summary>
        private string num = "";
        /// <summary>
        /// 当前传入的页面
        /// </summary>
        private string count = "";

        public QueryGoods()
        {

        }

        public QueryGoods(DeliveryGoods obj, string bar, string num)
        {
            this.deliveryGoods = obj;
            this.bar = bar;
            this.num = num;
            this.count = ParentWindow.DeliveryGoods.ToString();
            if (num.Equals(""))
            {
                this.num = "1";
            }
        }

        public QueryGoods(ReturnGoods obj, string bar, string num)
        {
            this.returnGoods = obj;
            this.bar = bar;
            this.num = num;
            this.count = ParentWindow.ReturnGoods.ToString();
            if (num.Equals(""))
            {
                this.num = "1";
            }
        }

        public QueryGoods(CustomerDelivery obj, string bar, string num)
        {
            this.customerDelivery = obj;
            this.bar = bar;
            this.num = num;
            this.count = ParentWindow.CustomerDelivery.ToString();
            if (num.Equals(""))
            {
                this.num = "1";
            }
        }

        /// <summary>
        /// 查询条码匹配的记录
        /// </summary>
        /// <param name="bar">条码</param>
        /// <returns>商品匹配的记录数</returns>
        public int queryExistGood( ILog log)
        {
            int con = 0;
            ZcGoodsMaster zcGoodsMaster = new ZcGoodsMaster();
            MysqlDBHelper dbHelper = new MysqlDBHelper();
            MySqlConnection conn = dbHelper.GetConnection();
            try
            {
                string sql = "select a.SERIALNUMBER ,a.goods_name,a.goods_unit,a.goods_specifications,a.goods_price,a.remark,a.id from zc_goods_master a "
                            + "left join zc_classify_info b on a.goods_class_id = b.id "
                            + "left join zc_classify_info c on a.goods_brand_id = c.id "
                            + "left join zc_provider_info d on a.goods_supplier_id = d.id where 1=1 ";
                if (this.count.Equals(ParentWindow.CustomerDelivery.ToString()) || this.count.Equals(ParentWindow.DeliveryGoods.ToString()))
                {
                    sql += " and a.SERIALNUMBER like '%" + bar + "%'";
                }
                else
                {
                    sql += " and a.SERIALNUMBER like '%" + bar + "%' or a.goods_name like '%" + bar + "%' or a.goods_unit like '%" + bar + "%' or a.goods_specifications like '%" + bar + "%' or a.goods_price like '%" + bar + "%' or a.remark like '%" + bar + "%' ;";
                }
                MySqlDataReader reader = dbHelper.GetReader(sql, conn);
                while (reader.Read())
                {
                    con += 1;
                    if (con == 1)
                    {
                        zcGoodsMaster.SerialNumber = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                        zcGoodsMaster.GoodsName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                        zcGoodsMaster.GoodsUnit = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                        zcGoodsMaster.GoodsSpecifications = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                        zcGoodsMaster.GoodsPrice = reader.IsDBNull(4) ? default(float) : reader.GetFloat(4);
                        zcGoodsMaster.Remark = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                        zcGoodsMaster.Id = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                    }
                }
                if (con == 1)
                { 
                    if (num.Equals(""))
                    {
                        num = "1";
                    }
                    if (this.count.Equals(ParentWindow.DeliveryGoods.ToString()))
                    {
                        this.deliveryGoods.AddGoods(zcGoodsMaster, num);
                    }
                    else if (this.count.Equals(ParentWindow.ReturnGoods.ToString()))
                    {
                        this.returnGoods.AddGoods(zcGoodsMaster, num);
                    }
                    else if (this.count.Equals(ParentWindow.CustomerDelivery.ToString()))
                    {
                        this.customerDelivery.AddGoods(zcGoodsMaster, num);
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("选择扫描商品绑定数据发生异常", ex);
            }
            finally
            {
                dbHelper.CloseConnection(conn);
            }
            return con;
        }
    }
}