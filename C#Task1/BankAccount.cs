using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task1;
internal class BankAccount
{
    public  int AccountNumber  { get; }
    public string AccountHolderName { get; set; }
    public decimal Balance { get; private set; }
    public BankAccount(int _accountNumber , string _accountHolderName , decimal _balance)
    {
        AccountNumber = _accountNumber;
        AccountHolderName = _accountHolderName;
        Balance = _balance;
    }
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposit Done , Balance = {Balance}");
        }
        else
        {
            Console.WriteLine("Amount Should Greater Than Zero");
        }
    }
    public void WithDraw(decimal amount)
    {
        if (amount > 0 && amount < Balance)
        {
            Balance -= amount;
            Console.WriteLine($"WithDraw Done ,  Balance = {Balance}");
        }else if(amount > Balance)
        {
            Console.WriteLine("Balace Not Enough");
        }
        else
        {
            Console.WriteLine("Amount Should Greater Than Zero");
        }
    }


}
