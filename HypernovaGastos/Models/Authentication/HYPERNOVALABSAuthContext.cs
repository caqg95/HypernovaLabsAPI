using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HypernovaGastos.Models.Authentication
{
    public class HYPERNOVALABSAuthContext : IdentityDbContext<ApplicationUser>
    {
        public HYPERNOVALABSAuthContext()
        {
        }

        public HYPERNOVALABSAuthContext(DbContextOptions<HYPERNOVALABSAuthContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
