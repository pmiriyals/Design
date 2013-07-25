using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    class Product
    {
        public readonly string sku;
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string DetailedDescription { get; set; }
        public string ProductReviews { get; set; }
        public int NumberOfReviewsReceived { get; set; }
        public Enums.Rating ProductRating { get; set; }
        public bool Discontinued { get; set; }   //is product out dated or still valid
        public int Units {get; set;}
        public Enums.Category category { get; set; }
        public int rank { get; set; } //for search engine;
        public decimal UnitPrice { get; set; }
        public decimal ListPrice { get; set; }
        public int CouponId { get; set; }
        public List<int> SimilarProductSKUs = new List<int>();

        public Product(string sku) : this(sku, "", 0.0m) { }
        public Product(string sku, string ProductName, decimal ListPrice) : this(sku, ProductName, 0.0m, ListPrice, "") { }
        public Product(string sku, string ProductName, decimal UnitPrice, decimal ListPrice, string Description)
        {
            this.sku = sku; //readonly field has to be assigned in the constructor
            this.ProductName = ProductName;
            this.UnitPrice = UnitPrice;
            this.ListPrice = ListPrice;
            this.Description = Description;
        }

        public void LoadProduct(Object product)
        {
            try {
                
                //save all the properties from product object to this
            }
            catch (Exception ex)
            { 
                throw new Exception("Invalid product object exception");
            }
        }


    }
}
