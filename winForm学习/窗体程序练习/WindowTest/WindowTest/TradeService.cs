using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WindowTest
{
    public class TradeService
    {        
        CardOpera card = new CardOpera();

        /// <summary>
        /// 存款
        /// </summary>
        /// <param name="cardid">银行卡号</param>
        /// <param name="balance">存款金额</param>
        public int depositMoney(CardInfo cardInfo, string about)
        {
            string sql = "update card set balance = balance + @balance where cardid = @cardid";
            SqlParameter[] value = new SqlParameter[]{
                new SqlParameter("@balance", cardInfo.Balance),
                new SqlParameter("@cardid", ThirdData.cardInfo.Cardid)
            };
            int returnNum = 0;
            int num = DBHelper.ExecuteCommand(sql, value);
            if (num == 1)
            {
                string tradeType = "存款";
                int typeId = 0;
                int temp = addTradeInfo(cardInfo.Cardid, cardInfo.Balance, tradeType, about, typeId);
                if (temp == 1)
                    returnNum = 1;
                else if (temp == 0)
                    returnNum = 2;
            }
            return returnNum;
        }
        /// <summary>
        /// 添加交易记录
        /// </summary>
        /// <param name="cardid">银行卡号</param>
        /// <param name="balance">交易金额</param>
        private int addTradeInfo(string cardid, double balance, string tradeType, string about, int typeId)
        {            
            string time = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            string sql = null;
            SqlParameter[] value = null;

            sql = "insert into trade(cardid, tradeTime, tradeType, number, about, typeId)values(@cardid, @tradeTime, @tradeType, @number, @about, @typeId)";
            value = new SqlParameter[]{
            new SqlParameter("@cardid", cardid),
            new SqlParameter("@tradeTime", time),
            new SqlParameter("@tradeType", tradeType),
            new SqlParameter("@number", balance),
            new SqlParameter("@about", about),
            new SqlParameter("@typeId", typeId)
            };

            int num = DBHelper.ExecuteCommand(sql, value);
            return num;
        }
        /// <summary>
        /// 查看交易记录 
        /// </summary>
        /// <param name="cardid"></param>
        public DataTable ViewTransaction(string cardid, string time1, string time2)
        {
            string sql = "select * from trade where cardid = @cardid and (tradeTime >= @time1 and tradeTime <= @time2)";
            SqlParameter[] value = new SqlParameter[]{
                new SqlParameter("@cardid", cardid),
                new SqlParameter("@time1", time1),
                new SqlParameter("@time2", time2)
            };
            DataTable table = DBHelper.GetDataTable(sql, value);

            return table;
        }
        /// <summary>
        /// 查看交易记录 
        /// </summary>
        /// <param name="cardid"></param>
        public DataTable ViewTransaction(string cardid, string time1, string time2, string tradeType)
        {
            string sql = "select * from trade where cardid = @cardid and tradeType = @tradeType and (tradeTime >= @time1 and tradeTime <= @time2)";
            SqlParameter[] value = new SqlParameter[]{
                new SqlParameter("@cardid", cardid),
                new SqlParameter("@tradeType", tradeType),
                new SqlParameter("@time1", time1),
                new SqlParameter("@time2", time2)
            };
            DataTable table = DBHelper.GetDataTable(sql, value);

            //Console.WriteLine("银行卡号\t 交易时间\t 交易类型 \t交易金额 \t备注");
            return table;
        }
        /// <summary>
        /// 查看余额
        /// </summary>
        /// <param name="cardid"></param>
        /// <param name="pwd"></param>
        public CardInfo ViewBalance(CardInfo cardInfo)
        {
            CardInfo returnCardInfo = null;      
            string sql = "select * from card where cardid = @cardid";
            SqlParameter[] value = new SqlParameter[]{
                new SqlParameter("@cardid", cardInfo.Cardid)
            };
            DataTable table = DBHelper.GetDataTable(sql, value);

            if (table.Rows.Count > 0)
            {                
                DataRow dr = table.Rows[0];
                cardInfo.Balance = Convert.ToDouble(dr["balance"]);
                returnCardInfo = cardInfo;
            }
            return returnCardInfo;
        }
        /// <summary>
        /// 取款
        /// </summary>
        /// <param name="cardid"></param>
        /// <param name="balance"></param>
        public int outMoney(CardInfo cardInfo, string about)
        {
            int returnNum = 0;
            string sql = string.Format("update card set balance = balance-@balance where cardid = @cardid");
            SqlParameter[] values = new SqlParameter[]{
                new SqlParameter("@balance", cardInfo.Balance),
                new SqlParameter("@cardid", cardInfo.Cardid)
            };
            int num = DBHelper.ExecuteCommand(sql, values);
            if (num == 1)
            {
                string tradeType = "取款";
                int typeId = 0;
                int temp = addTradeInfo(cardInfo.Cardid, cardInfo.Balance, tradeType, about, typeId);
                if (temp == 1)
                    returnNum = 1;
                else if (temp == 0)
                    returnNum = 2;
            }
            return returnNum;
        }
    }
}
