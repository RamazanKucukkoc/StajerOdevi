﻿using Entities.Concrete;
//using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        //IDataResult<List<Product>> GetAllByCategoryId(int categoryId);

        //IDataResult< List<Product>> GetByUnitPrice(decimal min,decimal max);

        //IDataResult< List<ProductDetailDto>> GetProductDetails();
        //IDataResult<Product> GetById(int productId);
        void Add(Product product);
        void Delete(Product product);
        //IResult Update(Product product);
        //IResult AddTransactionalTest(Product product);
    }
}