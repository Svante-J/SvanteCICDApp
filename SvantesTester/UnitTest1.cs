using NUnit.Framework;
using SvanteSarahsApp.Controller;
using SvanteSarahsApp.Utility;

namespace SvantesTester
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void FindUser_IfAdmin()
        {
            // Arrange
           var mocklist = MockData.FillMockList();
            const string name = "admin1";
            const string password = "admin1234";
            //const bool expected = true;

            // Act
            var result = IAccount.FindUser(name, password, mocklist);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void LoggIn()
        {
            Assert.Pass();
        }

    }
}