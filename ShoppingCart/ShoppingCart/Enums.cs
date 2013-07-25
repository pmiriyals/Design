using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    //class Rating
    //{
    //    public static int FIVE = 5;
    //    public static int FOUR = 4;
    //    public static int THREE = 3;
    //    public static int 
    //}

    class Enums
    { 
        public static enum Rating {ONE = 1, TWO = 2, THREE = 3, FOUR = 4, FIVE = 5};
        public static enum Category { Grocery = 1 };
        public static enum Shipping { Regular = 1, TwoDay = 2, OneDay = 3, Unknown = 4 };
        public static enum AddressType { Home = 1, Office = 2, Other = 3 };
        public static enum CardType { Credit = 1, Debit = 2, FSA = 3, Other = 4 };
        public static enum CreditCardType { Visa = 1, MasterCard = 2, Amex = 3, None = 4 };
    }
}
