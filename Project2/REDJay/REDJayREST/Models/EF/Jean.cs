using System;
using System.Collections.Generic;

namespace REDJayREST.Models.EF
{
    public partial class Jean
    {
        public int PkJeansId { get; set; }
        public string JeanStyle { get; set; } = null!;
        public string JeanBrand { get; set; } = null!;
        public bool InStock { get; set; }
        public int FkSizeId { get; set; }
        public int FkConditionId { get; set; }

        public virtual Condition FkCondition { get; set; } = null!;
        public virtual Size FkSize { get; set; } = null!;
    }
}
