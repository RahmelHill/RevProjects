using System;
using System.Collections.Generic;

namespace REDJayREST.Models.EF
{
    public partial class TankTop
    {
        public int PkTankTopId { get; set; }
        public string StyleName { get; set; } = null!;
        public string BrandName { get; set; } = null!;
        public int FkConditionId { get; set; }
        public int FkSizeId { get; set; }
        public bool? InStock { get; set; }

        public virtual Condition FkCondition { get; set; } = null!;
        public virtual Size FkSize { get; set; } = null!;
    }
}
