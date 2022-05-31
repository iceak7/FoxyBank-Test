using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FoxyBank.Test
{
    [TestClass]
    public class SubstractBalanceTest
    {
        [TestMethod]
        public void SubstractBalance_PersonalAccount_And_Balance_2500_Substract_5000_Return_False_And_Balance_2500()
        {
            User user = new User("Isak", "Jensen", "Hemlis123", 2001);
            user.BankAccounts.Add(new PersonalAccount(10000));
            user.BankAccounts[0].AccountName = "Personkonto";
            user.BankAccounts[0].CurrencySign = "kr";
            user.BankAccounts[0].AddBalance(2500);

            var actual = user.BankAccounts[0].SubstractBalance(5000);
            var expected = false;

            var actualBalance = user.BankAccounts[0].GetBalance();
            var expectedBalance = 2500;

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedBalance, actualBalance);
        }


        [TestMethod]
        public void SubstractBalance_LoanAccount_And_Balance_2500_Substract_5000_Return_True_And_Balance_Minus2500()
        {
            User user = new User("Isak", "Jensen", "Hemlis123", 2001);
            user.BankAccounts.Add(new LoanAccount(10000));
            user.BankAccounts[0].AccountName = "Lånekonto";
            user.BankAccounts[0].CurrencySign = "kr";
            user.BankAccounts[0].AddBalance(2500);

            var actual = user.BankAccounts[0].SubstractBalance(5000);
            var expected = true;

            var actualBalance = user.BankAccounts[0].GetBalance();
            var expectedBalance = -2500;

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedBalance, actualBalance);
        }


        [TestMethod]
        public void SubstractBalance_Balance_2500_Substract_Minus1000_Return_False_And_Balance_2500()
        {
            User user = new User("Isak", "Jensen", "Hemlis123", 2001);
            user.BankAccounts.Add(new PersonalAccount(10000));
            user.BankAccounts[0].AccountName = "Personkonto";
            user.BankAccounts[0].CurrencySign = "kr";
            user.BankAccounts[0].AddBalance(2500);

            var actual = user.BankAccounts[0].SubstractBalance(-1000);
            var expected = false;

            var actualBalance = user.BankAccounts[0].GetBalance();
            var expectedBalance = 2500;

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedBalance, actualBalance);
        }



        [TestMethod]
        public void SubstractBalance_Balance_2500_Substract_1000_Return_Balance_2500()
        {
            User user = new User("Isak", "Jensen", "Hemlis123", 2001);
            user.BankAccounts.Add(new PersonalAccount(10000));
            user.BankAccounts[0].AccountName = "Personkonto";
            user.BankAccounts[0].CurrencySign = "kr";
            user.BankAccounts[0].AddBalance(2500);
            user.BankAccounts[0].SubstractBalance(1000);

            var actual= user.BankAccounts[0].GetBalance();
            var expected = 1500;

            Assert.AreEqual(expected, actual);
        }


    }
}
