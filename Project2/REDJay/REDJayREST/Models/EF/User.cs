using System;
using System.Collections.Generic;

namespace REDJayREST.Models.EF
{
    public partial class User
    {
        public User()
        {
            Customers = new HashSet<Customer>();
        }

        public int PkUserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime LoginDateCreated { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
