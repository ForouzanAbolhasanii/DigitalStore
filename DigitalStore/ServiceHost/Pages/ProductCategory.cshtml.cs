using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_DigitalStoreQuery.Contract.ProductCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ProductCategoryModel : PageModel
    {
        public ProductCategoryQueryModel ProductCategory;
        private readonly IProductCategoryQuery _productCategory;

        public ProductCategoryModel(IProductCategoryQuery productCategory)
        {
            _productCategory = productCategory;
        }

        public void OnGet(string id)
        {
            ProductCategory = _productCategory.GetProductCategoryWithProductsBy(id);
        }
    }
}
