﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product> //Interface default olarak PUBLİC değildir!! operasyonları public tir.
    {
        List<ProductDetailDto> GetProductDetails();
    }
}