namespace BankAccountTest
{
    class BankAccount
    {
        public decimal Balance { get; private set; }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient balance.");
            }
            Balance -= amount;
        }
    }

    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void Deposit_ShouldIncreaseBalance_WhenAmountIsPositive()
        {
            var account = new BankAccount();
            account.Deposit(100);

            Assert.AreEqual(100, account.Balance);
        }

        [Test]
        public void Withdraw_ShouldDecreaseBalance_WhenSufficientBalance()
        {
            var account = new BankAccount();
            account.Deposit(100);
            account.Withdraw(50);

            Assert.AreEqual(50, account.Balance);
        }

        [Test]
        public void Withdraw_ShouldThrowException_WhenInsufficientBalance()
        {
            var account = new BankAccount();
            account.Deposit(50);

            Assert.Throws<InvalidOperationException>(() => account.Withdraw(100));
        }
    }

}