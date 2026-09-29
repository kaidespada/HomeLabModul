using System;
using System.Collections.Generic;

namespace ElectronicJournal.Models
{
    public class Student
    {
        public string Name { get; }

        private readonly List<Grade> _grades = new List<Grade>();
        public IReadOnlyCollection<Grade> Grades => _grades.AsReadOnly();

        public Student(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public void AddGrade(Grade grade)
        {
            if (grade == null) throw new ArgumentNullException(nameof(grade));
            _grades.Add(grade);
        }
    }
}