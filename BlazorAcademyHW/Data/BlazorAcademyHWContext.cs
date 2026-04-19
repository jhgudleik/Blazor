using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorAcademyHW.Models;

namespace BlazorAcademyHW.Data
{
    public class BlazorAcademyHWContext : DbContext
    {
        public BlazorAcademyHWContext(DbContextOptions<BlazorAcademyHWContext> options) 
            : base(options)
        {
        }
        public DbSet<Student> Student { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Явно указываем, что сущность Student маппится на таблицу "Students"
            modelBuilder.Entity<Student>().ToTable("Students");
            // Указываем, что Teachers.Id — это SMALLINT в БД
            modelBuilder.Entity<Teachers>()
                .Property(t => t.teacher_id)
                .HasColumnType("smallint");
            // Groups
            modelBuilder.Entity<Groups>().ToTable("Groups");
            modelBuilder.Entity<Groups>()
                .Property(g => g.group_id).HasColumnType("int");
            modelBuilder.Entity<Groups>()
                .Property(g => g.group_name).HasColumnType("nchar(10)");
            modelBuilder.Entity<Groups>()
                .Property(g => g.direction).HasColumnType("tinyint");

        }
        public DbSet<BlazorAcademyHW.Models.Teachers> Teachers { get; set; } = default!;
        public DbSet<BlazorAcademyHW.Models.Groups> Groups { get; set; } = default!;

    }
}
