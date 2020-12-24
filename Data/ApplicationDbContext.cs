using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using norcam.Models;

namespace norcam.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Ordenes> Ordenes { get; set; }
        public DbSet<Facturas> Facturas { get; set; }
        public DbSet<Home> Homes { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}