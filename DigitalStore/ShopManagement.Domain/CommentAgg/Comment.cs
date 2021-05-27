using _0_Framework.Domain;
using ShopManagement.Domain.ProductAgg;
using System;


namespace ShopManagement.Domain.CommentAgg
{
   public class Comment : EntityBase
    {
        public String Name { get; private set; }
        public String Email { get; private set; }
        public String Message { get; private set; }
        public bool IsConfirmed { get; private set; }
        public bool IsCanceled { get; private set; }
        public Product Product { get; private set; }
        public long ProductId { get; private set; }

        public Comment(string name, string email, string message, long productId)
        {
            Name = name;
            Email = email;
            Message = message;
            ProductId = productId;
        }

        public void Cancel()
        {
            IsCanceled = true;
        }

        public void Confirm()
        {
            IsConfirmed = true;
        }
    }
}
