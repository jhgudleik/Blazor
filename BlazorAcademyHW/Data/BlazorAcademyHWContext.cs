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
                .Property(t => t.teacher_id).HasColumnType("smallint");
            // Дополнительная конфигурация Groups
            modelBuilder.Entity<Groups>().ToTable("Groups");
            modelBuilder.Entity<Groups>().Property(g => g.group_id).HasColumnType("int");
            modelBuilder.Entity<Groups>().Property(g => g.group_name).HasColumnType("nchar(10)");
            modelBuilder.Entity<Groups>().Property(g => g.direction).HasColumnType("tinyint");

            // НАСТРОЙКА СВЯЗИ Groups <-> Directions
            modelBuilder.Entity<Groups>()
                .HasOne(g => g.Direction)
                .WithMany()
                .HasForeignKey(g => g.direction);

            // НАСТРОЙКА СВЯЗИ Student <-> Groups  
            modelBuilder.Entity<Student>()
                .HasOne(s => s.GroupNavigation)
                .WithMany()
                .HasForeignKey(s => s.group);

            // Дополнительная конфигурация Directions
            modelBuilder.Entity<Directions>()
                .Property(d => d.direction_id).HasColumnType("tinyint");

            // Дополнительная конфигурация Disciplines
            modelBuilder.Entity<Disciplines>()
                .Property(d => d.discipline_id).HasColumnType("smallint");
            modelBuilder.Entity<Disciplines>()
                .Property(d => d.number_of_lessons).HasColumnType("tinyint");

            // Дополнительная конфигурация TeachersDisciplinesRelation
            modelBuilder.Entity<TeachersDisciplinesRelation>()
                .HasKey(t => new { t.teacher, t.discipline });



            // ✅ НОВАЯ КОНФИГУРАЦИЯ: Сущность Week
            modelBuilder.Entity<Week>()
                .ToTable("Week"); // Явно указываем имя таблицы (если нужно)

            modelBuilder.Entity<Week>()
                .Property(w => w.grp_id)
                .HasColumnType("int"); // Соответствует Groups.group_id

            modelBuilder.Entity<Week>()
                .Property(w => w.study_days)
                .HasColumnType("tinyint"); // Соответствует TINYINT в SQL

            // ✅ УКАЗЫВАЕМ СВЯЗЬ: Week принадлежит Groups (1:1, с каскадным удалением)
            modelBuilder.Entity<Week>()
                .HasOne(w => w.Group)
                .WithOne() // Groups не знает про Week — это "односторонняя" связь
                .HasForeignKey<Week>(w => w.grp_id) // Внешний ключ в Week
                .OnDelete(DeleteBehavior.Cascade); // При удалении группы — удаляются дни занятий



        }
        public DbSet<BlazorAcademyHW.Models.Teachers> Teachers { get; set; } = default!;
        public DbSet<BlazorAcademyHW.Models.Groups> Groups { get; set; } = default!;
        public DbSet<BlazorAcademyHW.Models.Directions> Directions { get; set; } = default!;
        public DbSet<BlazorAcademyHW.Models.Disciplines> Disciplines { get; set; } = default!;
        public DbSet<TeachersDisciplinesRelation> TeachersDisciplinesRelation { get; set; }

        // ✅ ДОБАВЛЕНО: Сущность Week (связь с Groups через grp_id)
        public DbSet<Week> Week { get; set; } = default!;
    }
}



