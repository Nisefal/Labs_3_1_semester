using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    internal class Bank_card
    {
        private string card_number = "4991982337456230";
        private Persone _owner = new Persone("Vujko Vlad", "12345677889");
        private string type = "For salary";
        private string cvv2 = "345";

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
            return card_number;
        }

        internal string CVV2()
        {
            return cvv2;
        }
    }
}
