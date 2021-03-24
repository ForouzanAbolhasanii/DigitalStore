﻿namespace ShopManagement.Application.Contracts.ProductCategories
{
    public class ProductCategoryViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string CreationDate { get; set; }
        public int ProductCount { get; set; }
    }
}
