using AnimalCrossingWebApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCrossingWebApp.Data.Contexts
{
    public class VillagerContext : DbContext
    {

        private readonly ILoggerFactory _factory;
        public virtual DbSet<Villagers> Villagers { get; set; }
        public virtual DbSet<NorthFish> NorthFish { get; set; }
        public virtual DbSet<SouthFish> SouthFish { get; set; }
        public virtual DbSet<NorthBug> NorthBug { get; set; }
        public virtual DbSet<SouthBug> SouthBug { get; set; }
        public virtual DbSet<SpecialCharacters> SpecialCharacters { get; set; }


        public VillagerContext(DbContextOptions<VillagerContext> options, ILoggerFactory factory) : base(options)
        {
            _factory = factory;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               
                optionsBuilder.UseLoggerFactory(_factory);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villagers>(entity =>
            {
                entity.ToTable("Villagers", "dbo");

                entity.HasKey(e => e.newID);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsRequired()
                    .HasColumnName("Name");

                entity.Property(e => e.Personality)
                    .HasMaxLength(50)
                    .IsRequired()
                    .HasColumnName("Personality");

                entity.Property(e => e.Species)
                    .HasMaxLength(50)
                    .IsRequired()
                    .HasColumnName("Species");

                entity.Property(e => e.DateOfBirth)
                    .HasMaxLength(50)
                    .HasColumnName("DateOfBirth");

                entity.Property(e => e.Catchphrase)
                    .HasMaxLength(50)
                    .HasColumnName("Catchphrase");


                entity.Property(e => e.PicURL)
                    .IsRequired()
                    .HasColumnName("PicURL");

                entity.Property(e => e.Hobby)
                    .HasMaxLength(50)
                    .HasColumnName("Hobby");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .HasColumnName("Color");

                entity.Property(e => e.Styles)
                    .HasMaxLength(50)
                    .HasColumnName("Styles");

                entity.Property(e => e.House)
                    .HasColumnName("House");

            });

            modelBuilder.Entity<NorthFish>(entity =>
            {
                entity.ToTable("NorthHemisphereFish", "dbo");

                entity.HasKey(e => e.ID);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsRequired()
                    .HasColumnName("Name");

                entity.Property(e => e.Image)
                   .IsRequired()
                   .HasColumnName("Image");

                entity.Property(e => e.Price)
                   .IsRequired()
                   .HasColumnName("Price");

                entity.Property(e => e.Location)
                  .IsRequired()
                  .HasColumnName("Location");

                entity.Property(e => e.ShadowSize)
                  .IsRequired()
                  .HasColumnName("ShadowSize");

                entity.Property(e => e.Time)
                  .IsRequired()
                  .HasColumnName("Time");

                entity.Property(e => e.Jan)
                  .HasColumnName("Jan");

                entity.Property(e => e.Feb)
                  .HasColumnName("Feb");

                entity.Property(e => e.Mar)
                  .HasColumnName("Mar");

                entity.Property(e => e.Apr)
                  .HasColumnName("Apr");

                entity.Property(e => e.May)
                  .HasColumnName("May");

                entity.Property(e => e.Jun)
                  .HasColumnName("Jun");

                entity.Property(e => e.Jul)
                  .HasColumnName("Jul");

                entity.Property(e => e.Aug)
                  .HasColumnName("Aug");

                entity.Property(e => e.Sep)
                  .HasColumnName("Sep");

                entity.Property(e => e.Oct)
                  .HasColumnName("Oct");

                entity.Property(e => e.Nov)
                  .HasColumnName("Nov");

                entity.Property(e => e.Dec)
                  .HasColumnName("Dec");

            });

            modelBuilder.Entity<SouthFish>(entity =>
            {
                entity.ToTable("SouthernHemisphereFish", "dbo");

                entity.HasKey(e => e.ID);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsRequired()
                    .HasColumnName("Name");

                entity.Property(e => e.Image)
                   .IsRequired()
                   .HasColumnName("Image");

                entity.Property(e => e.Price)
                   .IsRequired()
                   .HasColumnName("Price");

                entity.Property(e => e.Location)
                  .IsRequired()
                  .HasColumnName("Location");

                entity.Property(e => e.ShadowSize)
                  .IsRequired()
                  .HasColumnName("ShadowSize");

                entity.Property(e => e.Time)
                  .IsRequired()
                  .HasColumnName("Time");

                entity.Property(e => e.Jan)
                  .HasColumnName("Jan");

                entity.Property(e => e.Feb)
                  .HasColumnName("Feb");

                entity.Property(e => e.Mar)
                  .HasColumnName("Mar");

                entity.Property(e => e.Apr)
                  .HasColumnName("Apr");

                entity.Property(e => e.May)
                  .HasColumnName("May");

                entity.Property(e => e.Jun)
                  .HasColumnName("Jun");

                entity.Property(e => e.Jul)
                  .HasColumnName("Jul");

                entity.Property(e => e.Aug)
                  .HasColumnName("Aug");

                entity.Property(e => e.Sep)
                  .HasColumnName("Sep");

                entity.Property(e => e.Oct)
                  .HasColumnName("Oct");

                entity.Property(e => e.Nov)
                  .HasColumnName("Nov");

                entity.Property(e => e.Dec)
                  .HasColumnName("Dec");

            });

            modelBuilder.Entity<NorthBug>(entity =>
            {
                entity.ToTable("NorthernHemisphereBug", "dbo");

                entity.HasKey(e => e.ID);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsRequired()
                    .HasColumnName("Name");

                entity.Property(e => e.Image)
                   .IsRequired()
                   .HasColumnName("Image");

                entity.Property(e => e.Price)
                   .IsRequired()
                   .HasColumnName("Price");

                entity.Property(e => e.Location)
                  .IsRequired()
                  .HasColumnName("Location");


                entity.Property(e => e.Time)
                  .IsRequired()
                  .HasColumnName("Time");

                entity.Property(e => e.Jan)
                  .HasColumnName("Jan");

                entity.Property(e => e.Feb)
                  .HasColumnName("Feb");

                entity.Property(e => e.Mar)
                  .HasColumnName("Mar");

                entity.Property(e => e.Apr)
                  .HasColumnName("Apr");

                entity.Property(e => e.May)
                  .HasColumnName("May");

                entity.Property(e => e.Jun)
                  .HasColumnName("Jun");

                entity.Property(e => e.Jul)
                  .HasColumnName("Jul");

                entity.Property(e => e.Aug)
                  .HasColumnName("Aug");

                entity.Property(e => e.Sep)
                  .HasColumnName("Sep");

                entity.Property(e => e.Oct)
                  .HasColumnName("Oct");

                entity.Property(e => e.Nov)
                  .HasColumnName("Nov");

                entity.Property(e => e.Dec)
                  .HasColumnName("Dec");

            });

            modelBuilder.Entity<SouthBug>(entity =>
            {
                entity.ToTable("SouthernHemisphereBug", "dbo");

                entity.HasKey(e => e.ID);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsRequired()
                    .HasColumnName("Name");

                entity.Property(e => e.Image)
                   .IsRequired()
                   .HasColumnName("Image");

                entity.Property(e => e.Price)
                   .IsRequired()
                   .HasColumnName("Price");

                entity.Property(e => e.Location)
                  .IsRequired()
                  .HasColumnName("Location");


                entity.Property(e => e.Time)
                  .IsRequired()
                  .HasColumnName("Time");

                entity.Property(e => e.Jan)
                  .HasColumnName("Jan");

                entity.Property(e => e.Feb)
                  .HasColumnName("Feb");

                entity.Property(e => e.Mar)
                  .HasColumnName("Mar");

                entity.Property(e => e.Apr)
                  .HasColumnName("Apr");

                entity.Property(e => e.May)
                  .HasColumnName("May");

                entity.Property(e => e.Jun)
                  .HasColumnName("Jun");

                entity.Property(e => e.Jul)
                  .HasColumnName("Jul");

                entity.Property(e => e.Aug)
                  .HasColumnName("Aug");

                entity.Property(e => e.Sep)
                  .HasColumnName("Sep");

                entity.Property(e => e.Oct)
                  .HasColumnName("Oct");

                entity.Property(e => e.Nov)
                  .HasColumnName("Nov");

                entity.Property(e => e.Dec)
                  .HasColumnName("Dec");

            });

            modelBuilder.Entity<SpecialCharacters>(entity =>
            {
                entity.ToTable("SpecialCharacters", "dbo");

                entity.HasKey(e => e.ID);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsRequired()
                    .HasColumnName("Name");

                entity.Property(e => e.Image)
                   .IsRequired()
                   .HasColumnName("Image");

                entity.Property(e => e.Service)
                   .HasColumnName("Service");
            });
        }
    }
}
