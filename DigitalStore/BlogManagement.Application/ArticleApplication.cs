﻿using _0_Framework.Application;
using BlogManagement.Application.Contracts.Article;
using BlogManagement.Domain.ArticleAgg;
using BlogManagement.Domain.ArticleCategoryAgg;
using System.Collections.Generic;

namespace BlogManagement.Application
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IFileUploader _fileUploader;
        private readonly IArticleCategoryRepository _articleCategoryRepository;

        public ArticleApplication(IArticleRepository articleRepository, IFileUploader fileUploader, IArticleCategoryRepository articleCategoryRepository)
        {
            _articleRepository = articleRepository;
            _fileUploader = fileUploader;
            _articleCategoryRepository = articleCategoryRepository;
        }

        public OperationResult Create(CreateArticle command)
        {
            var operation = new OperationResult();
            if (_articleRepository.Exists(x => x.Title == command.Title))
                return operation.Failed(ApplicationMessage.DuplicatedRecord);

            var slug = command.Slug.Slugify();
            var publishDate = command.PublishDate.ToGeorgianDateTime();
            var categorySlug = _articleCategoryRepository.GetSlugBy(command.CategoryId);
            var path = $"{categorySlug}/{slug}";
            var pictureName = _fileUploader.Upload(command.Picture, path);
            var article = new Article(command.Title, command.ShortDescription, command.Description, pictureName, command.PictureAlt, command.PictureTitle,
                publishDate, slug, command.MetaDescription, command.Keyword, command.CanonialAddress, command.CategoryId);
            _articleRepository.Create(article);
            _articleRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Edit(EditArticle command)
        {
            var operation = new OperationResult();
            var article = _articleRepository.GetWithCategory(command.Id);
            if (article == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            if (_articleRepository.Exists(x => x.Title == command.Title && x.Id != command.Id))
                return operation.Failed(ApplicationMessage.DuplicatedRecord);
            var slug = command.Slug.Slugify();
            var publishDate = command.PublishDate.ToGeorgianDateTime();
            var path = $"{article.Category.Slug}/{slug}";
            var pictureName = _fileUploader.Upload(command.Picture, path);
            article.Edit(command.Title, command.ShortDescription, command.Description, pictureName, command.PictureAlt, 
                command.PictureTitle, publishDate, slug, command.MetaDescription, command.Keyword, command.CanonialAddress, command.CategoryId);

            _articleRepository.SaveChanges();
            return operation.Succedded();
        }

        public EditArticle GetDetails(long id)
        {
            return _articleRepository.GetDetails(id);
        }

        public List<ArticleViewModel> Search(ArticleSearchModel searchModel)
        {
            return _articleRepository.Search(searchModel);
        }
    }
}
