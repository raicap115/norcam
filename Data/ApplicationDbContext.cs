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
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Ordenes> Ordenes { get; set; }
        public DbSet<Facturas> Factura { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Recibos> Recibos { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}