namespace Command
{
    public class Client
    {
        public void Run()
        {
            var account = new Account
            {
                Id = 42,
                Balance = 10000
            };
            var command = new WithdrawCommand(account, 5000);
            command.Validate();
            command.Execute();
        }
    }
}