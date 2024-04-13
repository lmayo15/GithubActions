using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above

        [Test]
        public void Power_Valid_LaurenMayo()
        {
            Assert.AreEqual(25, Program.Power("5", "2"));
            Assert.AreEqual(-216, Program.Power("-6", "3"));
            Assert.AreEqual(64, Program.Power("4", "3"));
        }

        [Test]
        public void Multiply_Valid_LaurenMayo()
        {
            Assert.AreEqual(4, Program.Multiply("1", "4"));
            Assert.AreEqual(18, Program.Multiply("3", "6"));
            Assert.AreEqual(25, Program.Multiply("5", "5")); 
        }

        [Test]
        public void Divide_Valid_LaurenMayo()
        {
            Assert.AreEqual(6, Program.Divide("12", "2"));
            Assert.AreEqual(3, Program.Divide("27", "9"));
            Assert.AreEqual(8, Program.Divide("48", "6"));
        }
        
    }
}
