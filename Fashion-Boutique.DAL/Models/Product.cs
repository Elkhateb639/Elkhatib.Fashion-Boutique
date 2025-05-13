using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Boutique.DAL.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }

        [DataType(DataType.Currency)]
        public Decimal Price { get; set; }

        //NAVIGATION PROPERTY
        //public int CategoryId { get; set; }
    }
}
