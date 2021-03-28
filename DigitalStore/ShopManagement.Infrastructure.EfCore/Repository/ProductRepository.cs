using _0_Framework.Infrastructure;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Domain.ProductAgg;
using System.Collections.Generic;
using System.Linq;


namespace ShopManagement.Infrastructure.EfCore.Repository
{
    public class ProductRepository : RepositoryBase<long, Product>, IProductRepository
    {
        private readonly ShopContext _context;

        public ProductRepository(ShopContext context) : base(context)
        {
            _context = context;
        }

        public EditProduct GetDetails(long id)
        {
            return _context.Products.Select(x => new EditProduct()
            {
                Id = x.Id,
                Name = x.Name,
                Picture = x.Picture,
                Code = x.Code,
                Description = x.Description,
                Keywords = x.Keywords,
                MetaDescription = x.MetaDescription,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                ShortDescription = x.ShortDescription,
                Slug = x.Slug,
                UnitPrice = x.UnitPrice,
                CategoryId = x.CategoryId
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<ProductViewModel> GetProducts()
        {
            return _context.Products.Select(x => new ProductViewModel()
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }

        public List<ProductViewModel> Search(ProductSearchModel searchModel)
        {
            var query = _context.Products.Select(x => new ProductViewModel()
            {
                Id = x.Id,
                Code = x.Code,
                Name = x.Name,
                Picture = x.Picture,
                UnitPrice = x.UnitPrice,
                Category = x.Category.Name,
                CategoryId = x.CategoryId,
                IsInStock = x.IsInStock,
                CreationDate = x.CreationDate.ToString()
            }) ;

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(x => x.Name.Contains(searchModel.Name));

            if (!string.IsNullOrWhiteSpace(searchModel.Code))
                query = query.Where(x => x.Code.Contains(searchModel.Code));

            if (searchModel.CategoryId != 0)
                query = query.Where(x => x.CategoryId == searchModel.CategoryId);

            return query.OrderByDescending(x => x.Id).ToList();
               
        }
    }
}
