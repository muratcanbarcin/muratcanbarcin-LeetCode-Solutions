public class Bank
{
    private long[] _balance;
    private int _n;

    public Bank(long[] balance)
    {
        _balance = balance;
        _n = balance.Length;
    }

    private bool IsValidAccount(int account)
    {
        return account >= 1 && account <= _n;
    }

    public bool Transfer(int account1, int account2, long money)
    {
        if (!IsValidAccount(account1) || !IsValidAccount(account2))
        {
            return false;
        }

        if (_balance[account1 - 1] >= money)
        {
            _balance[account1 - 1] -= money;
            _balance[account2 - 1] += money;
            return true;
        }
        return false;
    }

    public bool Deposit(int account, long money)
    {
        if (!IsValidAccount(account))
        {
            return false;
        }

        _balance[account - 1] += money;
        return true;
    }

    public bool Withdraw(int account, long money)
    {
        if (!IsValidAccount(account))
        {
            return false;
        }

        if (_balance[account - 1] >= money)
        {
            _balance[account - 1] -= money;
            return true;
        }
        return false;
    }
}

/**
 * Your Bank object will be instantiated and called as such:
 * Bank obj = new Bank(balance);
 * boolean param_1 = obj.transfer(account1,account2,money);
 * boolean param_2 = obj.deposit(account,money);
 * boolean param_3 = obj.withdraw(account,money);
 */