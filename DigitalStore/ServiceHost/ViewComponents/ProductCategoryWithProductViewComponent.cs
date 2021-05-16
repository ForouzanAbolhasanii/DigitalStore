using Microsoft.AspNetCore.Mvc;
using _01_DigitalStoreQuery.Contract.ProductCategory;


namespace ServiceHost.ViewComponents
{
    public class ProductCategoryWithProductViewComponent : ViewComponent
    {
        private readonly IProductCategoryQuery _productCategory;

        public ProductCategoryWithProductViewComponent(IProductCategoryQuery productCategoryQuery)
        {
            _productCategory = productCategoryQuery;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _productCategory.GetProductCategoriesWithProducts();
            return View(categories);
        }
    }
}
