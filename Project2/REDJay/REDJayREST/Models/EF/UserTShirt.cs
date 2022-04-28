using System;
using System.Collections.Generic;

namespace REDJayREST.Models.EF
{
    public partial class UserTShirt
    {
        public int PkTShirtId { get; set; }
        public int UploadSize { get; set; }
        public int UploadCondition { get; set; }
        public bool? InStock { get; set; }
        public bool AdminApproval { get; set; }
    }
}
