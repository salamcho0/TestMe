using System;
using System.Collections.Generic;
using System.Text;
using AutoFixture;

namespace School.NUnit.UnitTests.Factories
{
    public static class CourseFactory
    {
        public static Course CreatePopulatedCourse(int numberOfStudents = 30, string defaultStudentName = "Viktor")
        {
            //creating an instance of autofixture - OS library for generating strings/numbers 
            Fixture fixture = new Fixture();
            //creating a course object
            Course course = new Course();
            
            for (int i = 0; i < 30; i++)
            {
                //generate random string for the name +fixture so that it can be always unique
                string studentName = defaultStudentName + fixture.Create<string>();
                //adding the student to the course
                course.JoinCourse(new Student($"Viktor{i}", 10000 + i));
            }

            return course;
        }
    }
}
