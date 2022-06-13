using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Coffes.Entites
{
    public class Area
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<TableCoffees> TableCoffees { get; set; }
    }
}
