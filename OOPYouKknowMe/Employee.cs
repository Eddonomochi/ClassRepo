using System;
using System.Collections.Generic;
using System.Text;

namespace OOPYouKknowMe
{
    public class Employee
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (value.Length < 2)
                {
                    Console.WriteLine("invalid name");
                    return;
                }
                _name = value;
            }
        }

        public Employee()
        {

        }

        public Employee(string name)
        {
            _name = name;
        }

        public double HourlyRate { get; set; }

        // Auto Property
        public int HoursWorked { get; set; }
        public string JobTitle { get; set; }


        private string _jobTitle;
        public string GetJobTitle()
        {
            return _jobTitle;
        }

        public void SetJobTitle(string value)
        {
            _jobTitle = value;
        }


        public double WeeklyIncome => HoursWorked * HourlyRate;

    }
}
