using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    class PaymentResponse
    {
        public bool isSuccess;
        public string ErrorMsg;
        public string PaymentGatewayResponse;
        public string LastFourDigits;
    }
}
