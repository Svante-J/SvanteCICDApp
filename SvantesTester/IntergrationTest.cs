using NUnit.Framework;
using SvanteSarahsApp.Controller;
using SvanteSarahsApp.Utility;
using SvantesTester;

namespace SvantesTester
{
    [TestFixture]
    public class IntergrationTest
    {
        [Test]
        public void IntergrationTest_LogginIfAdmin()
        {
            // Arrange
            var mocklist = MockData.FillMockList();
            const string name = "admin1";
            const string password = "admin1234";
            // Act
            var logginSucces = IAccount.FindUser(name, password, mocklist);
       
            
            

            // Assert
            Assert.IsTrue(logginSucces);
            Assert.IsNotNull(LoggedInUser.GetActiveUser());
            Assert.IsTrue(LoggedInUser.GetActiveUser().IsAdmin);
           

        }

       
    }
}
