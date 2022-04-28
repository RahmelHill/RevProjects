using System;
using System.Collections.Generic;

namespace REDJayREST.Models.EF
{
    public partial class City
    {
        public City()
        {
            Customers = new HashSet<Customer>();
            StoreLocations = new HashSet<StoreLocation>();
        }

        public int PkCityId { get; set; }
        public string CityName { get; set; } = null!;

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<StoreLocation> StoreLocations { get; set; }
    }
}
