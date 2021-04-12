﻿using System;

namespace InventoryManagement.Domain.InventoryAgg
{
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
        public long InventorId { get; private set; }
        public Inventory  Inventory { get; private set; }

        protected InventoryOperation()
        {

        }
        public InventoryOperation(bool operation, long operatorId, long count, long currentCount, string description, long orderId, long inventorId)
        {
            Operation = operation;
            OperatorId = operatorId;
            Count = count;
            CurrentCount = currentCount;
            Description = description;
            OrderId = orderId;
            InventorId = inventorId;
            OperationDate = DateTime.Now;
        }
    }
}