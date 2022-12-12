﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RestaurantApp.Models
{
    public partial class resturentContext : DbContext
    {
        public resturentContext()
        {
        }

        public resturentContext(DbContextOptions<resturentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<OrderItems> OrderItems { get; set; }
        public virtual DbSet<ResEmployee> ResEmployee { get; set; }
        public virtual DbSet<ResOrder> ResOrder { get; set; }
        public virtual DbSet<ResTable> ResTable { get; set; }
        public virtual DbSet<ResUser> ResUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-DNK5RHH\\SQLEXPRESS;Initial Catalog=resturent;Integrated Security=True; encrypt=false");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.Category)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cuisine)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Res)
                    .WithMany(p => p.Menu)
                    .HasForeignKey(d => d.ResId)
                    .HasConstraintName("FK__Menu__ResId__3C69FB99");
            });

            modelBuilder.Entity<OrderItems>(entity =>
            {
                entity.HasKey(e => e.ItemsId)
                    .HasName("PK__OrderIte__19AFBB7EEB1E19FB");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK__OrderItem__MenuI__4AB81AF0");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__OrderItem__Order__49C3F6B7");
            });

            modelBuilder.Entity<ResEmployee>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__ResEmplo__AF2DBB99AE87656F");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dob).HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.Res)
                    .WithMany(p => p.ResEmployee)
                    .HasForeignKey(d => d.ResId)
                    .HasConstraintName("FK__ResEmploy__ResId__4222D4EF");
            });

            modelBuilder.Entity<ResOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__ResOrder__C3905BCFC2F810C9");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.ResOrder)
                    .HasForeignKey(d => d.OwnerId)
                    .HasConstraintName("FK__ResOrder__OwnerI__45F365D3");

                entity.HasOne(d => d.Res)
                    .WithMany(p => p.ResOrder)
                    .HasForeignKey(d => d.ResId)
                    .HasConstraintName("FK__ResOrder__ResId__44FF419A");

                entity.HasOne(d => d.Table)
                    .WithMany(p => p.ResOrder)
                    .HasForeignKey(d => d.TableId)
                    .HasConstraintName("FK__ResOrder__TableI__46E78A0C");
            });

            modelBuilder.Entity<ResTable>(entity =>
            {
                entity.HasKey(e => e.TableId)
                    .HasName("PK__ResTable__7D5F01EECE0C5487");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Res)
                    .WithMany(p => p.ResTable)
                    .HasForeignKey(d => d.ResId)
                    .HasConstraintName("FK__ResTable__ResId__3F466844");
            });

            modelBuilder.Entity<ResUser>(entity =>
            {
                entity.HasKey(e => e.ResId)
                    .HasName("PK__ResUser__297882F66748BCA8");

                entity.HasIndex(e => e.Email, "UQ__ResUser__A9D105344A0F84F0")
                    .IsUnique();

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(900)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}