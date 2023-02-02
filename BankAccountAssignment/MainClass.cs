using System;





class Account
{
    private static int number = 101;
    private int _accountNumber;
    private string _customerName;
    private int _balance;
    public Account(string name, int amount)
    {
        this._accountNumber = number++;
        this._customerName = name;
        this._balance = amount;
    }
    public int Balance { get { return this._balance; } }
    public int AccountNumber { get { return this._accountNumber; } }





    public string AccountSummary()
    {
        return String.Format("Account Number : {0} \n Customer Name : {1} \n Account Balance : {2}", this._accountNumber, this._customerName, this._balance);

    }
}

class MainClass
{
    static int count = 0;
   static Account[] account = new Account[10];
    static Account SearchAccount(int accountNo)
    
    {
        for (int i = 0; i <count; i++)
        {
            if (account[i].AccountNumber==accountNo)

            {
                return account[i];
            }

        }
        return null;

    }
    static void Main()
    {
        Account[] account = new Account[10];
        byte count = 0, option;
        char choice = 'y';
        string name;
        int amount;
        Account obj = null;
        Console.WriteLine("What do u want to Do \n \n 1.Create New Account \n 2. Transaction in Existing Acoount\n 3.Print account summary\n 4.Exit ");
        do
        {
            Console.WriteLine("What do u want to Do");
            option = byte.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("Enter Customer Name :");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter Initial Balance:");
                        amount = int.Parse(Console.ReadLine());
                        account[count++] = new Account(name, amount);
                        Console.WriteLine("Account As been Successfully Created \n Ur Account number is: {0}", account[count - 1].AccountNumber);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter Account Number: ");
                        int AccountNumber = int.Parse(Console.ReadLine()); 
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine(account[i].AccountSummary());
                        }
                        break;
                    }
                case 3:
                    Console.WriteLine("Thank You");
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine("Continue?(y/n)");
            choice = char.Parse(Console.ReadLine());
        } while (choice == 'Y' || choice == 'y');
    }
}










