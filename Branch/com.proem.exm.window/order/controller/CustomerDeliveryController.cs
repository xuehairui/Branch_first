using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Branch.com.proem.exm.util;
using MySql.Data.MySqlClient;
using System.Data;

namespace Branch.com.proem.exm.window.order.controller
{
    /// <summary>
    /// CustomerDelivery控制类
    /// </summary>
    public class CustomerDeliveryController
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(CustomerDeliveryController));

        /// <summary>
        /// 获取条件查询的记录数量
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public int GetOrderCounts(string searchString)
        {
            int count = 0;
            MysqlDBHelper dbHelper = new MysqlDBHelper();
            string sql = "select count(1) from zc_order_transit a left join zc_associator_info b on a.member_id = b.id where a.orderstatus = '"+Constant.ORDER_STATUS_RECEIPT+"' ";
            if(searchString != "")
            {
                ///根据条件查询
                sql += " and ( a.consignee like '%" + searchString + "%' or a.cansignphone like '%" + searchString + "%' or b.associator_cardnumber like '%"+searchString+"%' ) ";
            }
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = dbHelper.GetConnection();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    count = reader.IsDBNull(0) ? default(int) : reader.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                log.Error("获取条件查询的订单数量发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                dbHelper.CloseConnection(conn);
            }
            return count;
        }

        /// <summary>
        /// 根据条件获取单个符合条件的订单，会员信息。传入CustomerDelivery页面
        /// </summary>
        /// <param name="searchString"></param>
        /// <param name="customerDelivery"></param>
        public void GetOrderInfo(string searchString, CustomerDelivery customerDelivery)
        {
            MysqlDBHelper dbHelper = new MysqlDBHelper();
            string sql = "select a.id, a.consignee, a.cansignphone, b.associator_cardnumber, a.ORDERAMOUNT  from zc_order_transit a left join zc_associator_info b on a.member_id = b.id where a.orderstatus = '" + Constant.ORDER_STATUS_RECEIPT + "' ";
            if (searchString != "")
            {
                ///根据条件查询
                sql += " and ( a.consignee like '%" + searchString + "%' or a.cansignphone like '%" + searchString + "%' or b.associator_cardnumber like '%" + searchString + "%' ) ";
            }
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = dbHelper.GetConnection();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    string name = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    string phone = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                    string card = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    string amount = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    customerDelivery.setinform(id, amount, name, phone, card);
                }
            }
            catch (Exception ex)
            {
                log.Error("获取订单信息发送异常", ex);
            }
            finally
            {
                cmd.Dispose();
                dbHelper.CloseConnection(conn);
            }
        }

        /// <summary>
        /// 根据订单号获取商品的DataSet
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public DataSet GetGoodDataSetById(string orderId)
        {
            string sql = "select sum(nums) as nums,name,sum(g_price*nums) as totalprice,classify_name,goods_unit,delFlag,goods_specifications,serialNumber,g_price as actualnums,goodsfile_id,goods_class_id,g_price,orderNum from "
                + " (select a.goods_state,a.nums,b.goods_name as name ,b.goods_specifications,b.goods_unit,a.g_price,b.id as goodsfile_id,b.delFlag,b.serialNumber,c.classify_name,b.goods_class_id,b.goods_supplier_id,e.orderNum "
                + "from zc_order_transit e  "
                + "LEFT JOIN zc_associator_info f on e.member_id = f.id "
                + " LEFT JOIN zc_order_transit_item a on e.id = a.order_id "
                + " left join zc_goods_master b on a.goodsfile_id = b.id "
                + " left join zc_classify_info c on b.goods_class_id = c.id "
                + " where e.orderNum='" + orderId + "'"
                + " )as d group by name,delFlag,classify_name,goods_unit,goods_specifications,serialNumber,g_price,goodsfile_id,goods_class_id ";
            MysqlDBHelper dbHelper = new MysqlDBHelper();
            DataSet ds = dbHelper.GetDataSet(sql, "zc_order_transit");
            return ds;
        }

        /// <summary>
        /// 根据订单号获取商品的DataSet-退款
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        internal DataSet GetReturnGoodDataSetById(string order_Num)
        {
            string sql = "select sum(nums) as nums,name,sum(g_price*nums) as totalprice,classify_name,goods_unit,delFlag,goods_specifications,serialNumber,g_price as actualnums,goodsfile_id,goods_class_id,g_price,orderNum ,actual_nums,actual_money from "
                + " (select a.goods_state,a.name,a.nums,b.goods_specifications,b.goods_unit,a.g_price,b.id as goodsfile_id,b.delFlag,b.serialNumber,c.classify_name,b.goods_class_id,b.goods_supplier_id,e.orderNum,a.actual_nums,a.actual_money "
                + "from zc_order_history e  "
                + "LEFT JOIN zc_associator_info f on e.member_id = f.id "
                + " LEFT JOIN zc_order_history_item a on e.id = a.order_id "
                + " left join zc_goods_master b on a.goodsfile_id = b.id "
                + " left join zc_classify_info c on b.goods_class_id = c.id "
                //+ " where e.orderNum='" + order_Num + "' and e.orderstatus not in ('" + Constant.ORDER_STATUS_ALL_REFUSE + "','" + Constant.ORDER_STATUS_PART_REFUSE + "','" + Constant.ORDER_STATUS_ALL_REFUND + "','" + Constant.ORDER_STATUS_PART_REFUND + "')"
                + " where e.orderNum='" + order_Num + "' and e.orderstatus in ('" + Constant.ORDER_STATUS_FININSH + "','" + Constant.ORDER_STATUS_PART_REFUSE + "')"
                + " )as d group by name,delFlag,classify_name,goods_unit,goods_specifications,serialNumber,g_price,goodsfile_id,goods_class_id ";

            MysqlDBHelper dbHelper = new MysqlDBHelper();
            DataSet ds = dbHelper.GetDataSet(sql, "zc_order_history");
            return ds;
        }

        /// <summary>
        /// 获取条件查询的记录数量-退款
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public int GetReturnOrderCounts(string searchString)
        {
            int count = 0;
            MysqlDBHelper dbHelper = new MysqlDBHelper();
            //string sql = "select count(1) from zc_order_transit a left join zc_associator_info b on a.member_id = b.id where a.orderstatus = '" + Constant.ORDER_STATUS_FININSH + "' ";

            //string sql = "select count(1) from zc_order_history a left join zc_associator_info b on a.member_id = b.id where a.orderstatus not in ('" + Constant.ORDER_STATUS_ALL_REFUSE + "','" + Constant.ORDER_STATUS_PART_REFUSE + "','" + Constant.ORDER_STATUS_ALL_REFUND + "','" + Constant.ORDER_STATUS_PART_REFUND + "') ";
            string sql = "select count(1) from zc_order_history a left join zc_associator_info b on a.member_id = b.id where a.orderstatus in ('" + Constant.ORDER_STATUS_FININSH + "','" + Constant.ORDER_STATUS_PART_REFUSE + "') ";
            if (searchString != "")
            {
                ///根据条件查询
                sql += " and ( a.consignee like '%" + searchString + "%' or a.cansignphone like '%" + searchString + "%' or b.associator_cardnumber like '%" + searchString + "%' ) ";
            }
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = dbHelper.GetConnection();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    count = reader.IsDBNull(0) ? default(int) : reader.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                log.Error("获取条件查询的订单数量发生异常", ex);
            }
            finally
            {
                cmd.Dispose();
                dbHelper.CloseConnection(conn);
            }
            return count;
        }

        /// <summary>
        /// 根据条件获取单个符合条件的订单，会员信息。传入CustomerDelivery页面-退款
        /// </summary>
        /// <param name="searchString"></param>
        /// <param name="customerDelivery"></param>
        public void GetReturnOrderInfo(string searchString, CustomerDelivery customerDelivery)
        {
            MysqlDBHelper dbHelper = new MysqlDBHelper();
            //string sql = "select a.id, a.consignee, a.cansignphone, b.associator_cardnumber, a.ORDERAMOUNT  from zc_order_transit a left join zc_associator_info b on a.member_id = b.id where a.orderstatus = '" + Constant.ORDER_STATUS_FININSH + "' ";

            string sql = "select a.id, a.consignee, a.cansignphone, b.associator_cardnumber, a.ORDERAMOUNT  from zc_order_history a left join zc_associator_info b on a.member_id = b.id where a.orderstatus in ('" + Constant.ORDER_STATUS_FININSH + "','" + Constant.ORDER_STATUS_PART_REFUSE + "') ";
            if (searchString != "")
            {
                ///根据条件查询
                sql += " and ( a.consignee like '%" + searchString + "%' or a.cansignphone like '%" + searchString + "%' or b.associator_cardnumber like '%" + searchString + "%' ) ";
            }
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = dbHelper.GetConnection();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    string name = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    string phone = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                    string card = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    string amount = reader.IsDBNull(4) ? string.Empty : reader.GetString(3);
                    customerDelivery.setinform(id, amount, name, phone, card);
                }
            }
            catch (Exception ex)
            {
                log.Error("获取订单信息发送异常", ex);
            }
            finally
            {
                cmd.Dispose();
                dbHelper.CloseConnection(conn);
            }
        }
    }
}
