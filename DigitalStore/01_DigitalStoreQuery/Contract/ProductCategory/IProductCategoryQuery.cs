using System;
using System.Collections.Generic;


namespace _01_DigitalStoreQuery.Contract.ProductCategory
{
   public interface IProductCategoryQuery
    {
        List<ProductCategoryQueryModel> GetProductCategories();
    }
}
