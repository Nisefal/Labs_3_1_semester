using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    internal class Pasport
    {
        private string code = "12-221-23";
        private Persone _owner = new Persone("Vujko Vlad", "12345677889");
        private string type = "CT";

        internal string Owner()
        {
            return _owner.Name_SName + ", " + _owner.PC;
        }

        internal string Code()
        {
            return type+"-"+code;
        }
    }
}
