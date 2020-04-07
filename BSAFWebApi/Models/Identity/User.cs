using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSAFWebApi.Models.Identity
{
    public class User : IdentityUser<int>
    {
        public DateTime CreatedDate { get; set; }
        public DateTime LastActive { get; set; }
        public string StationCode { get; set; }
        public bool IsDeleted { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public User()
        {
            IsDeleted = false;
        }
    }
}
