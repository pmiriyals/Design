using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    class Payment
    {
        protected string cardID;
        protected string CardHolderName;
        protected Address BillingAddress;
        protected string cvv;
        protected string expDate;
        protected Enums.CardType TypeOfCard;
        protected Enums.CreditCardType TypeOfCreditCard;
        
        public void GetPaymentDetails()
        { 
            //fill out above properties
        }

        public PaymentResponse ProcessPayment()
        {
            PaymentResponse pr = new PaymentResponse();
            //Call payment gateway
            return pr;
        }
    }
}
