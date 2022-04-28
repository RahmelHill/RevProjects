using System;
using System.Collections.Generic;

namespace REDJayREST.Models.EF
{
    public partial class Country
    {
        public Country()
        {
            Customers = new HashSet<Customer>();
            StoreLocations = new HashSet<StoreLocation>();
        }

        public int PkCountryId { get; set; }
        public string CountryName { get; set; } = null!;

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<StoreLocation> StoreLocations { get; set; }
    }
}
