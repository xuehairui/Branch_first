namespace Branch.com.proem.exm.window.main
{
    partial class BranchLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.loginBody = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logoLabel = new System.Windows.Forms.Label();
            this.timeNowLabel = new System.Windows.Forms.Label();
            this.timePanel = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.informLabel = new System.Windows.Forms.Label();
            this.mainInfoPanel = new System.Windows.Forms.Panel();
            this.promptPanel = new System.Windows.Forms.Panel();
            this.promptLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.leaveButton = new System.Windows.Forms.Button();
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.copyRightLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.clearBotton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.loginBody.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.mainInfoPanel.SuspendLayout();
            this.promptPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(320, 260);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 40);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "登录";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginBody
            // 
            this.loginBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.loginBody.BackgroundImage = global::Branch.Properties.Resources.login_bg_0;
            this.loginBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBody.Controls.Add(this.panel3);
            this.loginBody.Controls.Add(this.panel2);
            this.loginBody.Controls.Add(this.logoPanel);
            this.loginBody.Controls.Add(this.infoPanel);
            this.loginBody.Controls.Add(this.mainInfoPanel);
            this.loginBody.Controls.Add(this.copyRightLabel);
            this.loginBody.Controls.Add(this.panel1);
            this.loginBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginBody.Location = new System.Drawing.Point(0, 0);
            this.loginBody.Name = "loginBody";
            this.loginBody.Size = new System.Drawing.Size(800, 600);
            this.loginBody.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackgroundImage = global::Branch.Properties.Resources.login_bg_4_2;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(660, 340);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 110);
            this.panel3.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackgroundImage = global::Branch.Properties.Resources.login_bg_4;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(10, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 110);
            this.panel2.TabIndex = 32;
            // 
            // logoPanel
            // 
            this.logoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoPanel.BackgroundImage = global::Branch.Properties.Resources.login_bg_2;
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPanel.Controls.Add(this.panel4);
            this.logoPanel.Controls.Add(this.logoLabel);
            this.logoPanel.Controls.Add(this.timeNowLabel);
            this.logoPanel.Controls.Add(this.timePanel);
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(800, 75);
            this.logoPanel.TabIndex = 27;
            // 
            // logoLabel
            // 
            this.logoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.logoLabel.AutoSize = true;
            this.logoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.logoLabel.Font = new System.Drawing.Font("宋体", 32F);
            this.logoLabel.Location = new System.Drawing.Point(220, 16);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(191, 43);
            this.logoLabel.TabIndex = 27;
            this.logoLabel.Text = "分店系统";
            // 
            // timeNowLabel
            // 
            this.timeNowLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeNowLabel.AutoSize = true;
            this.timeNowLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.timeNowLabel.Location = new System.Drawing.Point(597, 25);
            this.timeNowLabel.Name = "timeNowLabel";
            this.timeNowLabel.Size = new System.Drawing.Size(65, 12);
            this.timeNowLabel.TabIndex = 26;
            this.timeNowLabel.Text = "当前时间：";
            // 
            // timePanel
            // 
            this.timePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.timePanel.Location = new System.Drawing.Point(662, 15);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(119, 32);
            this.timePanel.TabIndex = 25;
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.infoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoPanel.Controls.Add(this.informLabel);
            this.infoPanel.Location = new System.Drawing.Point(110, 180);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(353, 46);
            this.infoPanel.TabIndex = 29;
            // 
            // informLabel
            // 
            this.informLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.informLabel.AutoSize = true;
            this.informLabel.Font = new System.Drawing.Font("宋体", 20F);
            this.informLabel.Location = new System.Drawing.Point(20, 10);
            this.informLabel.Name = "informLabel";
            this.informLabel.Size = new System.Drawing.Size(228, 27);
            this.informLabel.TabIndex = 29;
            this.informLabel.Text = "从这里开始登录！";
            // 
            // mainInfoPanel
            // 
            this.mainInfoPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainInfoPanel.BackgroundImage = global::Branch.Properties.Resources.login_bg_3;
            this.mainInfoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainInfoPanel.Controls.Add(this.promptPanel);
            this.mainInfoPanel.Controls.Add(this.titlePanel);
            this.mainInfoPanel.Controls.Add(this.leaveButton);
            this.mainInfoPanel.Controls.Add(this.loginButton);
            this.mainInfoPanel.Controls.Add(this.userPasswordTextBox);
            this.mainInfoPanel.Controls.Add(this.userNameTextBox);
            this.mainInfoPanel.Controls.Add(this.userPasswordLabel);
            this.mainInfoPanel.Controls.Add(this.userNameLabel);
            this.mainInfoPanel.Location = new System.Drawing.Point(160, 100);
            this.mainInfoPanel.Name = "mainInfoPanel";
            this.mainInfoPanel.Size = new System.Drawing.Size(500, 350);
            this.mainInfoPanel.TabIndex = 0;
            // 
            // promptPanel
            // 
            this.promptPanel.BackgroundImage = global::Branch.Properties.Resources.login_error_31;
            this.promptPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.promptPanel.Controls.Add(this.promptLabel);
            this.promptPanel.Location = new System.Drawing.Point(145, 240);
            this.promptPanel.Name = "promptPanel";
            this.promptPanel.Size = new System.Drawing.Size(170, 60);
            this.promptPanel.TabIndex = 31;
            this.promptPanel.Visible = false;
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(67)))), ((int)(((byte)(65)))));
            this.promptLabel.Font = new System.Drawing.Font("宋体", 16F);
            this.promptLabel.ForeColor = System.Drawing.Color.White;
            this.promptLabel.Location = new System.Drawing.Point(53, 22);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(120, 22);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "密码错误！";
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.titlePanel.BackgroundImage = global::Branch.Properties.Resources.login_bg_1;
            this.titlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titlePanel.Location = new System.Drawing.Point(-1, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(502, 55);
            this.titlePanel.TabIndex = 30;
            // 
            // leaveButton
            // 
            this.leaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.leaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.leaveButton.FlatAppearance.BorderSize = 0;
            this.leaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaveButton.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.leaveButton.ForeColor = System.Drawing.Color.White;
            this.leaveButton.Location = new System.Drawing.Point(170, 260);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(100, 40);
            this.leaveButton.TabIndex = 5;
            this.leaveButton.Text = "取消";
            this.leaveButton.UseVisualStyleBackColor = false;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.userPasswordTextBox.Font = new System.Drawing.Font("宋体", 16F);
            this.userPasswordTextBox.Location = new System.Drawing.Point(202, 207);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.PasswordChar = '*';
            this.userPasswordTextBox.Size = new System.Drawing.Size(200, 32);
            this.userPasswordTextBox.TabIndex = 3;
            this.userPasswordTextBox.Click += new System.EventHandler(this.userPasswordTextBox_Click);
            this.userPasswordTextBox.TextChanged += new System.EventHandler(this.userPasswordTextBox_TextChanged);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.userNameTextBox.Font = new System.Drawing.Font("宋体", 16F);
            this.userNameTextBox.Location = new System.Drawing.Point(202, 163);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(200, 32);
            this.userNameTextBox.TabIndex = 2;
            this.userNameTextBox.Click += new System.EventHandler(this.userNameTextBox_Click);
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.Font = new System.Drawing.Font("宋体", 16F);
            this.userPasswordLabel.Location = new System.Drawing.Point(98, 212);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(76, 22);
            this.userPasswordLabel.TabIndex = 1;
            this.userPasswordLabel.Text = "密码：";
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("宋体", 16F);
            this.userNameLabel.Location = new System.Drawing.Point(98, 166);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(98, 22);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "用户名：";
            // 
            // copyRightLabel
            // 
            this.copyRightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.copyRightLabel.AutoSize = true;
            this.copyRightLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.copyRightLabel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.copyRightLabel.Location = new System.Drawing.Point(84, 495);
            this.copyRightLabel.Name = "copyRightLabel";
            this.copyRightLabel.Size = new System.Drawing.Size(639, 20);
            this.copyRightLabel.TabIndex = 6;
            this.copyRightLabel.Text = "版权所有©2015 南京宜鲜美配送有限公司    服务热线：400-828-82888";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.zeroButton);
            this.panel1.Controls.Add(this.clearBotton);
            this.panel1.Controls.Add(this.nineButton);
            this.panel1.Controls.Add(this.eightButton);
            this.panel1.Controls.Add(this.sevenButton);
            this.panel1.Controls.Add(this.sixButton);
            this.panel1.Controls.Add(this.fiveButton);
            this.panel1.Controls.Add(this.fourButton);
            this.panel1.Controls.Add(this.threeButton);
            this.panel1.Controls.Add(this.twoButton);
            this.panel1.Controls.Add(this.oneButton);
            this.panel1.Location = new System.Drawing.Point(500, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 248);
            this.panel1.TabIndex = 31;
            this.panel1.Visible = false;
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.backButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(9, 190);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 45);
            this.backButton.TabIndex = 23;
            this.backButton.Text = "退格";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zeroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.zeroButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zeroButton.ForeColor = System.Drawing.Color.White;
            this.zeroButton.Location = new System.Drawing.Point(109, 190);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(75, 45);
            this.zeroButton.TabIndex = 22;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // clearBotton
            // 
            this.clearBotton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearBotton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(75)))), ((int)(((byte)(71)))));
            this.clearBotton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearBotton.ForeColor = System.Drawing.Color.White;
            this.clearBotton.Location = new System.Drawing.Point(209, 190);
            this.clearBotton.Name = "clearBotton";
            this.clearBotton.Size = new System.Drawing.Size(75, 45);
            this.clearBotton.TabIndex = 21;
            this.clearBotton.Text = "清空";
            this.clearBotton.UseVisualStyleBackColor = false;
            this.clearBotton.Click += new System.EventHandler(this.clearBotton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.nineButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.nineButton.ForeColor = System.Drawing.Color.White;
            this.nineButton.Location = new System.Drawing.Point(209, 10);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(75, 45);
            this.nineButton.TabIndex = 20;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.eightButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.eightButton.ForeColor = System.Drawing.Color.White;
            this.eightButton.Location = new System.Drawing.Point(109, 10);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(75, 45);
            this.eightButton.TabIndex = 19;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sevenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.sevenButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.sevenButton.ForeColor = System.Drawing.Color.White;
            this.sevenButton.Location = new System.Drawing.Point(9, 10);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(75, 45);
            this.sevenButton.TabIndex = 18;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.sixButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.sixButton.ForeColor = System.Drawing.Color.White;
            this.sixButton.Location = new System.Drawing.Point(209, 70);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(75, 45);
            this.sixButton.TabIndex = 17;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.fiveButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.fiveButton.ForeColor = System.Drawing.Color.White;
            this.fiveButton.Location = new System.Drawing.Point(109, 70);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(75, 45);
            this.fiveButton.TabIndex = 16;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.fourButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.fourButton.ForeColor = System.Drawing.Color.White;
            this.fourButton.Location = new System.Drawing.Point(9, 70);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(75, 45);
            this.fourButton.TabIndex = 15;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.threeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.threeButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.threeButton.ForeColor = System.Drawing.Color.White;
            this.threeButton.Location = new System.Drawing.Point(209, 130);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(75, 45);
            this.threeButton.TabIndex = 14;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.twoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.twoButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.twoButton.ForeColor = System.Drawing.Color.White;
            this.twoButton.Location = new System.Drawing.Point(109, 130);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(75, 45);
            this.twoButton.TabIndex = 13;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.oneButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.oneButton.ForeColor = System.Drawing.Color.White;
            this.oneButton.Location = new System.Drawing.Point(9, 130);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(75, 45);
            this.oneButton.TabIndex = 12;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel4.BackgroundImage = global::Branch.Properties.Resources.logo;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(20, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 55);
            this.panel4.TabIndex = 28;
            // 
            // BranchLogin
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.loginBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "BranchLogin";
            this.Text = "分店系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BranchLogin_Load);
            this.Enter += new System.EventHandler(this.loginButton_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BranchLogin_KeyDown);
            this.loginBody.ResumeLayout(false);
            this.loginBody.PerformLayout();
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.mainInfoPanel.ResumeLayout(false);
            this.mainInfoPanel.PerformLayout();
            this.promptPanel.ResumeLayout(false);
            this.promptPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginBody;
        private System.Windows.Forms.Label copyRightLabel;
        private System.Windows.Forms.Label timeNowLabel;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button clearBotton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label informLabel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainInfoPanel;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox userPasswordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label userPasswordLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel promptPanel;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Panel panel4;
    }
}

