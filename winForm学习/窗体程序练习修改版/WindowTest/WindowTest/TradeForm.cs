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
    public partial class tradForm : Form
    {
        private double[] income = new double[3];
        public tradForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 交易记录显示--不限
        /// </summary>
        private void ShowAccount(string time1, string time2)
        {
            DataTable dt = null;
            string tradeType = null;
            TradeService tradeServie = new TradeService();
            string cardid = ThirdData.cardInfo.Cardid;
            income[0] = 0;
            income[1] = 0;
            income[2] = 0;
            if (ThirdData.tradeType == 0)
                dt = tradeServie.ViewTransaction(cardid, time1, time2);
            else if(ThirdData.tradeType == 1)
            {
                tradeType = "存款";
                dt = tradeServie.ViewTransaction(cardid, time1, time2, tradeType);
            }
            else if (ThirdData.tradeType == 2)
            {
                tradeType = "取款";
                dt = tradeServie.ViewTransaction(cardid, time1, time2, tradeType);
            }
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["tradeType"].ToString() == "存款")
                    income[0] += Convert.ToDouble(dr["number"]);
                else if(dr["tradeType"].ToString() == "取款")
                    income[1] += Convert.ToDouble(dr["number"]);
            }
            income[2] = income[0] - income[1];
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = dt;
            this.cardid.DataPropertyName = "cardid";
            this.tradeTime.DataPropertyName = "tradeTime";
            this.tradeType.DataPropertyName = "tradeType";
            this.tradeMoney.DataPropertyName = "number";
            this.about.DataPropertyName = "about";
        } 
        
        /// <summary>
        /// 交易记录显示后的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TradeForm_Load(object sender, EventArgs e)
        {
            income[0] = 0; //收入
            income[1] = 0; //支出
            income[2] = 0; //总计
            ThirdData.tradeType = 0;
            trade_type.Items.Add("不限");
            trade_type.Items.Add("存款");
            trade_type.Items.Add("取款");  
            string time1 = dateTimePicker1.Value.ToString();
            string time2 = dateTimePicker2.Value.ToString();
            ShowAccount(time1, time2);
            label_income.Text = string.Format("收入：￥{0} 支出：￥{1} 盈亏：￥{2}", income[0], income[1], income[2]);
        }

        private void checkTrade_Click(object sender, EventArgs e)
        {
            string time1 = dateTimePicker1.Value.Date.ToString();
            string time2 = dateTimePicker2.Value.ToString();
            ShowAccount(time1, time2);
            label_income.Text = string.Format("收入：￥{0} 支出：￥{1} 盈亏：￥{2}", income[0], income[1], income[2]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trade_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            //判断选择项
            switch (trade_type.SelectedItem.ToString())
            {
                case "不限": ThirdData.tradeType = 0; break;
                case "存款": ThirdData.tradeType = 1; break;
                case "取款": ThirdData.tradeType = 2; break;
            }           
        } 
        
    }
}
