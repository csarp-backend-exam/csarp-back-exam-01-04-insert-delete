using Kreata.Backend.Datas.Entities;
using Kreta.Shared.Enums;
using Kreta.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="János",
                    LastName="Jegy",
                    BirthsDay=new DateTime(2022,10,10),
                    SchoolYear=9,
                    SchoolClass = SchoolClassType.ClassA,
                    EducationLevel="érettségi"
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Szonja",
                    LastName="Stréber",
                    BirthsDay=new DateTime(2021,4,4),
                    SchoolYear=10,
                    SchoolClass = SchoolClassType.ClassB,
                    EducationLevel="érettségi"
                }
            };

            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher
                {
                    Id = Guid.NewGuid(),
                    FirstName = "László",
                    LastName = "Dobos",
                    BirthsDay = new DateTime(2010, 5, 5),
                    IsHeadTeacher = true,
                    IsWoomen = false
                },
                new Teacher
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Márta",
                    LastName = "Diósdy",
                    BirthsDay = new DateTime(2014, 6, 18),
                    IsHeadTeacher = false,
                    IsWoomen = true
                }
            };


            modelBuilder.Entity<Student>().HasData(students);
            modelBuilder.Entity<Teacher>().HasData(teachers);
        }
    }
}
