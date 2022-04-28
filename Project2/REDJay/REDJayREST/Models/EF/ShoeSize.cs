using System;
using System.Collections.Generic;

namespace REDJayREST.Models.EF
{
    public partial class ShoeSize
    {
        public ShoeSize()
        {
            Boots = new HashSet<Boot>();
            Sandals = new HashSet<Sandal>();
            Sneakers = new HashSet<Sneaker>();
        }

        public int PkShoeSizeId { get; set; }
        public string ShoeSize1 { get; set; } = null!;

        public virtual ICollection<Boot> Boots { get; set; }
        public virtual ICollection<Sandal> Sandals { get; set; }
        public virtual ICollection<Sneaker> Sneakers { get; set; }
    }
}
