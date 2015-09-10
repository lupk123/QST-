using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowTest
{
    /// <summary>
    /// 保存登录用户信息
    /// </summary>
    class ThirdData
    {
        public static User user = new User();
        public static CardInfo cardInfo = new CardInfo();
        public static int mark; //记录系统当前所出的界面状态
        public static int tradeType; //记录显示的交易记录类型
    }
}
