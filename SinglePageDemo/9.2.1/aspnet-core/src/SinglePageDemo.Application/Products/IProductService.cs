using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SinglePageDemo.Entities;
using SinglePageDemo.Products.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePageDemo.Products
{
    public interface IProductService:IApplicationService
    {
        Task<ListResultDto<ProductListDto>> GetAll();
        //Task<Product> GetByCode(GetByCodeInput input);
        Task<Product> Create(CreateProductInput input);
        Task<Product> Update(UpdateProductInput input);
        Task Delete(DeleteProductInput input);

    }
}
