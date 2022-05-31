using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FoxyBank.Test
{
    [TestClass]
    public class AuthenticationTest
    {
        [TestMethod]
        public void Authentication_Login_Success_Return_True()
        {
            User user = new User("Isak", "Jensen", "Hemlis123", 2001);

            var expected = true;
            var actual = user.Authentication("Hemlis123", 2001);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Authentication_Wrong_Password_Login_Unsuccessful_Return_False()
        {
            User user = new User("Isak", "Jensen", "Hemlis123", 2001);

            var expected = false;
            var actual = user.Authentication("Hemlis12", 2001);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Authentication_Wrong_UserId_Login_Unsuccessful_Return_False()
        {
            User user = new User("Isak", "Jensen", "Hemlis123", 2001);

            var expected = false;
            var actual = user.Authentication("Hemlis123", 2002);

            Assert.AreEqual(expected, actual);
        }

    }
}
