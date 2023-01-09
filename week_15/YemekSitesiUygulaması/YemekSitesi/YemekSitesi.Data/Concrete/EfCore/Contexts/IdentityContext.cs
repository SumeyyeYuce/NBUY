using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSitesi.Entity.Concrete.Identity;

namespace YemekSitesi.Data.Concrete.EfCore.Contexts
{
    public class IdentityContext :IdentityDbContext<User,Role,string>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options):base(options) 
        {

        }
    }
}
