using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    internal class Insurance_policy
    {
        private string number = "52-228-84-41";
        private Persone _owner = new Persone("Vujko Vlad", "12345677889");
        private string type = "Medical";
        private string Date_from = "21-11-2015";
        private string Expiration_date = "18-11-2017";

        internal string Owner()
        {
            return _owner.Name_SName + " " + _owner.PC;
        }

        internal string Type()
        {
            return type;
        }

        internal string Number()
        {
            return number;
        }

        internal string From()
        {
            return Date_from;
        }

        internal string Expirates()
        {
            return Expiration_date;
        }
    }
}
