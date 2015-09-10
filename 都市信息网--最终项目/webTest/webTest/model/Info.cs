using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webTest.model
{
    public class Info
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int info_type;

        public int Info_type
        {
            get { return info_type; }
            set { info_type = value; }
        }
        private string info_title;

        public string Info_title
        {
            get { return info_title; }
            set { info_title = value; }
        }
        private string info_content;

        public string Info_content
        {
            get { return info_content; }
            set { info_content = value; }
        }
        private string info_linkman;

        public string Info_linkman
        {
            get { return info_linkman; }
            set { info_linkman = value; }
        }
        private string info_phone;

        public string Info_phone
        {
            get { return info_phone; }
            set { info_phone = value; }
        }
        private string info_email;

        public string Info_email
        {
            get { return info_email; }
            set { info_email = value; }
        }
        private string info_date;

        public string Info_date
        {
            get { return info_date; }
            set { info_date = value; }
        }
        private string info_state;

        public string Info_state
        {
            get { return info_state; }
            set { info_state = value; }
        }
        private string info_payfor;

        public string Info_payfor
        {
            get { return info_payfor; }
            set { info_payfor = value; }
        }

        private TbType tbType = new TbType();

        public TbType TbType
        {
            get { return tbType; }
            set { tbType = value; }
        }
    }
}
