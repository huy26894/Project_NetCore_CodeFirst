using System.Collections.Generic;

namespace Coffes.Entites
{
    public class Area
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<TableCoffees> TableCoffees { get; set; }
    }
}
