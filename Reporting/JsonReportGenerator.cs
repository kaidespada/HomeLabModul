using System.Collections.Generic;
using ElectronicJournal.Models;

namespace ElectronicJournal.Reporting
{
    public class JsonReportGenerator : IReportGenerator
    {
        public string Generate(Course course)
        {
            var items = new List<string>();
            foreach (var student in course.Students)
            {
                var gradesList = new List<int>();
                foreach (var g in student.Grades) gradesList.Add(g.Value);
                string gradesStr = string.Join(", ", gradesList);

                items.Add($"{{\"{student.Name}\": [{gradesStr}]}}");
            }

            return $"{{\"{course.Title}\": [{string.Join(", ", items)}]}}";
        }
    }
}
