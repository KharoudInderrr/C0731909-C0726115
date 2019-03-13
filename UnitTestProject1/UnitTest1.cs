﻿using System;
using Bankaccounts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class BankTests
    {
        [TestMethod]
        public void Debit_Withvalidamount_UpdatesBalance()
        {
            //Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            //Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.01, "Account not debited correctly");

             [TestMethod]
             [ExpectedException(typeof(ArgumentOutOfRangeException))]
             public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            //Act
            account.Debit(debitAmount);

            //Assert is handled by the ExpectedException  attribute on the test method



            
        }



        }
    }
}
