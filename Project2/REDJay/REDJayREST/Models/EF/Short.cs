using System;
using System.Collections.Generic;

namespace REDJayREST.Models.EF
{
    public partial class Short
    {
        public int PkShortsId { get; set; }
        public string ShortsStyle { get; set; } = null!;
        public string ShortsBrand { get; set; } = null!;
        public bool InStock { get; set; }
        public int FkSizeId { get; set; }
        public int FkConditionId { get; set; }

        public virtual Condition FkCondition { get; set; } = null!;
        public virtual Size FkSize { get; set; } = null!;
    }
}
