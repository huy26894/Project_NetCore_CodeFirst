using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffes.Model
{
    public class Area
    {
        public int AreaID { get; set; }
        public string Name { get; set; }
        public List<TableCoffees> TableCoffees { get; set; }
    }
}
