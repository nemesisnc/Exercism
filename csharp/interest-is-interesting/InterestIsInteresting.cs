using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0)
            return 3.213f;
        else if (balance >= 0 && balance < 1000)
            return 0.5f;
        else if (balance >= 1000 && balance < 5000)
            return 1.621f;
        else if (balance >= 5000)
            return 2.475f;
        else
            throw new NotImplementedException();
    }

    public static decimal Interest(decimal balance)
    {
        return (decimal)InterestRate(balance)/100 * balance;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int yearCount = 0;
        decimal currentBalance = balance;

        while (currentBalance <= targetBalance)
        {
            yearCount++;
            currentBalance = AnnualBalanceUpdate(currentBalance);
        };

        return yearCount;
    }
}
