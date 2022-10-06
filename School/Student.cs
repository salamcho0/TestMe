using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
   
    public class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Student(string name, int id)
        {
            if(string.IsNullOrEmpty(name) || id < 10000 || id > 99999)
            {
                throw new ArgumentException("Invalid input!");
            }

            Name = name;
            Id = id;

        }

    }
}
