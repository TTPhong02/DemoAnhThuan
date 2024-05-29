using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using SinglePageDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePageDemo.Products.Dto
{
    [AutoMapTo(typeof(Product))]
    public class UpdateProductInput:EntityDto<int>
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public int ProductSold { get; set; }
    }
}
