using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests.BankAccount
{
    public class MakingWithdrawels
    {
        [Fact]
        public void MakingAWithdrawlDecreasesTheBalance()
        {
            // Given 
            // If I have an account and I want to deposit 100
            Account account = new Account();
            decimal openingBalance = account.GetBalance(); // Query
            decimal amountToWithdrawl = 100M;



            // When - I do the deposit
            account.Withdraw(amountToWithdrawl); // "Command"



            // Then - I can verify it worked if the new balance is 100 more than the balance
            //        was before.
            Assert.Equal(openingBalance - amountToWithdrawl, account.GetBalance());
        }
    }
}
