﻿//using System;
//using System.Collections.Generic;
//using System.Data.Entity.Migrations;
//using System.Linq;
//using NBAapi.Models;

//namespace NBAapi.Migrations
//{
//    public sealed class PlayerInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ApplicationDbContext>
//    {
//        protected override void Seed(ApplicationDbContext context)
//        {
//            var students = new List<Player>
//            {
//                new Player { FirstMidName = "Carson",   LastName = "Alexander",
//                    EnrollmentDate = DateTime.Parse("2010-09-01") },
//                new Player { FirstMidName = "Meredith", LastName = "Alonso",
//                    EnrollmentDate = DateTime.Parse("2012-09-01") },
//                new Player { FirstMidName = "Arturo",   LastName = "Anand",
//                    EnrollmentDate = DateTime.Parse("2013-09-01") },
//                new Player { FirstMidName = "Gytis",    LastName = "Barzdukas",
//                    EnrollmentDate = DateTime.Parse("2012-09-01") },
                
//            };

//            students.ForEach(s => context.Students.AddOrUpdate(p => p.LastName, s));
//            context.SaveChanges();

//            var departments = new List<Team>
//            {
//                new Department { Name = "English",     Budget = 350000,
//                    StartDate = DateTime.Parse("2007-09-01"),
//                    InstructorID  = instructors.Single( i => i.LastName == "Abercrombie").ID },
//                new Department { Name = "Mathematics", Budget = 100000,
//                    StartDate = DateTime.Parse("2007-09-01"),
//                    InstructorID  = instructors.Single( i => i.LastName == "Fakhouri").ID },
//                new Department { Name = "Engineering", Budget = 350000,
//                    StartDate = DateTime.Parse("2007-09-01"),
//                    InstructorID  = instructors.Single( i => i.LastName == "Harui").ID },
//                new Department { Name = "Economics",   Budget = 100000,
//                    StartDate = DateTime.Parse("2007-09-01"),
//                    InstructorID  = instructors.Single( i => i.LastName == "Kapoor").ID }
//            };
//            departments.ForEach(s => context.Departments.AddOrUpdate(p => p.Name, s));
//            context.SaveChanges();

            
//            //var officeAssignments = new List<OfficeAssignment>
//            //{
//            //    new OfficeAssignment {
//            //        InstructorID = instructors.Single( i => i.LastName == "Fakhouri").ID,
//            //        Location = "Smith 17" },
//            //    new OfficeAssignment {
//            //        InstructorID = instructors.Single( i => i.LastName == "Harui").ID,
//            //        Location = "Gowan 27" },
//            //    new OfficeAssignment {
//            //        InstructorID = instructors.Single( i => i.LastName == "Kapoor").ID,
//            //        Location = "Thompson 304" },
//            //};
//            //officeAssignments.ForEach(s => context.OfficeAssignments.AddOrUpdate(p => p.InstructorID, s));
//            //context.SaveChanges();

//            //AddOrUpdateInstructor(context, "Chemistry", "Kapoor");
//            //AddOrUpdateInstructor(context, "Chemistry", "Harui");
//            //AddOrUpdateInstructor(context, "Microeconomics", "Zheng");
//            //AddOrUpdateInstructor(context, "Macroeconomics", "Zheng");

//            //AddOrUpdateInstructor(context, "Calculus", "Fakhouri");
//            //AddOrUpdateInstructor(context, "Trigonometry", "Harui");
//            //AddOrUpdateInstructor(context, "Composition", "Abercrombie");
//            //AddOrUpdateInstructor(context, "Literature", "Abercrombie");

//        }

//        //void AddOrUpdateInstructor(SchoolContext context, string courseTitle, string instructorName)
//        //{
//        //    var crs = context.Courses.SingleOrDefault(c => c.Title == courseTitle);
//        //    var inst = crs.Instructors.SingleOrDefault(i => i.LastName == instructorName);
//        //    if (inst == null)
//        //        crs.Instructors.Add(context.Instructors.Single(i => i.LastName == instructorName));
//        //}
//    }
//}