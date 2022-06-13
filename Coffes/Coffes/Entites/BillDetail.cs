using System;

namespace Coffes.Entites
{
    public class BillDetail
    {
        public Guid Id { get; set; } = new Guid();
        public int BillId { get; set; }
        public int ProductId { get; set; }
        public int Number { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
    }
}
