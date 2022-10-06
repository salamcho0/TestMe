using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using School.NUnit.UnitTests.Factories;

namespace School.NUnit.UnitTests.CourseTest
{
    [TestFixture]
    public class LeaveCourseShould
    {
        [Test]
        public void ThrowArgumentException_When_NoStudentIsMatched()
        {
            Course course = CourseFactory.CreatePopulatedCourse();


            Assert.Throws<ArgumentException>(() => course.LeaveCourse("Viktor"));
        }

        [Test]
        //public void ThrowArgumentException_When_ListIsEmpty()
        //{
        //    Course course = new Course();

        //    ArgumentException argumentException = Assert.Throws<ArgumentException>(course.GetEnrolledStudentCount());
        //}
    }
}
