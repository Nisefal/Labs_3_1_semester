using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace card;

namespace Lab2
{
    class MyFacade
    {
        static Card.Bank_card b_card = new Card.Bank_card();
        static Card.Insurance_policy i_policy = new Card.Insurance_policy();
        static Card.Pasport pasp = new Card.Pasport();

        public static string Show_Pasport_data()
        {
            return "Owner's name, personal code: " + pasp.Owner();
        }

        public static string Show_Insurence_Polycy_Data()
        {
            return "Number: " + i_policy.Number() + "\nOwner: " + i_policy.Owner() +"\nFrom: " + i_policy.From() + "\nTo: " + i_policy.Expirates() + "\nType: " + i_policy.Type();
        }

        public static string Show_Bank_Card_Data()
        {
            return "Card number: " + b_card.Number() + "\nOwner's name, personal code: " + b_card.Owner() + "\nType: " + b_card.Type() + "\nCVV2: " + b_card.CVV2();
        }
    }
}
