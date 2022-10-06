using System;
using System.Collections.Generic;
using System.Linq;

namespace School
{
    public class School
    {
        //creating private list of student objs
        private List<Student> _students;
        //creating private int for tracing the id in order not to repeat it for any student
        private int _currentId;

        //basic constructor
        public School()
        {
            _students = new List<Student>();
            //when schoold obj is created the Id will start from 10 000
            _currentId = 10000;
        }

        //method for adding students to the list of students with argument name of the student
        public void AddStudents(string name)
        {

            /* identical manual check for Link.Any();
             * if (IsThereAnyStudentWithName(string name))
            {
                throw new ArgumentException($"Student with name = {name} already exists.");
            }
             * 
             */


            // check if there are records/students with the same name    
            if (_students.Any(x => x.Name.Equals(name))) 
            {
                //throw an argument error
                throw new ArgumentException($"Student with name = {name} already exists."); 
            }

            //creating new student with unique id and after that increment _currentId with +1
            Student student = new Student(name, _currentId++);
            //add student to the list of students
            _students.Add(student);
        }


        //if you have to write your own List.Any()....
                /*
        private bool IsThereAnyStudentWithName(string name)
        {
            foreach (Student student in _students)
            {
                if(student.Name == name)
                {
                    return true;
                }
            }

            return false;
        }
        */

    }
}
