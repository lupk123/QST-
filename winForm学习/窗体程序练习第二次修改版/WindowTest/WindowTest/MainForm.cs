using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// enter键在文本框中等于tab键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if ((ActiveControl is TextBox || ActiveControl is ComboBox) && keyData == Keys.Enter)
                keyData = Keys.Tab;
            return base.ProcessDialogKey(keyData);
        }

        /// <summary>
        /// 系统主界面登录后显示的内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            currentUser.Text = "当前用户："+ThirdData.user.LoginName;
            cardid.Focus();
            bankName.Enabled = false;
            addMoney.Enabled = false;
            outMoney.Enabled = false;
            tradeMoney.Enabled = false;
            about.Enabled = false;
            balance.Enabled = false;
            okMain.Enabled = false;
            ModifyCard.Enabled = false;
            tradeManage.Enabled = false;
            ThirdData.mark = 0; //登陆后处在添加卡和查找卡界面
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void exitMain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 搜索银行卡功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_card_Click(object sender, EventArgs e)
        {
            if (okMain.Enabled == false)
                searchCard();
            else
            {
                ThirdData.mark = 3;
                cardid.Enabled = true;
                cardid.Text = "";
                password_card.Enabled = true;
                password_card.Text = "";
                bankName.Enabled = false;
                bankName.Text = "";
                addMoney.Enabled = false;
                addMoney.Checked = false;
                outMoney.Enabled = false;
                outMoney.Checked = false;
                tradeMoney.Enabled = false;
                about.Enabled = false;
                balance.Enabled = false;
                balance.Text = "";
                okMain.Enabled = true;
                okMain.Text = "确定";
                ModifyCard.Enabled = false;
                tradeManage.Enabled = false;
            }
            //string id = cardid.Text;
            //string pwd = password_card.Text;
            //if (id == "" || pwd == "")
            //{
            //    MessageBox.Show("银行卡号或密码不能为空");
            //    if (id == "")
            //        cardid.Focus();
            //    else if (pwd == "")
            //        password_card.Focus();
            //}
            //else
            //{
            //    CardOpera cardOpera = new CardOpera();
            //    CardInfo cardInfo = new CardInfo();
            //    cardInfo.Cardid = id;
            //    cardInfo.Password = pwd;
            //    cardInfo.UserId = ThirdData.user.Id;
            //    cardInfo = cardOpera.ViewCard(cardInfo);
            //    if (cardInfo == null)
            //    {
            //        MessageBox.Show("银行卡或者密码不正确!!!");
            //        cardid.Text = "";
            //        password_card.Text = "";
            //        cardid.Focus();
            //    }
            //    else
            //    {
            //        ShowCard(cardInfo);
            //    }
            //    okMain.Text = "交易";
            //    ThirdData.mark = 2;
            //}
        }
        /// <summary>
        /// 查找卡的功能
        /// </summary>
        private void searchCard()
        {
            string id = cardid.Text;
            string pwd = password_card.Text;
            if (id == "" || pwd == "")
            {
                MessageBox.Show("银行卡号或密码不能为空");
                if (id == "")
                    cardid.Focus();
                else if (pwd == "")
                    password_card.Focus();
            }
            else
            {
                CardOpera cardOpera = new CardOpera();
                CardInfo cardInfo = new CardInfo();
                cardInfo.Cardid = id;
                cardInfo.Password = pwd;
                cardInfo.UserId = ThirdData.user.Id;
                cardInfo = cardOpera.ViewCard(cardInfo);
                if (cardInfo == null)
                {
                    MessageBox.Show("银行卡或者密码不正确!!!");
                    cardid.Text = "";
                    password_card.Text = "";
                    cardid.Focus();
                }
                else
                {
                    ShowCard(cardInfo);
                }
                okMain.Text = "交易";
                ThirdData.mark = 2;
            }
        }
        /// <summary>
        /// 存款 取款功能
        /// </summary>
        private void Change()
        {
            int temp = 0; //用来判断是否更新余额
            CardInfo cardInfo = ThirdData.cardInfo;
            TradeService tradeService = new TradeService();

            if(tradeMoney.Text == "")
            {
                MessageBox.Show("请输入交易金额");
                tradeMoney.Focus();
            }
            double money = Convert.ToDouble(tradeMoney.Text);
   
            if (addMoney.Checked == true && outMoney.Checked == false)
            {
                //存钱
                if (money <= 0)
                {
                    MessageBox.Show("存款金额不正确...");
                    about.Focus();
                }
                else
                {
                    //card表更新余额
                    cardInfo.Balance = money;
                    string str = about.Text;
                    int num = tradeService.depositMoney(cardInfo, str);
                    if (num == 0)
                        MessageBox.Show("存款失败..");
                    else if (num == 2)
                        MessageBox.Show("添加交易记录失败...");
                    else
                    {
                        MessageBox.Show("存款成功...");
                        ThirdData.cardInfo = cardInfo;
                        temp = 1;
                    }
                }
            }
            else if (addMoney.Checked == false && outMoney.Checked == true)
            {
                //取钱
                if (money > ThirdData.cardInfo.Balance)
                {
                    MessageBox.Show("金额不足...");
                    tradeMoney.Text = "";
                    tradeMoney.Focus();
                }
                else
                {
                    //card表更新余额
                    cardInfo.Balance = money;
                    string str = about.Text;
                    int num = tradeService.outMoney(cardInfo, str);
                    if (num == 0)
                        MessageBox.Show("取款失败..");
                    else if (num == 2)
                        MessageBox.Show("添加交易记录失败...");
                    else
                    {
                        MessageBox.Show("取款成功...");
                        ThirdData.cardInfo = cardInfo;
                        temp = 1;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择交易类型");
            }
            if (temp == 1)
            {
                cardInfo = tradeService.ViewBalance(cardInfo);
                if (cardInfo == null)
                    MessageBox.Show("更新余额失败...");
                else
                {
                    ShowCard(ThirdData.cardInfo); //将更新后的余额显示出来
                    addMoney.Checked = true;
                    tradeMoney.Text = "";
                    about.Text = "";
                    tradeMoney.Focus();
                }
            }
        }
        /// <summary>
        /// 修改卡功能
        /// </summary>
        private void modify_card()
        {
            if (password_card.Text == "" && bankName.Text == "")
            {
                MessageBox.Show("密码和银行名称不能同时为空..");
                password_card.Focus();
            }
            else
            {
                CardInfo cardInfo = ThirdData.cardInfo;
                CardOpera cardOpera = new CardOpera();
                if (password_card.Text != "" && bankName.Text == "")
                    cardInfo.Password = password_card.Text;
                else if (password_card.Text == "" && bankName.Text != "")
                    cardInfo.BankName = bankName.Text;
                else
                {
                    cardInfo.BankName = bankName.Text;
                    cardInfo.Password = password_card.Text;
                }
                int num = cardOpera.ModifyCard(cardInfo);
                if (num == 1)
                {
                    MessageBox.Show("修改成功");
                    ThirdData.cardInfo = cardInfo;
                    ShowCard(ThirdData.cardInfo);
                    okMain.Text = "交易";

                }
                else
                    MessageBox.Show("修改失败");
                ThirdData.mark = 2;
            }
        }
        /// <summary>
        /// 添加卡功能
        /// </summary>
        private void add_card()
        {
            ThirdData.mark = 2;
            if (cardid.Text == "" || password_card.Text == "" || bankName.Text == "")
            {
                MessageBox.Show("银行卡，密码，银行名称不能为空!!!");
                cardid.Focus();
            }
            else
            {
                CardOpera cardOpera = new CardOpera();
                CardInfo cardInfo = ThirdData.cardInfo;
                cardInfo.UserId = ThirdData.user.Id;
                cardInfo.Cardid = cardid.Text;
                cardInfo.Password = password_card.Text;
                cardInfo.BankName = bankName.Text;
                cardInfo.Balance = 0;
                ThirdData.cardInfo = cardInfo;
                int num = cardOpera.addCard(cardInfo);
                if (num == 1)
                {
                    MessageBox.Show("添加成功");
                    ShowCard(ThirdData.cardInfo);
                    okMain.Text = "交易";
                    ThirdData.cardInfo = cardInfo;
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
        }
        /// <summary>
        /// 确认按钮功能 提交数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okMain_Click(object sender, EventArgs e)
        {
            if (ThirdData.mark == 2)
                Change();
            else if (ThirdData.mark == 1)
                modify_card();
            else if (ThirdData.mark == 0)
                add_card();
            else if (ThirdData.mark == 3)
                searchCard();
        }
        /// <summary>
        /// 交易界面展示
        /// </summary>
        /// <param name="cardInfo"></param>
        private void ShowCard(CardInfo cardInfo)
        {
            ThirdData.cardInfo = cardInfo;
            cardid.Text = ThirdData.cardInfo.Cardid;
            password_card.Text = ThirdData.cardInfo.Password;
            bankName.Text = ThirdData.cardInfo.BankName;
            balance.Text = ThirdData.cardInfo.Balance.ToString();
            cardid.Enabled = false;
            password_card.Enabled = false;
            bankName.Enabled = false;
            addMoney.Enabled = true;
            outMoney.Enabled = true;
            tradeMoney.Enabled = true;
            addMoney.Checked = true;
            about.Enabled = true;
            balance.Enabled = false;
            okMain.Enabled = true;
            ModifyCard.Enabled = true;
            tradeManage.Enabled = true;
            addCard.Enabled = true;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 点击添加卡按钮后的界面状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCard_Click(object sender, EventArgs e)
        {
            ThirdData.mark = 0;
            cardid.Focus();
            okMain.Text = "确定";
            about.Enabled = false;
            password_card.Enabled = true;
            bankName.Enabled = true;
            cardid.Text = "";
            cardid.Enabled = true;
            password_card.Text = "";
            bankName.Text = "";
            addMoney.Checked = false;
            addMoney.Enabled = false;
            outMoney.Checked = false;
            outMoney.Enabled = false;
            tradeMoney.Text = "";
            tradeMoney.Enabled = false;
            balance.Enabled = false;
            balance.Text = "";
            okMain.Enabled = true;
            ModifyCard.Enabled = false;
            tradeManage.Enabled = false;            
        }
        /// <summary>
        /// 点击修改卡按钮后的界面状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyCard_Click(object sender, EventArgs e)
        {
            ThirdData.mark = 1;
            password_card.Focus();
            okMain.Text = "确定";                
            password_card.Text = "";
            bankName.Text = "";
            cardid.Enabled = false;
            about.Enabled = false;
            password_card.Enabled = true;
            bankName.Enabled = true;
            addMoney.Checked = false;
            addMoney.Enabled = false;
            outMoney.Checked = false;
            outMoney.Enabled = false;
            tradeMoney.Text = "";
            tradeMoney.Enabled = false;
            balance.Enabled = false;
            addCard.Enabled = false;
            okMain.Enabled = true;
            ModifyCard.Enabled = true;
            tradeManage.Enabled = false;
        }

        private void tradeManage_Click(object sender, EventArgs e)
        {
            headText tradeForm = new headText();
            tradeForm.Show();
        }
    }
}
