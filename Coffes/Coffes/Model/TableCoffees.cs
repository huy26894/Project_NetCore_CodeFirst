using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffes.Model
{
    public class TableCoffees
    {
        public int ID { get; set; }
        public int AreaID { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public Area Area { get; set; }
    }
}
