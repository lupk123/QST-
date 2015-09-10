using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowTest
{
    /// <summary>
    /// 实体类--银行卡信息
    /// </summary>
    public class CardInfo
    {
        private string cardid;

        public string Cardid
        {
            get { return cardid; }
            set { cardid = value; }
        }
        private string bankName;

        public string BankName
        {
            get { return bankName; }
            set { bankName = value; }
        }
        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        private string addDate;

        public string AddDate
        {
            get { return addDate; }
            set { addDate = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private int userId;

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
    }
}
