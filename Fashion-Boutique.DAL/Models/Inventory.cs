using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Boutique.DAL.Models
{
    public class Inventory : BaseEntity
    {
        public int Stock_Quantity { get; set; }
        public DateTime Last_Updated { get; set; } // تاريخ اخر تحديث

        //Navigation property
        //public int ProductId { get; set; }
    }
}
