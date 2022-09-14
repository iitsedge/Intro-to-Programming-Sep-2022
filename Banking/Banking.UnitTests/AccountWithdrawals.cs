using Banking.Domain;

namespace Banking.UnitTests;
public class AccountWithdrawals
{
    private readonly BankAccount _account;
    private readonly decimal _openingBalance;

    public AccountWithdrawals()
    {
        _account = new BankAccount();
        _openingBalance = _account.GetBalance();
    }

    [Fact]
    public void WithdrawingMoneyDecreasesBalance()
    {
        var openingBalance = _openingBalance;
        var amountToWithdraw = 10M;

        _account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance - amountToWithdraw, _account.GetBalance());
    }

    [Fact]
    public void UsersCanWithdrawFullBalance()
    {
        var account = new BankAccount();

        account.Withdraw(account.GetBalance());

        Assert.Equal(0, account.GetBalance());
    }

    [Fact]
    public void OverdraftDoesNotDecreaseBalance()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToWithdraw = openingBalance + .01M;

        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance, account.GetBalance());
    }
}