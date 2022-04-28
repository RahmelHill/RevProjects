using System;
using System.Collections.Generic;

namespace REDJayREST.Models.EF
{
    public partial class SizeSuit
    {
        public SizeSuit()
        {
            FullPieceSuits = new HashSet<FullPieceSuit>();
            SuitBottoms = new HashSet<SuitBottom>();
            SuitTops = new HashSet<SuitTop>();
        }

        public int PkSuitSizeId { get; set; }
        public string SuitSize { get; set; } = null!;

        public virtual ICollection<FullPieceSuit> FullPieceSuits { get; set; }
        public virtual ICollection<SuitBottom> SuitBottoms { get; set; }
        public virtual ICollection<SuitTop> SuitTops { get; set; }
    }
}
