using System;
using System.Collections.Generic;

namespace REDJayREST.Models.EF
{
    public partial class SuitTop
    {
        public int PkSuitTop { get; set; }
        public string StyleName { get; set; } = null!;
        public string BrandName { get; set; } = null!;
        public bool InStock { get; set; }
        public int FkSuitSizeId { get; set; }
        public int FkConditionId { get; set; }

        public virtual Condition FkCondition { get; set; } = null!;
        public virtual SizeSuit FkSuitSize { get; set; } = null!;
    }
}
