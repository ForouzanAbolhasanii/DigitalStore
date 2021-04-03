﻿using _0_Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Domain.InventoryAgg
{
   public class Inventory : EntityBase
    {
        public long ProductId { get; private set; }

        public double UnitPrice { get; private set; }

        public bool InStock { get; private set; }

        public List<InventoryOperation> Operations { get; private set; }

        public Inventory(long productId, double unitPrice)
        {
            ProductId = productId;
            UnitPrice = unitPrice;
            InStock = false;
              
        }

        private long CalculateCurrentCount()
        {
            var plus = Operations.Where(x => x.Operation).Sum(x => x.Count);
            var minus = Operations.Where(x => !x.Operation).Sum(x => x.Count);
            return plus - minus;
        }

        public void Increase (long count , long operatorId , string description)
        {
            var currentCount = CalculateCurrentCount() + count;
            var  operation = new InventoryOperation(true, operatorId , count , currentCount , description , 0 , Id);
            Operations.Add(operation);
            InStock = currentCount > 0;
        }

        public void Reduce (long count , long operatorId , string description , long orderId)
        {
            var currentCount = CalculateCurrentCount() - count;
            var opertion = new InventoryOperation(false , operatorId , count , currentCount , description , orderId , Id);
            Operations.Add(opertion);
            InStock = currentCount > 0;
        }
    }

    public class InventoryOperation
    {
        public long Id { get; private set; }
        public bool Operation { get; private set; }
        public long OperatorId { get; private set; }
        public DateTime OperationDate { get; private set; }
        public long Count { get; private set; }
        public long CurrentCount { get; private set; }
        public string Description { get; private set; }
        public long OrderId { get; private set; }
        public long InvectorId { get; private set; }
        public Inventory  Inventory { get; private set; }

        public InventoryOperation(bool operation, long operatorId, long count, long currentCount, string description, long orderId, long invectorId)
        {
            Operation = operation;
            OperatorId = operatorId;
            Count = count;
            CurrentCount = currentCount;
            Description = description;
            OrderId = orderId;
            InvectorId = invectorId;
            OperationDate = DateTime.Now;
        }
    }
}
