using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Boutique.DAL.Models
{
    public class Suppliers : BaseEntity
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
