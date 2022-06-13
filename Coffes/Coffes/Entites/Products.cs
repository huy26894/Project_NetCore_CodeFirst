using System;

namespace Coffes.Entites
{
    public class Products
    {
        public Guid Id { get; set; } = new Guid();
        public int TypeId { get; set; }
        public int UnitId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
