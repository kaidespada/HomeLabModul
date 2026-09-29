using System.Collections.Generic;
using System.Text;
using ElectronicJournal.Models;

namespace ElectronicJournal.Reporting
{
    public class HtmlReportGenerator : IReportGenerator
    {
        public string Generate(Course course)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"<h2>Курс: {course.Title}</h2>");
            sb.AppendLine("<ul>");

            foreach (var student in course.Students)
            {
                var gradesList = new List<int>();
                foreach (var g in student.Grades) gradesList.Add(g.Value);
                string gradesStr = gradesList.Count > 0 ? string.Join(", ", gradesList) : "нет оценок";

                sb.AppendLine($"  <li>{student.Name}: {gradesStr}</li>");
            }

            sb.AppendLine("</ul>");
            return sb.ToString();
        }
    }
}
