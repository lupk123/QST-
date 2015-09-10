using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WindowTest
{
    class CardOpera
    {
        //DBHelper db = new DBHelper();

        /// <summary>
        /// 查看银行卡号是否存在
        /// </summary>
        /// <param name="cardid">银行卡号</param>
        /// <returns>返回银行卡号是否存在</returns>
        public int checkCardid(string cardid)
        {
            string sql = "select count(*) from card where cardid = @cardid";
            SqlParameter[] value = new SqlParameter[]{
                new SqlParameter("@cardid", cardid)
            };
            int num = DBHelper.ExecuteScalar(sql, value);
            if (num == 0)
                return 0;
            return 1;
        }
        /// <summary>
        /// 查看银行卡号密码是否正确
        /// </summary>
        /// <param name="cardid"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public int CheckIdPwd(CardInfo cardInfo)
        {
            string sql = "select count(*) from card where cardid = @cardid and password = @password";
            SqlParameter[] value = new SqlParameter[]{
                new SqlParameter("@cardid", cardInfo.Cardid),
                new SqlParameter("@password", cardInfo.Password)
            };
            int num = DBHelper.ExecuteScalar(sql, value);
            if (num == 0)
                return 0;
            return 1;
        }
        /// <summary>
        /// 添加一张卡
        /// </summary>
        /// <param name="cardid"></param>
        /// <param name="pwd"></param>
        /// <param name="bankName"></param>
        /// <param name="UserId"></param>
        public int addCard(CardInfo cardInfo)
        {
            string time = string.Format("{0:yyyy-MM-dd hh:mm:ss}", DateTime.Now);
            string sql = "insert into card(cardid, bankName, balance, addDate, password, userId)values(@cardid, @bankName, 0, @addDate, @pwd, @userId)";
            SqlParameter[] value = new SqlParameter[]{
                new SqlParameter("@cardid", cardInfo.Cardid),
                new SqlParameter("@bankName", cardInfo.BankName),
                new SqlParameter("@addDate", time),
                new SqlParameter("@pwd", cardInfo.Password),
                new SqlParameter("@userId", cardInfo.UserId)
            };
            int num = DBHelper.ExecuteCommand(sql, value);
            return num;
        }
        /// <summary>
        /// 修改卡信息
        /// </summary>
        /// <param name="cardid"></param>
        /// <param name="pwd"></param>
        public int ModifyCard(CardInfo cardInfo)
        {
            string sql = null;
            SqlParameter[] value = null;            
            sql = "update card set password = @pwd,bankName=@bankName where cardid = @cardid";
            value = new SqlParameter[]{
                    new SqlParameter("@pwd", cardInfo.Password),
                    new SqlParameter("@bankName", cardInfo.BankName),
                    new SqlParameter("@cardid", cardInfo.Cardid)
                };
            int num = DBHelper.ExecuteCommand(sql, value);
            return num;
        }
        /// <summary>
        /// 查看卡信息
        /// </summary>
        /// <param name="cardid"></param>
        /// <param name="pwd"></param>
        public CardInfo ViewCard(CardInfo cardInfo)
        {            
            CardInfo returnCardInfo = null;
            string sql = "select * from card where cardid = @cardid and password = @pwd and userId = @userid";
            SqlParameter[] value = new SqlParameter[]{
                new SqlParameter("@cardid", cardInfo.Cardid),
                new SqlParameter("@pwd", cardInfo.Password),
                new SqlParameter("@userid", cardInfo.UserId)
            };
            DataTable table = DBHelper.GetDataTable(sql, value);

            if (table.Rows.Count > 0)
            {
                returnCardInfo = new CardInfo();
                DataRow dr = table.Rows[0];
                returnCardInfo.Cardid = cardInfo.Cardid;
                returnCardInfo.Password = cardInfo.Password;
                returnCardInfo.UserId = Convert.ToInt32(dr["userId"]);
                returnCardInfo.BankName = dr["bankName"].ToString();
                returnCardInfo.AddDate = dr["addDate"].ToString();
                returnCardInfo.Balance = Convert.ToDouble(dr["balance"]);
            }
            return returnCardInfo;
        }
    }
}
