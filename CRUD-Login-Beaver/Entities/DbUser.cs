using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Login_Beaver.Entities
{
    public class DbUser : IdentityUser<int>
    {
        public ICollection<DbUserRole> UserRoles { get; set; }
    }
}
