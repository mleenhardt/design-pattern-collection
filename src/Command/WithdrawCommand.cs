using System;
using System.ComponentModel.DataAnnotations;

namespace Command
{
    /// <summary>
    /// An <see cref="ICommand"/> that withdraws money from an <see cref="Account"/>. 
    /// </summary>
    public class WithdrawCommand : ICommand
    {
        private readonly Account _account;
        private readonly decimal _withdrawnAmount;

        public WithdrawCommand(Account account, decimal withdrawnAmount)
        {
            if (account == null)
            {
                throw new ArgumentNullException("account");
            }

            if (withdrawnAmount <= 0)
            {
                throw new ArgumentOutOfRangeException("withdrawnAmount");
            }

            _account = account;
            _withdrawnAmount = withdrawnAmount;
        }

        public void Validate()
        {
            if (_withdrawnAmount > _account.Balance)
            {
                throw new ValidationException("It's not possible to withdraw an amount that exceeds the balance of an account.");
            }
        }

        public void Execute()
        {
            Console.WriteLine("WithdrawCommand executing");
            _account.Balance -= _withdrawnAmount;
            Console.WriteLine("Account {0} balance set to {1}", _account.Id, _account.Balance);
        }

        public void Undo()
        {
            Console.WriteLine("WithdrawCommand undoing");
            _account.Balance += _withdrawnAmount;
            Console.WriteLine("Account {0} balance set to {1}", _account.Id, _account.Balance);
        }
    }
}