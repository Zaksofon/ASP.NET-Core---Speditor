using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Speditor.Data.Models;

namespace Speditor.Data
{
    public class SpeditorDbContext : IdentityDbContext
    {
        public SpeditorDbContext(DbContextOptions<SpeditorDbContext> options)
            : base(options)
        {
        }
        public DbSet<Carrier> Carriers { get; init; }
        public DbSet<Cargo> Cargoes { get; init; }
        public DbSet<FreightAd> Freights { get; init; }
        public DbSet<GoodsOwner> Senders { get; init; }
        public DbSet<Receiver> Receivers { get; init; }
        public DbSet<CargoSpaceDimension> CargoSpaceDimensions { get; init; }
        public DbSet<CargoSpaceType> CargoSpaceTypes { get; init; }
    }
}
