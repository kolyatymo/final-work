using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_work
{
    public class IT_Step : DbContext
    {
        public IT_Step() { this.Database.EnsureDeleted(); }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"
                                Data Source = (localdb)\MSSQLLocalDB;
                                Initial Catalog = My_Final_work;
                                Integrated Security = True;
                                Connect Timeout = 2");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Teachers>()
                .Property(x => x.Name)
                .HasMaxLength(50);

            modelBuilder.Entity<Teachers>()
                .Property(x => x.Surname)
                .HasMaxLength(50);

            modelBuilder.Entity<Teachers>()
                .Property(x => x.Patronymic)
                .HasMaxLength(50);
            
            modelBuilder.Entity<Departments>()
                .Property(x => x.Name)
                .HasMaxLength(50);

            modelBuilder.Entity<Departments>()
                .Property(x => x.Building)
                .HasMaxLength(50);

            modelBuilder.Entity<Groups>()
                .Property(y => y.Name)
                .HasMaxLength(50);

            modelBuilder.Entity<Subjects>()
                .Property(n => n.Name)
                .HasMaxLength(50);
            
            modelBuilder.Entity<Country>()
                .Property(n => n.Name)
                .HasMaxLength(50);

            modelBuilder.Entity<Students>()
                .Property(n => n.Name)
                .HasMaxLength(50);

            modelBuilder.Entity<Students>()
                .Property(n => n.Surname)
                .HasMaxLength(50);

            modelBuilder.Entity<Managers>()
                .Property(n => n.Name)
                .HasMaxLength(50);

            modelBuilder.Entity<Director>()
                .Property(n => n.Name)
                .HasMaxLength(50);

            // 1 .... *

            modelBuilder.Entity<Teachers>()
                .HasOne(c => c.Country)
                .WithMany(t => t.Teachers)
                .HasForeignKey(m => m.CountryId);

            modelBuilder.Entity<Teachers>()
                .HasOne(o => o.Manager)
                .WithMany(t => t.Teachers)
                .HasForeignKey(m => m.ManagersId);

            modelBuilder.Entity<Teachers>()
                .HasOne(o => o.Positions)
                .WithMany(t => t.Teachers)
                .HasForeignKey(m => m.PositionId);

            modelBuilder.Entity<Managers>()
                .HasOne(o => o.Positions)
                .WithMany(t => t.Managers)
                .HasForeignKey(m => m.PositionId);


            // * .... * 

            modelBuilder.Entity<Teachers>()
                .HasMany(m => m.Groups)
                .WithMany(t => t.Teachers);

            modelBuilder.Entity<Teachers>()
                .HasMany(m => m.Subjects)
                .WithMany(t => t.Teachers); 
            
            modelBuilder.Entity<Teachers>()
                .HasMany(m => m.Departments)
                .WithMany(t => t.Teachers);

            modelBuilder.Entity<Students>()
                .HasMany(m => m.Subjects)
                .WithMany(t => t.Students);
            
            modelBuilder.Entity<Students>()
                .HasMany(m => m.Departments)
                .WithMany(t => t.Students);

            modelBuilder.SeedCountry();
            modelBuilder.SeedPositions();
            modelBuilder.SeedDepartments();
            modelBuilder.SeedSubjects();
            modelBuilder.SeedGroups();
            modelBuilder.SeedManagers();
            modelBuilder.SeedTeachers();
            modelBuilder.SeedStudents();
            modelBuilder.SeedDirector();

        }

        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Managers> Managers { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Positions> Positions { get; set; }


    }
    public class Teachers
    {
        public Teachers()
        {
            Groups = new HashSet<Groups>();
            Subjects = new HashSet<Subjects>();
            Departments = new HashSet<Departments>();
        }
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }
        [MaxLength(50)]
        public string Patronymic { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime Hiring {  get; set; }
        public int CountryId { get; set; }
        public int PositionId { get; set; }
        public int? ManagersId { get; set; }
        public Managers Manager { get; set; }
        public Country Country { get; set; }
        public Positions Positions { get; set; }
        public ICollection<Departments> Departments { get; set; }
        public ICollection<Subjects> Subjects {  get; set; } 
        public ICollection<Groups> Groups { get; set; }
    }

    public class Departments
    {
        public Departments()
        {
            Students = new HashSet<Students>();
            Teachers = new HashSet<Teachers>();
        }
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public string Building { get; set; }
        public ICollection<Students> Students {  get; set; } 
        public ICollection<Teachers> Teachers {  get; set; } 
    }

    public class Groups
    {
        public Groups()
        {
            Teachers = new HashSet<Teachers>();
            Students = new HashSet<Students>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public ICollection<Students> Students { get; set; }
        public ICollection<Teachers> Teachers { get; set; }
    }

    public class Subjects
    {
        public Subjects()
        {
            Students = new HashSet<Students>();
            Teachers = new HashSet<Teachers>();
        }
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public ICollection<Teachers> Teachers { get; set; }
        public ICollection<Students> Students{ get; set; }
    }

    public class Country
    {
        public Country()
        {
            Teachers = new HashSet<Teachers>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Teachers> Teachers { get; set; }
    }

    public class Students
    {
        public Students()
        {
            Subjects = new HashSet<Subjects>();
            Departments = new HashSet<Departments>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }    
        public int Rating { get; set; }
        public int GroupsId { get; set; }
        public Groups Groups { get; set; }
        public DateTime StudAdmission { get; set; }
        public ICollection<Departments> Departments { get; set; }
        public ICollection<Subjects> Subjects { get; set; }
    }

    public class Managers
    {
        public Managers()
        {
            Teachers = new HashSet<Teachers>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int PositionId { get; set; }
        public Positions Positions { get; set; }
        public ICollection<Teachers> Teachers { get; set; }
    }

    public class Director
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PositionId {  get; set; }
        public Positions Position { get; set; }
    }

    public class Positions
    {
        public Positions()
        {
            Teachers = new HashSet<Teachers>();
            Managers = new HashSet<Managers>();
        }
        public int Id { get; set; }
        public ICollection<Teachers> Teachers { get; set; }
        public ICollection<Managers> Managers { get; set; }
    }
}
