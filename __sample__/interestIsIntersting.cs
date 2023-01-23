using System;
static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0) {
            return 3.213f;
        } else if (balance < 1000) {
        return 0.5f;
        } else if (balance < 5000) {
        return 1.621f;
        } else {
        return 2.475f;
        }
    }
    public static decimal Interest(decimal balance)
    {
        return Convert.ToDecimal(SavingsAccount.InterestRate(balance)) * 0.01m * balance;
    }
    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return Convert.ToDecimal(SavingsAccount.Interest(balance)) + balance;
    }
    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        decimal currentBalance = balance;
        while (currentBalance < targetBalance) {
            currentBalance += SavingsAccount.Interest(currentBalance);
            years += 1;
        }
        return years;
    }
}
