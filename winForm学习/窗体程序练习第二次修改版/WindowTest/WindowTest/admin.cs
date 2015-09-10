using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowTest
{
    public partial class admin : Form
    {
        private int time;
        public admin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// enter键等于tab键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if ((ActiveControl is TextBox || ActiveControl is ComboBox) && keyData == Keys.Enter)
                keyData = Keys.Tab; 
            return base.ProcessDialogKey(keyData);
        }
          
        private void admin_Load(object sender, EventArgs e)
        {
            time = 15;
            timeText.Text = time + "秒后自动登录";
            username.Focus();
        }
        private void butOK_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            string name = username.Text;
            string pwd = password.Text;
            if (name == "" || pwd == "")
            {
                MessageBox.Show("用户名或密码不能为空...");
            }
            else
            {
                userService userSer = new userService();
                User user = new User();
                user.LoginName = name;
                user.Password = pwd;
                user = userSer.checkLogin(user);
                if (user == null)
                {
                    MessageBox.Show("登录失败, 可能错误的消息是" + DBHelper.Message);
                    username.Text = "";
                    password.Text = "";
                    username.Focus();
                }
                else
                {
                    ThirdData.user = user;
                    MainForm main = new MainForm();
                    main.Show();
                    this.Hide();
                    timer1.Enabled = false;
                }
            }
        }
        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time <= 0)
                time = 16;
            time--;      
            timeText.Text = time+"秒后自动登录" ;
            if (time == 0)
            {
                timer1.Enabled = false;
                login();
                timer1.Enabled = true;
            }
        }        
    }
}
