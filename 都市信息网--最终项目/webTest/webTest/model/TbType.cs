using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webTest.model
{
    public class TbType
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int typeSign;

        public int TypeSign
        {
            get { return typeSign; }
            set { typeSign = value; }
        }
        private string typeName;

        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }
        private string typeIntro;

        public string TypeIntro
        {
            get { return typeIntro; }
            set { typeIntro = value; }
        }
    }
}
