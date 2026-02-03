using System;
using NUnit.Framework;

namespace NUnit_Assessment;
[TestFixture]
public class Tests
{
    [Test]
    public void Test_Deposit_ValidAmount()
    {
        Program account = new Program(1000m);
        account.Deposit(500m);

        Assert.That(1500m, Is.EqualTo(account.Balance));
    }

    [Test]
    public void Test_Deposit_NegativeAmount()
    {
        Program account = new Program(1000m);

        var ex = Assert.Throws<Exception>(() => account.Deposit(-200m));
        Assert.That(ex.Message, Is.EqualTo("Deposit amount cannot be negative"));
    }

    [Test]
    public void Test_Withdraw_ValidAmount()
    {
        Program account = new Program(1000m);
        account.Withdraw(400m);

        Assert.That(600m, Is.EqualTo(account.Balance));
    }

    [Test]
    public void Test_Withdraw_InsufficientFunds()
    {
        Program account = new Program(500m);

        var ex = Assert.Throws<Exception>(() => account.Withdraw(800m));
        Assert.That(ex.Message, Is.EqualTo("Insufficient funds."));
    }
}
