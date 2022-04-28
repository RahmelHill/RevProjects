using System;
using System.Collections.Generic;

namespace REDJayREST.Models.EF
{
    public partial class State
    {
        public State()
        {
            Customers = new HashSet<Customer>();
            StoreLocations = new HashSet<StoreLocation>();
        }

        public int PkStateId { get; set; }
        public string StateName { get; set; } = null!;

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<StoreLocation> StoreLocations { get; set; }
    }
}
