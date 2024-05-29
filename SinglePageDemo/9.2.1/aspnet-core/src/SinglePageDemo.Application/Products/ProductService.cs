using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using AutoMapper.Internal.Mappers;
using SinglePageDemo.Entities;
using SinglePageDemo.Products.Dto;
using Microsoft.EntityFrameworkCore;
using Abp.Linq.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using Abp.Linq;

namespace SinglePageDemo.Products
{
    public class ProductService : SinglePageDemoAppServiceBase, IProductService
    {
        private readonly IRepository<Product> _repository;

        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<Product> Create(CreateProductInput input)
        {
            var product = ObjectMapper.Map<Product>(input);
            var res = await _repository.InsertAsync(product);
            return res;
        }

        public async Task Delete(DeleteProductInput input)
        {
            var id = input.Id;
            await _repository.DeleteAsync(id);


        }

        public async Task<ListResultDto<ProductListDto>> GetAll()
        {
            var res = await _repository.GetAllAsync();
            return new ListResultDto<ProductListDto>(
                ObjectMapper.Map<List<ProductListDto>>(res)
            ) ;
        }

        //public async Task<Product> GetByCode(GetByCodeInput input)
        //{
        //    var res = _repository.GetAll().Where(t=>t.ProductCode == input.ProductCode);
        //    return new Product(
        //        ObjectMapper.Map<Product>(res)
        //    );
        //}

        public Task<Product> Update(UpdateProductInput input)
        {
            var product = ObjectMapper.Map<Product>(input);
            var res = _repository.UpdateAsync(product);
            return res;
        }
    }
}
