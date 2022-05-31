using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FoxyBank.Test
{
    [TestClass]
    public class AddBalanceTest
    {
        [TestMethod]
        public void AddBalance_5000_GetBalance_Return_5000()
        {
            User user = new User("Isak", "Jensen", "Hemlis123", 2001);
            user.BankAccounts.Add(new PersonalAccount(10000));
            user.BankAccounts[0].AccountName = "Personkonto";
            user.BankAccounts[0].CurrencySign = "kr";

            user.BankAccounts[0].AddBalance(5000);
            var actual = user.BankAccounts[0].GetBalance();
            var expected = 5000;

            Assert.AreEqual(expected, actual);


        }


        [TestMethod]
        public void AddBalance_Minus5000_GetBalance_Return_0()
        {
            User user = new User("Isak", "Jensen", "Hemlis123", 2001);
            user.BankAccounts.Add(new PersonalAccount(10000));
            user.BankAccounts[0].AccountName = "Personkonto";
            user.BankAccounts[0].CurrencySign = "kr";

            user.BankAccounts[0].AddBalance(-5000);
            var actual = user.BankAccounts[0].GetBalance();
            var expected = 0;

            Assert.AreEqual(expected, actual);


        }
    }
}
