using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1.Data.Models;

namespace WebApplication1.Data
{
    public class SpeditorDbContext : IdentityDbContext
    {
        public SpeditorDbContext(DbContextOptions<SpeditorDbContext> options)
            : base(options)
        {
        }

        public DbSet<Freight> Freights { get; init; }
        public DbSet<Sender> Senders { get; init; }
        public DbSet<Receiver> Receivers { get; init; }
    }
}
