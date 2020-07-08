using System;
using Xunit;
using static ATM.Program;

namespace XUnitTestLab2
{
    public class UnitTest1
    {
     
            [Theory]
            [InlineData(300, 50, 250)]
            [InlineData(100, 100, 0)]
            public void PositiveWithdrawl(decimal Balance, decimal amount, decimal expected)
            {
            balance = Balance;
                Withdraw(amount);
                Assert.Equal(expected, balance);
            }

            [Theory]
            [InlineData(300, 150, 250)]
            [InlineData(100, 10, 0)]
            public void NegativeWithdrawl(decimal Balance, decimal amount, decimal expected)
            {
                balance = Balance;
                Withdraw(amount);
                Assert.NotEqual(expected, balance);
            }

            [Theory]
            [InlineData(300, 150, 450)]
            [InlineData(100, 10, 110)]
            public void PositiveDeposit(decimal Balance, decimal amount, decimal expected)
            {
                balance = Balance;
                Deposit(amount);
                Assert.Equal(expected, balance);
            }


            [Theory]
            [InlineData(300, 150, 250)]
            [InlineData(100, 10, 0)]
            public void NegativeDeposit(decimal Balance, decimal amount, decimal expected)
            {
                balance = Balance;
                Deposit(amount);
                Assert.NotEqual(expected, balance);
            }
    }
}
