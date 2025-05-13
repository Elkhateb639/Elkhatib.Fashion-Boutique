using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Boutique.DAL.Models
{
    public class Order : BaseEntity
    {

        public DateTime Order_Date { get; set; }
        public int total_amount { get; set; }

        //public int customerId { get; set; }

        //navigation property
        //public Customer customer { get; set; }
        //public ICollection<OrderItem> orderItems { get; set; }
    }
}
