﻿using _0_Framework.Domain;
using ShopManagement.Application.Contracts.ProductCategories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace ShopManagement.Domain.ProductCategoryAgg
{
   public interface IProductCategoryRepository : IRepository<long , ProductCategory>
    {
      
      
        EditProductCategory GetDetails(long id);
        List<ProductCategoryViewModel> Search(ProductCategortSearchModel searchModel);
    }
}
