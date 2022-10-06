using System;
using NUnit.Framework;

namespace School.Test
{
    [TestFixture]
    public class StudentShould
    {

        //check if name is empty string
        [Test]
        public void ThrowArgumentException_When_NameIsEmpty()
        {
            Assert.Throws<ArgumentException>(() => new Student("", 11));
        }

        //check if name is null
        [Test]
        public void ThrowArgumentException_When_NameIsNull()
        {
            Assert.Throws<ArgumentException>(() => new Student(null, 11));
        }

        //check if id > 99 999
        [Test]
        public void ThrowArgumentException_When_IdIsBiggerThan99999()
        {
            Assert.Throws<ArgumentException>(() => new Student("Viktor", 100000));
        }

        //check if id < 10 000
        [Test]
        public void ThrowArgumentException_When_IdIsSmallerThan10000()
        {
            Assert.Throws<ArgumentException>(() => new Student("Viktor", 9999));
            

        }
        //check if id = 10 000
        [Test]
        public void ThrowArgumentException_When_IdIs10000()
        {
            Student newStudent = new Student("Viktor", 10000);
            Assert.IsNotNull(newStudent);
        }

        //check if id = 99 999
        [Test]
        public void ThrowArgumentException_When_IdIs99999()
        {
            Student newStudent = new Student("Viktor", 99999);
            Assert.IsNotNull(newStudent);
        }
    }
}
