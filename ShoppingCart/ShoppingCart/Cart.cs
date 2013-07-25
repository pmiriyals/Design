using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    class Cart
    {
        public Dictionary<string, Product> CartItems = new Dictionary<string, Product>();   //string is the sku number of a product
        public Dictionary<string, int> Quantity = new Dictionary<string,int>();
        public List<Coupons> couponApplied = new List<Coupons>(); //Mostly there will be only 1 coupon (but if customers are allowed then can apply multiple coupons)
        public decimal CartPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal ShippingCost { get; set; }
        public string Instructions { get; set; }
        public string MessageToCustomers { get; set; }
        public Enums.Shipping ShippingMethod { get; set; }
        public Payment payment { get; set; }

        public bool AddProduct(string sku, int qty)
        {
            try{
                if (!Quantity.ContainsKey(sku) && qty > 0)
                {
                    Quantity.Add(sku, qty);
                    CartItems.Add(sku, LookupProduct(sku));
                }
                else
                {
                    Quantity[sku] = Quantity[sku] + qty;
                    if (Quantity[sku] <= 0)
                    {
                        Quantity.Remove(sku);
                        CartItems.Remove(sku);
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool DecreaseProductQty(string sku, int qty)
        {
            if (qty > 0)
                return AddProduct(sku, -qty);
            else
                return false;
        }
        
        public bool RemoveProduct(string sku)
        {
            if(CartItems.ContainsKey(sku))
                return DecreaseProductQty(sku, Quantity[sku]);
            return false;
        }

        public bool ApplyCoupon { }

        public bool UpdateCart() {//Add or remove products }

        public bool UpdateShipping(Enums.Shipping ship) { }

        public bool SubmitOrder()
        {
            payment = new Payment();
            payment.GetPaymentDetails();
            PaymentResponse pr = payment.ProcessPayment();
            Email email = new Email();
            UpdateOrdersDB();            
            email.SendEmail();
            return pr.isSuccess;
        }
    }
}
