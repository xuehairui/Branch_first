using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using Oracle.ManagedDataAccess.Client;

namespace Branch.com.proem.exm.dao.master
{
    public class AssociatorInfoDao
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(AssociatorInfoDao));

        /// <summary>
        /// 获取所有会员信息
        /// </summary>
        /// <returns></returns>
        public List<AssociatorInfo> FindAll()
        {
            string sql = "select id, CREATETIME, UPDATETIME, ASSOCIATOR_ACCUMULATEDCREDIT, ASSOCIATOR_ADDRESS, ASSOCIATOR_ADMISSIONDATE, "
                + "ASSOCIATOR_AGE, ASSOCIATOR_AMOUNT, ASSOCIATOR_AMOUNTSTARTDATE, ASSOCIATOR_AMOUNTVALIDITYDATE, ASSOCIATOR_BACKUPADDRESS, "
                + " ASSOCIATOR_BIRTHDAY, ASSOCIATOR_CARDNUMBER, ASSOCIATOR_CARDID, ASSOCIATOR_CATEGORY, ASSOCIATOR_CERTIFICATE, "
                + " ASSOCIATOR_CERTIFICATENUMBER, ASSOCIATOR_CONSUMEAMOUNT, ASSOCIATOR_CONSUMEFREQUENCY, ASSOCIATOR_CREDIT, "
                + " ASSOCIATOR_CREDITSTARTDATE, ASSOCIATOR_CREDITVALIDITYDATE, ASSOCIATOR_DEGREEOFEDUCATION, ASSOCIATOR_DEPOSITAMOUNT, "
                + " ASSOCIATOR_EMAIL, ASSOCIATOR_ETHNIC, ASSOCIATOR_ISSUERS, ASSOCIATOR_ISSUINGDATE, ASSOCIATOR_MARITALSTATUS, "
                + " ASSOCIATOR_MOBILEPHONE,ASSOCIATOR_NAME, ASSOCIATOR_NOTE, ASSOCIATOR_PASSWORD, ASSOCIATOR_REGISTERSTORE, "
                + " ASSOCIATOR_REPEATPASSWORD, ASSOCIATOR_REVISEDATE, ASSOCIATOR_SALESMAN, ASSOCIATOR_SEX, ASSOCIATOR_STATE, ASSOCIATOR_TELEPHONE, "
                + " ASSOCIATOR_USEDCREDIT, ASSOCIATOR_ZIPCODE, DELFLAG from zc_associator_info";
            List<AssociatorInfo> list = new List<AssociatorInfo>();
            OracleConnection conn = null;
            OracleCommand cmd = new OracleCommand();
            try
            {
                conn = OracleUtil.OpenConn();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    AssociatorInfo obj = new AssociatorInfo();
                    obj.Id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    obj.CreateTime = reader.IsDBNull(1) ? default(DateTime) : reader.GetDateTime(1);
                    obj.UpdateTime = reader.IsDBNull(2) ? default(DateTime) : reader.GetDateTime(2);
                    obj.AccumulatedCredit = reader.IsDBNull(3) ? default(int) : reader.GetInt32(3);
                    obj.Address = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    obj.AdmissionDate = reader.IsDBNull(5) ? default(DateTime) : reader.GetDateTime(5);
                    obj.Age = reader.IsDBNull(6) ? default(int) : reader.GetInt32(6);
                    obj.Amount = reader.IsDBNull(7) ? default(float) : reader.GetFloat(7);
                    obj.AmountStartDate = reader.IsDBNull(8) ? default(DateTime) : reader.GetDateTime(8);
                    obj.AmountValidityDate = reader.IsDBNull(9) ? default(DateTime) : reader.GetDateTime(9);
                    obj.BackupAddress = reader.IsDBNull(10) ? string.Empty : reader.GetString(10);
                    obj.BirthDay = reader.IsDBNull(11) ? default(DateTime) : reader.GetDateTime(11);
                    obj.CardNumber = reader.IsDBNull(12) ? string.Empty : reader.GetString(12);
                    obj.CardId = reader.IsDBNull(13) ? string.Empty : reader.GetString(13);
                    obj.Category = reader.IsDBNull(14) ? string.Empty : reader.GetString(14);
                    obj.Certificate = reader.IsDBNull(15) ? string.Empty : reader.GetString(15);
                    obj.CertificateNumber = reader.IsDBNull(16) ? string.Empty : reader.GetString(16);
                    obj.ConsumeAmount = reader.IsDBNull(17) ? default(float) : reader.GetFloat(17);
                    obj.ConsumeFrequency = reader.IsDBNull(18) ? default(int) : reader.GetInt32(18);
                    obj.Credit = reader.IsDBNull(19) ? default(int) : reader.GetInt32(19);
                    obj.CreditStartDate = reader.IsDBNull(20) ? default(DateTime) : reader.GetDateTime(20);
                    obj.CreditValidityDate = reader.IsDBNull(21) ? default(DateTime) : reader.GetDateTime(21);
                    obj.DegreeofeDucation = reader.IsDBNull(22) ? string.Empty : reader.GetString(22);
                    obj.DepositAmount = reader.IsDBNull(23) ? default(float) : reader.GetFloat(23);
                    obj.Email = reader.IsDBNull(24) ? string.Empty : reader.GetString(24);
                    obj.Ethnic = reader.IsDBNull(25) ? string.Empty : reader.GetString(25);
                    obj.Issuers = reader.IsDBNull(26) ? string.Empty : reader.GetString(26);
                    obj.IssuingDate = reader.IsDBNull(27) ? default(DateTime) : reader.GetDateTime(27);
                    obj.MaritalStatus = reader.IsDBNull(28) ? string.Empty : reader.GetString(28);
                    obj.MobilePhone = reader.IsDBNull(29) ? string.Empty : reader.GetString(29);
                    obj.Name = reader.IsDBNull(30) ? string.Empty : reader.GetString(30);
                    obj.Note = reader.IsDBNull(31) ? string.Empty : reader.GetString(31);
                    obj.Password = reader.IsDBNull(32) ? string.Empty : reader.GetString(32);
                    obj.RegisterStore = reader.IsDBNull(33) ? string.Empty : reader.GetString(33);
                    obj.RepeatPassword = reader.IsDBNull(34) ? string.Empty : reader.GetString(34);
                    obj.ReviseDate = reader.IsDBNull(35) ? default(DateTime) : reader.GetDateTime(35);
                    obj.Salesman = reader.IsDBNull(36) ? string.Empty : reader.GetString(36);
                    obj.Sex = reader.IsDBNull(37) ? string.Empty : reader.GetString(37);
                    obj.State = reader.IsDBNull(38) ? string.Empty : reader.GetString(38);
                    obj.TelePhone = reader.IsDBNull(39) ? string.Empty : reader.GetString(39);
                    obj.UsedCredit = reader.IsDBNull(40) ? default(int) : reader.GetInt32(40);
                    obj.ZipCode = reader.IsDBNull(41) ? string.Empty : reader.GetString(41);
                    obj.DelFlag = reader.IsDBNull(42) ? string.Empty : reader.GetString(42);
                    list.Add(obj);
                }
            }
            catch (Exception ex)
            {
                log.Error("查询远程端会员表数据发送异常", ex);
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
