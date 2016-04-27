using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.util;
using MySql.Data.MySqlClient;

namespace Branch.com.proem.exm.dao.branch
{
    public class BranchAssociatorInfoDao : MysqlDBHelper
    {
        /// <summary>
        /// 日志
        /// </summary>
        private readonly ILog log = LogManager.GetLogger(typeof(BranchAssociatorInfoDao));

        /// <summary>
        /// 添加AssociatorInfo
        /// </summary>
        /// <param name="list"></param>
        public void AddAssociatorInfo(List<AssociatorInfo> list)
        {
            string sql = "insert into zc_associator_info values (@id, @createTime, @updateTime, @AccumulatedCredit, @Address, @AdmissionDate, "
                + "@Age, @Amount, @AmountStartDate, @AmountValidityDate, @BackupAddress, @BirthDay, @CardNumber, @CardId, @Category, @Certificate, "
                + "@CertificateNumber, @ConsumeAmount, @ConsumeFrequency, @Credit, @CreditStartDate, @CreditValidityDate, @DegreeofeDucation, "
                + "@DepositAmount, @Email, @Ethnic, @Issuers, @IssuingDate, @MaritalStatus, @MobilePhone, @Name, @Note, @Password, @RegisterStore, "
                + "@RepeatPassword, @ReviseDate, @Salesman, @Sex, @State, @TelePhone, @UsedCredit, @ZipCode, @DelFlag);";
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = GetConnection();
                tran = conn.BeginTransaction();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                foreach (AssociatorInfo obj in list)
                {
                    cmd.Parameters.AddWithValue("@id" ,obj.Id);
                    cmd.Parameters.AddWithValue("@createTime" ,obj.CreateTime);
                    cmd.Parameters.AddWithValue("@updateTime" ,obj.UpdateTime);
                    cmd.Parameters.AddWithValue("@AccumulatedCredit", obj.AccumulatedCredit);
                    cmd.Parameters.AddWithValue("@Address" , obj.Address);
                    cmd.Parameters.AddWithValue("@AdmissionDate" , obj.AdmissionDate);
                    cmd.Parameters.AddWithValue("@Age" , obj.Age);
                    cmd.Parameters.AddWithValue("@Amount" , obj.Amount);
                    cmd.Parameters.AddWithValue("@AmountStartDate" , obj.AmountStartDate);
                    cmd.Parameters.AddWithValue("@AmountValidityDate" , obj.AmountValidityDate);
                    cmd.Parameters.AddWithValue("@BackupAddress" , obj.BackupAddress);
                    cmd.Parameters.AddWithValue("@BirthDay" , obj.BirthDay);
                    cmd.Parameters.AddWithValue("@CardNumber" , obj.CardNumber);
                    cmd.Parameters.AddWithValue("@CardId" , obj.CardId);
                    cmd.Parameters.AddWithValue("@Category" , obj.Category);
                    cmd.Parameters.AddWithValue("@Certificate" , obj.Certificate);
                    cmd.Parameters.AddWithValue("@CertificateNumber" , obj.CertificateNumber);
                    cmd.Parameters.AddWithValue("@ConsumeAmount" , obj.ConsumeAmount);
                    cmd.Parameters.AddWithValue("@ConsumeFrequency" , obj.ConsumeFrequency);
                    cmd.Parameters.AddWithValue("@Credit" , obj.Credit);
                    cmd.Parameters.AddWithValue("@CreditStartDate" , obj.CreditStartDate);
                    cmd.Parameters.AddWithValue("@CreditValidityDate" , obj.CreditValidityDate);
                    cmd.Parameters.AddWithValue("@DegreeofeDucation" ,obj.DegreeofeDucation);
                    cmd.Parameters.AddWithValue("@DepositAmount" ,obj.DepositAmount);
                    cmd.Parameters.AddWithValue("@Email" , obj.Email);
                    cmd.Parameters.AddWithValue("@Ethnic" , obj.Ethnic);
                    cmd.Parameters.AddWithValue("@Issuers" , obj.Issuers);
                    cmd.Parameters.AddWithValue("@IssuingDate" ,obj.IssuingDate);
                    cmd.Parameters.AddWithValue("@MaritalStatus" , obj.MaritalStatus);
                    cmd.Parameters.AddWithValue("@MobilePhone" , obj.MobilePhone);
                    cmd.Parameters.AddWithValue("@Name" , obj.Name);
                    cmd.Parameters.AddWithValue("@Note" , obj.Note);
                    cmd.Parameters.AddWithValue("@Password" , obj.Password);
                    cmd.Parameters.AddWithValue("@RegisterStore" , obj.RegisterStore);
                    cmd.Parameters.AddWithValue("@RepeatPassword" , obj.RepeatPassword);
                    cmd.Parameters.AddWithValue("@ReviseDate" , obj.ReviseDate);
                    cmd.Parameters.AddWithValue("@Salesman" , obj.Salesman);
                    cmd.Parameters.AddWithValue("@Sex" ,obj.Sex);
                    cmd.Parameters.AddWithValue("@State" , obj.State);
                    cmd.Parameters.AddWithValue("@TelePhone" ,obj.TelePhone);
                    cmd.Parameters.AddWithValue("@UsedCredit" ,obj.UsedCredit);
                    cmd.Parameters.AddWithValue("@ZipCode" , obj.ZipCode);
                    cmd.Parameters.AddWithValue("@DelFlag" , obj.DelFlag);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                log.Error("添加数据到zc_associator_info发生异常", ex);
            }
            finally
            { 
                cmd.Dispose();
                tran.Dispose();
                CloseConnection(conn);
            }
        }
    }
}
