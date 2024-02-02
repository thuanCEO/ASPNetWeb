﻿
using UOW.Core.Entities;

    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public byte[] ProductImage { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();
        public virtual Supplier Supplier { get; set; }
    }
