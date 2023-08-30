using System;
using System.Collections.Generic;

namespace CMPG_323_Project_2___33703795.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public short OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public short CustomerId { get; set; }
        public string? DeliveryAddress { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
