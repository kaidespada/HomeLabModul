using System;
using ElectronicJournal.Models;
using ElectronicJournal.Reporting;
using ElectronicJournal.Services;

namespace ElectronicJournal
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Course csharpCourse = new Course("Программирование на C#");

				Student student1 = new Student("Чепрасов");
				student1.AddGrade(new Grade(5));
				student1.AddGrade(new Grade(4));

				Student student2 = new Student("Иванов");
				student2.AddGrade(new Grade(3));

				csharpCourse.EnrollStudent(student1);
				csharpCourse.EnrollStudent(student2);

				// 1Вывод обычного текстового отчета
				var consolePrinter = new ReportPrinter(new ConsoleReportGenerator());
				consolePrinter.Print(csharpCourse);

				Console.WriteLine();

				// Вывод JSON отчета
				var jsonPrinter = new ReportPrinter(new JsonReportGenerator());
				jsonPrinter.Print(csharpCourse);
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Ошибка: {ex.Message}");
			}

			Console.ReadLine();
		}
	}
}
