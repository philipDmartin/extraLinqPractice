using System;
using System.Collections.Generic;
using System.Linq;

namespace extraPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> cohorts = new List<int>() { };

            cohorts.Add(36);
            cohorts.Add(37);
            cohorts.Add(38);
            cohorts.Add(39);
            cohorts.Add(40);

            cohorts.Remove(40);

            foreach (int cohort in cohorts)
            {
                Console.WriteLine(cohort);
            }

            var newerCohorts = cohorts.Where(c =>
            {
                return c < 37;
            });

            foreach (int theCohort in newerCohorts)
            {
                Console.WriteLine("*Cohort*");
                Console.WriteLine(theCohort);
            }

            List<string> students = new List<string>() { };

            students.Add("Philip");
            students.Add("Ryan");
            students.Add("Ben");

            foreach (string student in students) { }

            var allStudents = new List<Student> { };
            var philip = new Student()
            {
                Name = "philip",
                GPA = 2.2
            };

            allStudents.Add(philip);

            var Ryan = new Student()
            {
                Name = "Ryan",
                GPA = 2.4
            };

            allStudents.Add(Ryan);

            var Ben = new Student()
            {
                Name = "Ben",
                GPA = 1.8
            };

            allStudents.Add(Ben);

            foreach (Student theStudent in allStudents) { }
            foreach (Student theStudent in allStudents) { }

            var studentByName = allStudents.OrderBy(s =>
            {
                return s.Name;
            });

            foreach (Student theStudent in allStudents)
            {
                Console.WriteLine("*Student*");
                Console.WriteLine(theStudent.Name);
            }

            var topStudents = allStudents.Where(s =>
                {
                    return s.GPA >= 2.0;
                });

            foreach (Student theStudent in allStudents)
            {
                Console.WriteLine("*Student GPA*");
                Console.WriteLine(theStudent.GPA);
            }
        }
    }
}
