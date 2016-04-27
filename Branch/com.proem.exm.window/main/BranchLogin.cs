using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Branch.com.proem.exm.util;
using log4net;
using System.Threading;
using Branch.com.proem.exm.service.main;
using MySql.Data.MySqlClient;
using Branch.com.proem.exm.window.util;
using Branch.com.proem.exm.service.master;
using Branch.com.proem.exm.domain;

[assembly:log4net.Config.XmlConfigurator(Watch = true)]
namespace Branch.com.proem.exm.window.main
{
    /// <summary>
    /// 登录页面
    /// </summary>
    public partial class BranchLogin : Form
    {
        /// <summary>
        /// 日志
        /// </summary>
        private ILog log = LogManager.GetLogger(typeof(BranchLogin));

        public BranchLogin()
        {
            InitializeComponent();
        }

        private bool textbox_focus = true;

        string code = "";
        bool code_flag = false;

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = this.userNameTextBox.Text;
            string pass = this.userPasswordTextBox.Text;
            if (username.Equals("") || pass.Equals(""))
            {
                promptPanel.Show();
                //MessageBox.Show("用户名或者密码不能为空!");
                return;
            }
            string queryString = "";
            //调用Md5 获取加密后的密码
            string password = MD5Util.GetMd5(pass);

            //判断当前分店系统是否已获取自编码
            DownloadIdentifyService identifyService = new DownloadIdentifyService();
            code = identifyService.getIdCode();
            if (string.IsNullOrEmpty(code))
            {
                System.Guid guid = new Guid();
                guid = Guid.NewGuid();
                code = guid.ToString();

                //SetCode setCode = new SetCode(code);
                //setCode.ShowDialog();

                //将系统编码存入本地
                identifyService.setIdCode(code);
                code_flag = true;

            }


            ///业务逻辑判断   
            /// 1判断是否是初始化第一次登陆   
            if (identifyService.IsFirst())
            {
                ///需要连接远程Oracle服务器进行用户的验证
                ///2 判断网络是否连通
                if (PingTask.IsConnected)
                {
                    ///3  用户账号密码验证  
                        queryString = "select password,id,name from ctp_user where name ='" + username + "'";
                        //获取数据库连接
                        OracleConnection connection = OracleUtil.OpenConn();
                        OracleCommand command = new OracleCommand(queryString);
                        command.Connection = connection;
                        try
                        {
                            var reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                string confirmPassword = string.Format("{0}", reader["password"]);
                                if (password.Equals(confirmPassword))
                                {
                                    LoginUserInfo.id = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                                    LoginUserInfo.name = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                                    loadLoginUserInfo();

                                    identifyService.setBranchTotalId();
                                    //上传分店系统编码
                                    if (code_flag && !code.Equals(""))
                                    {
                                        //获取当前分店信息
                                        ZcBranchTotalService branchTotal = new ZcBranchTotalService();
                                        ZcBranchTotal zcBranchTotal = branchTotal.FindOfAll(LoginUserInfo.branchCode);
                                        //将系统编码上传与分店绑定
                                        SetCodeToBranchService setCodeToBranchService = new SetCodeToBranchService();
                                        setCodeToBranchService.setIdCodeToBranch(code, zcBranchTotal, LoginUserInfo.branchId);
                                    }
                                    //MessageBox.Show(code_flag + ":" + code + ":" + LoginUserInfo.branchName + ":" + LoginUserInfo.branchId);

                                    //用户名，密码验证成功
                                    this.DialogResult = DialogResult.OK;
                                }
                                else
                                {
                                    promptPanel.Show();
                                    //MessageBox.Show("用户名或者密码输入错误,请重新输入!");
                                }
                            }
                            else
                            {
                                promptPanel.Show();
                                //MessageBox.Show("用户名或者密码输入错误,请重新输入!");
                            }
                        }
                        catch (Exception ex)
                        {
                            log.Error("获取当前登录用户信息失败", ex);
                        }
                        finally
                        {
                            OracleUtil.CloseConn(connection);
                        }
                }
                else
                {
                    MessageBox.Show("首次登录系统会进行初始化的数据下载，请检查网络状态，重新登陆!");
                    return;
                }
            }
            else
            {
                ///表示已经初始化过系统，系统里面有用户表可以进行登陆判断
                ///判断是否需要下载数据    并且网络是否连通
                if (identifyService.NeedDownload() && (! PingTask.IsConnected))
                {
                    ///表示需要下载数据，并且网络未连通
                    ///今日首次登陆 
                    MessageBox.Show("每日首次登录系统会进行订单等数据的下载，请检查网络状态，重新登陆!");
                    return;
                }
                else
                {
                    queryString = "select a.name,a.id,a.password from ctp_user a left join zc_user_info b on a.id = b.user_id "
                        +" left join download_identify c on  b.branch_name_id = c.branch_id "
                        +" where c.id = '1' and a.name = '"+username+"'";
                    /// 1 需要下载数据，网络通  2不需要下载数据， 网络通  3不需要下载数据，网络不通
                    MysqlDBHelper dbHelper = new MysqlDBHelper();
                    MySqlConnection conn = null;
                    MySqlCommand cmd = new MySqlCommand();
                    try
                    {
                        conn = dbHelper.GetConnection();
                        cmd.CommandText = queryString;
                        cmd.Connection = conn;
                        var reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string confirmPassword = string.Format("{0}", reader["password"]);
                            if (password.Equals(confirmPassword))
                            {
                                LoginUserInfo.id = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                                LoginUserInfo.name = username;
                                MysqlloadLoginUserInfo();
                                //用户名，密码验证成功
                                this.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                promptPanel.Show();
                                //MessageBox.Show("用户名或者密码输入错误,请重新输入!");
                            }
                        }
                        else
                        {
                            promptPanel.Show();
                            //MessageBox.Show("用户名或者密码输入错误,请重新输入!");
                        }
                    }
                    catch (Exception ex)
                    {
                        log.Error("查询当前登录账号信息失败", ex);
                    }
                }
            }
            
        }

        /// <summary>
        /// 加载登录用户的分店信息  
        /// 现在先通过oracle 获取这些信息   之后会换成本地数据库
        /// </summary>
        private void loadLoginUserInfo()
        {
            OracleConnection conn = null;
            try
            {
                conn = OracleUtil.OpenConn();
                string sql = "select a.id, a.branch_code,a.branch_name,d.street " 
                    + "from zc_branch_total a "
                    + " left join zc_user_info b on a.id = b.BRANCH_NAME_ID "
                    +" left join ctp_user c on c.id=b.user_id left join zc_zoning d on d.id=a.zoning_id where c.id='"+LoginUserInfo.id+"'";
                OracleCommand cmd = new OracleCommand(sql, conn);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    LoginUserInfo.branchId = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    LoginUserInfo.branchCode = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    LoginUserInfo.branchName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                    LoginUserInfo.street = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                OracleUtil.CloseConn(conn);
            }
        }

        /// <summary>
        /// 加载登录用户的分店信息  
        /// mysql加载本地数据库
        /// </summary>
        private void MysqlloadLoginUserInfo()
        {
            MysqlDBHelper dbHelper = new MysqlDBHelper();
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                conn = dbHelper.GetConnection();
                string sql = "select a.id, a.branch_code,a.branch_name,d.street " 
                    + "from zc_branch_total a "
                    + " left join zc_user_info b on a.id = b.BRANCH_NAME_ID "
                    +" left join ctp_user c on c.id=b.user_id left join zc_zoning d on d.id=a.zoning_id where c.id='"+LoginUserInfo.id+"'";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    LoginUserInfo.branchId = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                    LoginUserInfo.branchCode = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    LoginUserInfo.branchName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                    LoginUserInfo.street = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                }

            }
            catch (Exception ex)
            {
                log.Error("从本地数据库加载登陆用户信息失败", ex);
            }
            finally
            {
                cmd.Dispose();
                dbHelper.CloseConnection(conn);
            }
        }
        

        private void leaveButton_Click(object sender, EventArgs e)
        {
            //this.Close();
            System.Environment.Exit(0);
        }

        private void userPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            promptPanel.Hide();
        }

        private void userNameTextBox_Click(object sender, EventArgs e)
        {
            textbox_focus = true;
        }

        private void userPasswordTextBox_Click(object sender, EventArgs e)
        {
            textbox_focus = false;
        }

        private void BranchLogin_Load(object sender, EventArgs e)
        {
            Times times = new Times();
            times.TopLevel = false;
            this.timePanel.Controls.Add(times);
            times.Show();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                userNameTextBox.Text += "1";
            }
            else
            {
                userPasswordTextBox.Text += "1";
            }
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                userNameTextBox.Text += "2";
            }
            else
            {
                userPasswordTextBox.Text += "2";
            }
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                userNameTextBox.Text += "3";
            }
            else
            {
                userPasswordTextBox.Text += "3";
            }
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                userNameTextBox.Text += "4";
            }
            else
            {
                userPasswordTextBox.Text += "4";
            }
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                userNameTextBox.Text += "5";
            }
            else
            {
                userPasswordTextBox.Text += "5";
            }
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                userNameTextBox.Text += "6";
            }
            else
            {
                userPasswordTextBox.Text += "6";
            }
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                userNameTextBox.Text += "7";
            }
            else
            {
                userPasswordTextBox.Text += "7";
            }
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                userNameTextBox.Text += "8";
            }
            else
            {
                userPasswordTextBox.Text += "8";
            }
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                userNameTextBox.Text += "9";
            }
            else
            {
                userPasswordTextBox.Text += "9";
            }
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                userNameTextBox.Text += "0";
            }
            else
            {
                userPasswordTextBox.Text += "0";
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (textbox_focus == true)
            {
                if (userNameTextBox.Text.Length > 0)
                {
                    userNameTextBox.Text = userNameTextBox.Text.Remove(userNameTextBox.Text.Length - 1, 1);
                }
            }
            else
            {
                if (userPasswordTextBox.Text.Length > 0)
                {
                    userPasswordTextBox.Text = userPasswordTextBox.Text.Remove(userPasswordTextBox.Text.Length - 1, 1);
                }
            }
        }
        
        private void clearBotton_Click(object sender, EventArgs e)
        {
            this.userNameTextBox.Clear();
            this.userPasswordTextBox.Clear();
            this.userNameTextBox.Focus();
            textbox_focus = true;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Tab)
            {
                if (textbox_focus)
                {
                    textbox_focus = false;
                }
                else
                {
                    textbox_focus = true;
                }
                //MessageBox.Show("textbox_focus");
            }
            return base.ProcessDialogKey(keyData);
        }

        private void BranchLogin_KeyDown(object sender, KeyEventArgs e)
        {

            //if (e.KeyCode == Keys.D1)
            //{
            //    oneButton_Click(this, EventArgs.Empty);
            //}
            //if (e.KeyCode == Keys.D2)
            //{
            //    twoButton_Click(this, EventArgs.Empty);
            //}
            //if (e.KeyCode == Keys.D3)
            //{
            //    threeButton_Click(this, EventArgs.Empty);
            //}
            //if (e.KeyCode == Keys.D4)
            //{
            //    fourButton_Click(this, EventArgs.Empty);
            //}
            //if (e.KeyCode == Keys.D5)
            //{
            //    fiveButton_Click(this, EventArgs.Empty);
            //}
            //if (e.KeyCode == Keys.D6)
            //{
            //    sixButton_Click(this, EventArgs.Empty);
            //}
            //if (e.KeyCode == Keys.D7)
            //{
            //    sevenButton_Click(this, EventArgs.Empty);
            //}
            //if (e.KeyCode == Keys.D8)
            //{
            //    eightButton_Click(this, EventArgs.Empty);
            //}
            //if (e.KeyCode == Keys.D9)
            //{
            //    nineButton_Click(this, EventArgs.Empty);
            //}
            //if (e.KeyCode == Keys.D0)
            //{
            //    zeroButton_Click(this, EventArgs.Empty);
            //}
            //if (e.KeyCode == Keys.Back)
            //{
            //    backButton_Click(this, EventArgs.Empty);
            //}

            //if ((e.KeyValue >= 'A' && e.KeyValue <= 'Z') || (e.KeyValue >= 'a' && e.KeyValue <= 'z'))
            //{
            //    userNameTextBox.Text += e.KeyCode.ToString();
            //}

            //MessageBox.Show(e.KeyCode.ToString());
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.Escape)
            {
                leaveButton_Click(this, EventArgs.Empty);
            }
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            promptPanel.Hide();
        }

    }
}
