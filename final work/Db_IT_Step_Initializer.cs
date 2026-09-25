using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_work
{
    public static class Db_IT_Step_Initializer
    {
        public static void SeedCountry(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(new Country[]
            {
                new Country()
                {
                    Id = 1,
                    Name = "Ukraine"
                },
                new Country()
                {
                    Id = 2,
                    Name = "Poland"
                },
                new Country()
                {
                    Id = 3,
                    Name = "Germany"
                }
            });
        }

        public static void SeedPositions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Positions>().HasData(new Positions[]
            {
                new Positions()
                {
                    Id = 1
                },
                new Positions()
                {
                    Id = 2
                },
                new Positions()
                {
                    Id = 3
                }
            });
        }

        public static void SeedDepartments(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departments>().HasData(new Departments[]
            {
                new Departments()
                {
                    Id = 1,
                    Name = "Programming",
                    Building = "B A"
                },
                new Departments()
                {
                    Id = 2,
                    Name = "Design",
                    Building = "B B"
                },
                new Departments()
                {
                    Id = 3,
                    Name = "Management",
                    Building = "B C"
                }
            });
        }

        public static void SeedSubjects(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subjects>().HasData(new Subjects[]
            {
                new Subjects()
                {
                    Id = 1,
                    Name = "C#"
                },
                new Subjects()
                {
                    Id = 2,
                    Name = "Database"
                },
                new Subjects()
                {
                    Id = 3,
                    Name = "FireWork"
                }
            });
        }

        public static void SeedGroups(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Groups>().HasData(new Groups[]
            {
                new Groups()
                {
                    Id = 1,
                    Name = "PV-21",
                    Year = 3
                },
                new Groups()
                {
                    Id = 2,
                    Name = "PV-22",
                    Year = 2
                },
                new Groups()
                {
                    Id = 3,
                    Name = "PV-23",
                    Year = 1
                }
            });
        }

        public static void SeedManagers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Managers>().HasData(new Managers[]
            {
                 new Managers()
                 {
                     Id = 1,
                     Name = "Oleksa",
                     PositionId = 2
                 },
                 new Managers()
                 {
                     Id = 2,
                     Name = "Olena",
                     PositionId = 2
                 }
            });
        }

        public static void SeedTeachers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teachers>().HasData(new Teachers[]
            {
                new Teachers()
                {
                    Id = 1,
                    Name = "Ivan",
                    Surname = "Petren",
                    Patronymic = "Ivanov",
                    Birthdate = new DateTime(1985, 5, 12),
                    Hiring = new DateTime(2020, 9, 1),
                    CountryId = 1,
                    PositionId = 3,
                    ManagersId = 1
                },
                new Teachers()
                {
                    Id = 2,
                    Name = "Oksana",
                    Surname = "Koval",
                    Patronymic = "Petriv",
                    Birthdate = new DateTime(1990, 3, 20),
                    Hiring = new DateTime(2021, 9, 1),
                    CountryId = 2,
                    PositionId = 3,
                    ManagersId = 2
                },
                new Teachers()
                {
                    Id = 3,
                    Name = "Adam",
                    Surname = "Nowak",
                    Patronymic = "Novakchuk",
                    Birthdate = new DateTime(1988, 7, 15),
                    Hiring = new DateTime(2022, 2, 1),
                    CountryId = 3,
                    PositionId = 3,
                    ManagersId = 2
                }
            });
        }

        public static void SeedStudents(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>().HasData(new Students[]
            {
                new Students()
                {
                    Id = 1,
                    Name = "Andri",
                    Surname = "Melnyk",
                    Rating = 99,
                    GroupsId = 1,
                    StudAdmission = new DateTime(2025, 9, 1)
                },
                new Students()
                {
                    Id = 2,
                    Name = "Maria",
                    Surname = "Shevchenko",
                    Rating = 76,
                    GroupsId = 2,
                    StudAdmission = new DateTime(2025, 9, 1)
                },
                new Students()
                {
                    Id = 3,
                    Name = "Dmytro",
                    Surname = "Bondar",
                    Rating = 91,
                    GroupsId = 3,
                    StudAdmission = new DateTime(2025, 9, 1)
                }
            });
        }

        public static void SeedDirector(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Director>().HasData(new Director[]
            {
                new Director()
                {
                    Id = 1,
                    Name = "Mykola",
                    PositionId = 1
                }
            });
        }
    }
}
