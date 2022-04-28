using System;
using System.Collections.Generic;

namespace REDJayREST.Models.EF
{
    public partial class UserRole
    {
        public int FkUserId { get; set; }
        public int FkRoleId { get; set; }

        public virtual Role FkRole { get; set; } = null!;
        public virtual User FkUser { get; set; } = null!;
    }
}
