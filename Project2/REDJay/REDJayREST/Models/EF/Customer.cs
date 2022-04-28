using System;
using System.Collections.Generic;

namespace REDJayREST.Models.EF
{
    public partial class Customer
    {
        public Customer()
        {
            UserUploads = new HashSet<UserUpload>();
        }

        public string CustomerFirstName { get; set; } = null!;
        public string CustomerLastName { get; set; } = null!;
        public string CustomerAddress { get; set; } = null!;
        public string CustomerEmail { get; set; } = null!;
        public int FkUsernameId { get; set; }
        public int FkCityId { get; set; }
        public int FkStateId { get; set; }
        public int FkCountryId { get; set; }
        public DateTime LoginDateCreated { get; set; }
        public int PkCustomerId { get; set; }

        public virtual City FkCity { get; set; } = null!;
        public virtual Country FkCountry { get; set; } = null!;
        public virtual State FkState { get; set; } = null!;
        public virtual User FkUsername { get; set; } = null!;
        public virtual ICollection<UserUpload> UserUploads { get; set; }
    }
}
