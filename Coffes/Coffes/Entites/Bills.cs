using System;

namespace Coffes.Entites
{
    public class Bills
    {
        public Guid Id { get; set; } = new Guid();
        public int TableId { get; set; }
        public DateTime DateTimeCheckIn { get; set; }
        public DateTime DateTimeCheckOut { get; set; }
        public int Status { get; set; }
        public string StrStatus { get; set; }
    }
}
