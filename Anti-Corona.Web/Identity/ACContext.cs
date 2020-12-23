using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anti_Corona.Web.Identity;

namespace Anti_Corona.Web.Identity
{
    public class ACContext:IdentityDbContext<User>
    {
        public ACContext(DbContextOptions<ACContext> options):base(options)
        {

        }
    }
}
