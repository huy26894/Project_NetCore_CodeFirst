using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffes.Model
{
    public class Products
    {
        public int ID { get; set; }
        public int TypeID { get; set; }
        public int UnitID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
