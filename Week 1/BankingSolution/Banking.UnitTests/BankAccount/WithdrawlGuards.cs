﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests.BankAccount
{
    public class WithdrawalGuards
    {
        [Fact]
        public void OverdraftNotAllowed()
        {
            var account = new Account();
            var openingBalance = account.GetBalance();



            account.Withdraw(openingBalance + .01M);



            Assert.Equal(openingBalance, account.GetBalance());
        }
    }
}
