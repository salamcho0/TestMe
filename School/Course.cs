using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Course
    {
        //create a private list of students
        private List<Student> _students = new List<Student>();

        //method for adding a student to a course
        public void JoinCourse(Student student)
        {
            //check if there are more than 30 students in the course
            if(_students.Count >= 30)
            {
                throw new ArgumentException("No more students are allowed to join");
            }
            
            //adding the student to the list successfully
            _students.Add(student);

        }

        //method for removing a student from a course
        public void LeaveCourse(string name)
        {
            //check if there is isn't student with the name passed
            if(!_students.Any(x => x.Name.Equals(name)))
            {
                //throw the exception if there are NO student with such name
                throw new ArgumentException($"Student with the name {name} cannot be found.");
            }

            //check if there are any stidents in the course (my additional check)
            if(_students.Count > 0)
            {
                //remove fom the list the record whose name is matched with the argument name
                _students.Remove(_students.First(x => x.Name.Equals(name))); //.First will return the object cuz '.Remove' accepts only objects
            }
        }

        //some rubbish code form the presentation to get the number of the students in the course
        public int GetEnrolledStudentCount()
        {
            return _students.Count();
        }
    }
}
