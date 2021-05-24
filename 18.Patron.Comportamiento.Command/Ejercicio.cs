using System;

namespace Coding.Exercise
{
    public enum Action
    {
        Deposit,
        Withdraw
    }

    public class Command
    {
        public Action BalanceAction;
        public int Amount;
        public bool Success;
    }

    public class BankAccount
    {
        public int Balance { get; set; }

        public void Execute(Command c)
        {
            c.Success = true;
            
            if (c.BalanceAction == Action.Deposit)
                Balance += c.Amount;
            else if (c.BalanceAction == Action.Withdraw && Balance > c.Amount)
                Balance -= c.Amount;
            else
                c.Success = false;
        }
    }
}
