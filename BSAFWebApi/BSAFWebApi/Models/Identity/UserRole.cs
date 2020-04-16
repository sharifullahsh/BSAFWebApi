using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSAFWebApi.Models.Identity
{
    public class UserRole:IdentityUserRole<int>
    {
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }

    }
}
