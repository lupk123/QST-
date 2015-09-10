using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webTest.model
{
    public class Search
    {
        private int infoType;

        public int InfoType
        {
            get { return infoType; }
            set { infoType = value; }
        }
        private string keys;

        public string Keys
        {
            get { return keys; }
            set { keys = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private int all;

        public int All
        {
            get { return all; }
            set { all = value; }
        }
    }
}
