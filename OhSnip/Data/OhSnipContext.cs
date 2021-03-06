﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OhSnip.Models;

namespace OhSnip.Data
{
    public class OhSnipContext : IdentityDbContext<ApplicationUser>
    {
        public OhSnipContext(DbContextOptions<OhSnipContext> options)
            : base(options)
        {
        }

        public DbSet<Snippet> Snippets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<Snippet>().ToTable("Snippet");
        }
    }
}
