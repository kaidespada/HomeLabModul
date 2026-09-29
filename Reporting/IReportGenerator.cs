using ElectronicJournal.Models;

namespace ElectronicJournal.Reporting
{
    public interface IReportGenerator
    {
        string Generate(Course course);
    }
}
