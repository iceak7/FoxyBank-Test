﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FoxyBank
{
    public abstract class BankAccount
    {
        protected decimal Balance { get; set; }
        public int AccountNr { get; set; }
        public string AccountName { get; set; }
        public string CurrencySign { get; set; }

        public decimal GetBalance()
        {
            return Balance;
        }

        public void AddBalance(decimal sumToAdd)
        {
            
            if(sumToAdd>0) Balance += sumToAdd;
        }

        public bool SubstractBalance(decimal sumToSubstract)
        {
            if ( sumToSubstract>0 &&( this.Balance >= sumToSubstract | this is LoanAccount ))
            {
                Balance -= sumToSubstract;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
