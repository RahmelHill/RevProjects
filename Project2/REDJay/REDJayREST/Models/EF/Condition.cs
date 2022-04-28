using System;
using System.Collections.Generic;

namespace REDJayREST.Models.EF
{
    public partial class Condition
    {
        public Condition()
        {
            Boots = new HashSet<Boot>();
            FullPieceSuits = new HashSet<FullPieceSuit>();
            JacketsCoats = new HashSet<JacketsCoat>();
            Jeans = new HashSet<Jean>();
            Sandals = new HashSet<Sandal>();
            Shirts = new HashSet<Shirt>();
            Shorts = new HashSet<Short>();
            Sneakers = new HashSet<Sneaker>();
            SuitBottoms = new HashSet<SuitBottom>();
            SuitTops = new HashSet<SuitTop>();
            Sweats = new HashSet<Sweat>();
            TankTops = new HashSet<TankTop>();
        }

        public int PkConditionId { get; set; }
        public string? ItemCondition { get; set; }

        public virtual ICollection<Boot> Boots { get; set; }
        public virtual ICollection<FullPieceSuit> FullPieceSuits { get; set; }
        public virtual ICollection<JacketsCoat> JacketsCoats { get; set; }
        public virtual ICollection<Jean> Jeans { get; set; }
        public virtual ICollection<Sandal> Sandals { get; set; }
        public virtual ICollection<Shirt> Shirts { get; set; }
        public virtual ICollection<Short> Shorts { get; set; }
        public virtual ICollection<Sneaker> Sneakers { get; set; }
        public virtual ICollection<SuitBottom> SuitBottoms { get; set; }
        public virtual ICollection<SuitTop> SuitTops { get; set; }
        public virtual ICollection<Sweat> Sweats { get; set; }
        public virtual ICollection<TankTop> TankTops { get; set; }
    }
}
