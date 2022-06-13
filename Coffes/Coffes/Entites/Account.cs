using System;

namespace Coffes.Entites
{
    public class Account
    {
        public Guid Id { get; set; } = new Guid();
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public string Description { get; set; }
    }
}
