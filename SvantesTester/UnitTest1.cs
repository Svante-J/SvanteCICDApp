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
        public void GetNextID()
        {
            var expected = 1;

            var mocklist = MockData.FillMockList();
            var result = mocklist[0].ID;
            

            Assert.AreEqual(expected, result);
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
        public void FindUser_IfUser()
        {
            // Arrange
            var mocklist = MockData.FillMockList();
            const string name = "ulla";
            const string password = "mypassword1234";
            //const bool expected = true;

            // Act
            IAccount.FindUser(name, password, mocklist);
            

            // Assert
            Assert.IsFalse(LoggedInUser.ActiveUser.IsAdmin);
        }
        [Test]
        public void FindUser_IfNotRegisterd()
        {
            // Arrange
            var mocklist = MockData.FillMockList();
            const string name = "mrNotRegisterd";
            const string password = "admin1234";
            //const bool expected = true;

            // Act
            var result = IAccount.FindUser(name, password, mocklist);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void FillMockList_Count()
        {
            var expected = 2;

            var result = MockData.FillMockList();

            Assert.AreEqual(result.Count, expected);
        }

    }
}