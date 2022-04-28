using System;
using System.Collections.Generic;

namespace REDJayREST.Models.EF
{
    public partial class Role
    {
        public int PkRoleId { get; set; }
        public string RoleDescription { get; set; } = null!;
    }
}
