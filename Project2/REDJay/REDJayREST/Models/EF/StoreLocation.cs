using System;
using System.Collections.Generic;

namespace REDJayREST.Models.EF
{
    public partial class StoreLocation
    {
        public int PkStoreLocationId { get; set; }
        public string StoreName { get; set; } = null!;
        public string StoreAddress { get; set; } = null!;
        public int FkCityId { get; set; }
        public int FkStateId { get; set; }
        public int FkCountryId { get; set; }

        public virtual City FkCity { get; set; } = null!;
        public virtual Country FkCountry { get; set; } = null!;
        public virtual State FkState { get; set; } = null!;
    }
}
