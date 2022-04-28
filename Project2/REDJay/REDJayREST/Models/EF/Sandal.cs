using System;
using System.Collections.Generic;

namespace REDJayREST.Models.EF
{
    public partial class Sandal
    {
        public int PkSandalsId { get; set; }
        public string SandalName { get; set; } = null!;
        public string BrandName { get; set; } = null!;
        public bool InStock { get; set; }
        public int FkShoeSizeId { get; set; }
        public int FkConditionId { get; set; }

        public virtual Condition FkCondition { get; set; } = null!;
        public virtual ShoeSize FkShoeSize { get; set; } = null!;
    }
}
