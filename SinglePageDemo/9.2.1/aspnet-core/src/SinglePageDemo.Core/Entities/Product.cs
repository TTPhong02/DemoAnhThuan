using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePageDemo.Entities
{
    [Table("Product")]
    public class Product:Entity<int>
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public int ProductSold { get; set; }

        public Product(Product product)
        {
            ProductCode = product.ProductCode;
            ProductName = product.ProductName;
            ProductDescription = product.ProductDescription;
            ProductPrice = product.ProductPrice;
            ProductStock = product.ProductStock;
            ProductSold = product.ProductSold;
        }
        public Product(string productCode, string productName, string productDescription, decimal productPrice, int productStock, int productSold)
        {
            ProductCode = productCode;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductPrice = productPrice;
            ProductStock = productStock;
            ProductSold = productSold;
        }
        public Product(string productCode, string productName, string productDescription, decimal productPrice, int productStock)
        {
            ProductCode = productCode;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductPrice = productPrice;
            ProductStock = productStock;
            ProductSold = 0;
        }
    }
}
