using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Boutique.DAL.Models
{
    public class OrderItem : BaseEntity
    {
        public int Quantity { get; set; }
        public int unit_price { get; set; }

        //public int OrederId { get; set; }  // foreign key
        //public int ProductId { get; set; } // foreign key

        //navigation property
        //public Order Order { get; set; }
        //public Product product { get; set; }
    }
}
