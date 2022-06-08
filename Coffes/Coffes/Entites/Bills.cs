using System;

namespace Coffes.Entites
{
    public class Bills
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public DateTime DateTimeCheckIn { get; set; }
        public DateTime DateTimeCheckOut { get; set; }
        public int Status { get; set; }
        public string StrStatus { get; set; }
    }
}
