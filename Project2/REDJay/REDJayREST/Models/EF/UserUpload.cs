using System;
using System.Collections.Generic;

namespace REDJayREST.Models.EF
{
    public partial class UserUpload
    {
        public int PkCartId { get; set; }
        public int FkCustomerId { get; set; }
        public int? FkJacketCoatId { get; set; }
        public int? FkJeansId { get; set; }
        public int? FkSweatsId { get; set; }
        public int? FkShortsId { get; set; }
        public int? FkSandalsId { get; set; }
        public int? FkBootsId { get; set; }
        public int? FkSneakerId { get; set; }
        public int? FkSuitBottom { get; set; }
        public int? FkFullSuit { get; set; }
        public int? FkSuitTop { get; set; }
        public int? FkShirtId { get; set; }
        public int? FkTankTopId { get; set; }

        public virtual UserBoot? FkBoots { get; set; }
        public virtual Customer FkCustomer { get; set; } = null!;
        public virtual UserFullPieceSuit? FkFullSuitNavigation { get; set; }
        public virtual UserJacketsCoat? FkJacketCoat { get; set; }
        public virtual UserJean? FkJeans { get; set; }
        public virtual UserSandal? FkSandals { get; set; }
        public virtual UserShirt? FkShirt { get; set; }
        public virtual UserShort? FkShorts { get; set; }
        public virtual UserSneaker? FkSneaker { get; set; }
        public virtual UserSuitBottom? FkSuitBottomNavigation { get; set; }
        public virtual UserSuitTop? FkSuitTopNavigation { get; set; }
        public virtual UserSweat? FkSweats { get; set; }
        public virtual UserTankTop? FkTankTop { get; set; }
    }
}
