using System;
using ElectronicJournal.Models;
using ElectronicJournal.Reporting;

namespace ElectronicJournal.Services
{
    public class ReportPrinter
    {
        private readonly IReportGenerator _generator;

        public ReportPrinter(IReportGenerator generator)
        {
            _generator = generator ?? throw new ArgumentNullException(nameof(generator));
        }

        public void Print(Course course)
        {
            Console.WriteLine(_generator.Generate(course));
        }
    }
}
