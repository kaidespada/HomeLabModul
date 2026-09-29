using System;
using System.Collections.Generic;

namespace ElectronicJournal.Models;

namespace ElectronicJoutnal.Models
{
    public class Course
    {
        public string Title { get;  }

        private readonly List<Student> _students = new List<Student>();
        public IReadOnlyCollection<Student> Students => _students.AsReadOnly();

        public Course(string title)
        {
            Tittle = title ?? throw new ArgumentNullExpection(nameof(title));
        }

        public void EnrollStudent(Student student)
        {
            if ( student == null) throw new ArgumentNullException(nameof(student));
            if (!_students.Contains(student))
            {
                _students.Add(student);
            }
        }
    }
}