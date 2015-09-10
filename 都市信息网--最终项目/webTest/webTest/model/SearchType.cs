using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webTest.model
{
    public class SearchType
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string content;

        public string Content
        {
            get { return content; }
            set { content = value; }
        }
    }
}
