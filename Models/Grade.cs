using System;

namespace ElectronicJournal.Models
{
    public class Grade
    {
        public int Value { get; }

        public Grade(int value)
        {
            if (value < 1 || value > 5)
            {
                throw new ArgumetExpection("ќценка должна быть в диапозоне от 1 до 5.")
            }
            Value = value;
        }
    }
}