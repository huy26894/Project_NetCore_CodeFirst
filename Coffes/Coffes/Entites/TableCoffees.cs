using System;
using System.ComponentModel.DataAnnotations;

namespace Coffes.Entites
{
    public class TableCoffees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }

        public int AreaId { get; set; }
        public Area Area { get; set; }
    }
}
