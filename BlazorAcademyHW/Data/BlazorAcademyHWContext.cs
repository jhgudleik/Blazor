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

        }
        public DbSet<BlazorAcademyHW.Models.Teachers> Teachers { get; set; } = default!;
    }
}
