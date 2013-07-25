using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    class Coupons
    {
        public int CouponID { get; set; }
        public string CouponName { get; set; }
        public string Description { get; set; }
        public bool DiscountByPrice { get; set; }
        public bool DiscountByPercent { get; set; }
        public bool DiscountByItem {get; set;}
        public bool DiscountByCategory {get; set;}
        public HashSet<string> hsEligible = new HashSet<string>();
        public decimal DiscountPrice { get; set; }
        public float DiscountPercent { get; set; }
        public bool isValidWithOtherCoupons { get; set; }
    }
}
