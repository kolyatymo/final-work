using Library_Db_IT_Step_FinalWork.Models;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Db_IT_Step_FinalWork
{
    public class Commands
    {
        private readonly IT_Step context;

        public Commands()
        {
            this.context = new IT_Step();
        }
        public void PrintTeachers()
        {
            foreach (var item in context.Teachers)
            {
                Console.WriteLine($"[{item.Id}] [{item.Name}] [{item.Surname}] [{item.Patronymic}] [{item.Birthdate}] [{item.Hiring}] [{item.CountryId}]");
                foreach (var item1 in item.Groups)
                {
                    Console.WriteLine(item1.Name);
                }
                Console.WriteLine();
                foreach (var item1 in item.Departments)
                {
                    Console.WriteLine(item1.Name);
                }
                Console.WriteLine();
                foreach (var item1 in item.Subjects)
                {
                    Console.WriteLine(item1.Name);
                }
                Console.WriteLine();
            }
        }
        public void PrintStudents()
        {
            foreach (var item in context.Students)
            {
                Console.WriteLine($"[{item.Id}] [{item.Name}] [{item.Surname}] [{item.Rating}] [{item.StudAdmission}] [{item.GroupsId}]");
                foreach (var item1 in item.Departments)
                {
                    Console.WriteLine(item1.Name);
                }
                Console.WriteLine();
                foreach (var item1 in item.Subjects)
                {
                    Console.WriteLine(item1.Name);
                }
                Console.WriteLine();
            }
        }

        public void PrintManagers()
        {
            foreach (var item in context.Managers)
            {
                Console.WriteLine($"[{item.Id}] [{item.Name}] [{item.PositionId}]");
            }
        }

        public void PrintDirector()
        {
            foreach (var item in context.Directors)
            {
                Console.WriteLine($"[{item.Id}] [{item.Name}] [{item.PositionId}]");
            }
        }

        public void PrintGroups()
        {
            foreach (var item in context.Groups)
            {
                Console.WriteLine($"[{item.Id,-5}] [{item.Name}]");
            }
        }
        public void AddTeacher()
        {
            PrintTeachers();

            Console.WriteLine("Enter Name Teacher --> ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Surname Teacher --> ");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter Patronymic Teacher --> ");
            string patronymic = Console.ReadLine();

            Console.WriteLine("Enter Hiring Teacher --> ");
            DateTime hiring = DateTime.Parse(Console.ReadLine());

            var teacher = context.Teachers.FirstOrDefault(t => t.Name == name);
            teacher = context.Teachers.FirstOrDefault(t => t.Surname == surname);

            if (teacher == null)
            {
                context.Teachers.Add(new Teachers
                {
                    Name = name,
                    Surname = surname,
                    Patronymic = patronymic,
                    Hiring = hiring
                });
                context.SaveChanges();
                PrintTeachers();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This Teacher is working");
                Console.ResetColor();
            }
        }

        public void AddGroupToTeacherConsole()
        {
            PrintTeachers();

            Console.WriteLine("Print Id Teacher --> ");
            int idT = int.Parse(Console.ReadLine());

            PrintGroups();
            Console.WriteLine("Enter the group Id --> ");
            int idG = int.Parse(Console.ReadLine());

            try
            {
                AddGroupToTeacher(idT, idG);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
        }

        public void AddGroupToTeacher(int idT, int idG)
        {
            var teacher = context.Teachers.FirstOrDefault(t => t.Id == idT);

            if (teacher == null)
            {
                throw new Exception("Teacher not found");
            }

            var group = context.Groups.FirstOrDefault(g => g.Id == idG);

            if (group == null)
            {
                throw new Exception("Teacher not found");
            }

            teacher.Groups.Add(group);
            context.SaveChanges();
        }

        public void DeleteTeacherConsole()
        {
            PrintTeachers();

            Console.WriteLine("Enter Id for delete Teacher --> ");
            int id = int.Parse(Console.ReadLine());

            IT_Step context = new IT_Step();

            var teacher = context.Teachers.FirstOrDefault(t => t.Id == id);

            if(teacher == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Teacher not found");
                Console.ResetColor();
            }
            else
            {
                context.Teachers.Remove(teacher);
                context.SaveChanges();
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Teacher has been dismissed");
                Console.ResetColor();
                PrintTeachers();
            }
        }
        
        public void DeleteTeacher(int idT)
        {

            IT_Step context = new IT_Step();

            var teacher = context.Teachers.FirstOrDefault(t => t.Id == idT);

            if (teacher == null)
            {
                throw new Exception("Teacher not found");
            }
            
            context.Teachers.Remove(teacher);
            context.SaveChanges();
        }
       

        public void DeleteManagerConsole()
        {
            PrintManagers();

            Console.WriteLine("Enter Id for delete Manager --> ");
            int id = int.Parse(Console.ReadLine());

            IT_Step context = new IT_Step();

            var manager = context.Managers.FirstOrDefault(t => t.Id == id);

            if (manager == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Manager not found");
                Console.ResetColor();
            }
            else
            {
                context.Managers.Remove(manager);
                context.SaveChanges();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Manager has been dismissed");
                Console.ResetColor();
                PrintTeachers();
            }

        }
        public void DeleteManager(int idM)
        {

            IT_Step context = new IT_Step();

            var manager = context.Managers.FirstOrDefault(t => t.Id == idM);

            if (manager == null)
            {
                throw new Exception("Manager not found");
            }

            context.Managers.Remove(manager);
            context.SaveChanges();
        }
    }
}
