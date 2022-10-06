using System;
using NUnit.Framework;
using School.NUnit.UnitTests.Factories;

namespace School.Test
{
    [TestFixture]
    public class JoinCourseShould
    {
        [Test]
        public void ThrowArgumentException_When_31StudentsJoined()
        {


            //Arrange
            //creating 30 students
            //Course course = new Course();
            //for (int i = 0; i < 30; i++)
            //{
            //    course.JoinCourse(new Student($"Viktor{i}", 10000 + i));
            //}

            //static method is called by classname.methodname
            Course course = CourseFactory.CreatePopulatedCourse();


            //Act + Assert
            //checking if a 31 student is passed will an argumentexception be thrown
            Assert.Throws<ArgumentException>(() => course.JoinCourse(new Student($"Viktor31", 10031)));
        }
    }
}
