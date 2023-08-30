using System;
using System.Collections.Generic;

namespace CMPG_323_Project_2___33703795.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public short ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string? ProductDescription { get; set; }
        public int? UnitsInStock { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
