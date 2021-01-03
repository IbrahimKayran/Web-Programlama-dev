using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebProgramlaOdev.Models;

namespace WebProgramlaOdev.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Hayvan> Hayvan { get; set; }

        public DbSet<Kedi> Kedi { get; set; }

        public DbSet<Kopek> Kopek { get; set; }

        public DbSet<UKategori> UKategori { get; set; }

        public DbSet<Urun> Urun { get; set; }

        public DbSet<Uye> Uye { get; set; }

        public DbSet<Yorum> Yorum { get; set; }
    }
}
