using Core.DataAccess.Entityframework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Entityframework
{
    public class EfProductDal: EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
    }
}
