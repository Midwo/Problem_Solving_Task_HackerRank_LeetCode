using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2043
    {
        ////(2043.) Simple Bank System (MEDIUM)
        public class Bank
        {
            ////3ms, Beats: 100.00%
            
            private long[] _balance;
            private int _countAccount;
     
            public Bank(long[] balance)
            {
                _balance = balance;
                _countAccount = balance.Length;
            }

            public bool Transfer(int account1, int account2, long money)
            {
                if(account1 <= _countAccount && account2 <= _countAccount && _balance[account1 - 1] >= money)
                {
                    _balance[account1-1] -= money;
                    _balance[account2-1] += money;
                    return true;
                }
                return false;
            }

            public bool Deposit(int account, long money)
            {
                if (account <= _countAccount) 
                { 
                    _balance[account-1] += money;
                    return true;
                }
                return false;
            }

            public bool Withdraw(int account, long money)
            {
                if(account <= _countAccount && _balance[account-1] >= money)
                {
                    _balance[account-1] -= money;
                    return true;
                }
                return false;
            }
        }
    }
}
