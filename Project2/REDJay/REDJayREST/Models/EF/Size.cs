using System;
using System.Collections.Generic;

namespace REDJayREST.Models.EF
{
    public partial class Size
    {
        public Size()
        {
            JacketsCoats = new HashSet<JacketsCoat>();
            Jeans = new HashSet<Jean>();
            Shirts = new HashSet<Shirt>();
            Shorts = new HashSet<Short>();
            Sweats = new HashSet<Sweat>();
            TankTops = new HashSet<TankTop>();
        }

        public int PkSizeId { get; set; }
        public string ClothingSize { get; set; } = null!;

        public virtual ICollection<JacketsCoat> JacketsCoats { get; set; }
        public virtual ICollection<Jean> Jeans { get; set; }
        public virtual ICollection<Shirt> Shirts { get; set; }
        public virtual ICollection<Short> Shorts { get; set; }
        public virtual ICollection<Sweat> Sweats { get; set; }
        public virtual ICollection<TankTop> TankTops { get; set; }
    }
}
