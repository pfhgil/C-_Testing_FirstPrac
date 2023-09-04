using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PasswordChecking;

namespace PasswordCheckingTests
{
    [TestClass]
    public class PasswordCheckingTests
    {
        [TestMethod]
        public void GetPasswordStrength_HasDigits_1Point()
        {
            string password = "1";

            int expectedPoints = 1;
            int actualPoints = PasswordChecker.GetPasswordStrength(password);
            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [TestMethod]
        public void GetPasswordStrength_HasDigitsHasLowercaseLetters_2Points()
        {
            string password = "1d";

            int expectedPoints = 2;
            int actualPoints = PasswordChecker.GetPasswordStrength(password);
            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [TestMethod]
        public void GetPasswordStrength_HasDigitsHasLowercaseLettersUppercaseLetters_3Points()
        {
            string password = "1dS";

            int expectedPoints = 3;
            int actualPoints = PasswordChecker.GetPasswordStrength(password);
            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [TestMethod]
        public void GetPasswordStrength_HasDigitsHasLowercaseLettersUppercaseLettersSpecialLetters_4Points()
        {
            string password = "1dS#";

            int expectedPoints = 4;
            int actualPoints = PasswordChecker.GetPasswordStrength(password);
            Assert.AreEqual(expectedPoints, actualPoints);
        }

        [TestMethod]
        public void GetPasswordStrength_HasDigitsHasLowercaseLettersUppercaseLettersSpecialLettersLongerThan7Letters_5Points()
        {
            string password = "";

            int expectedPoints = 5;
            int actualPoints = PasswordChecker.GetPasswordStrength(password);
            Assert.AreEqual(expectedPoints, actualPoints);
        }
    }
}
