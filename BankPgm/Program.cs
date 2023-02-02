using System;
class Accounts
{
     int AccNo;private double Balance;
    private string CustName,AccType;
    public Accounts(int accNo, int balance, string custName, string accType)
    {
        AccNo = accNo;
        Balance = balance;
        CustName = custName;
        AccType = accType;
    }
    public double Deposit(int Amount)
    {
        Balance += Amount;
        return Balance;
    }
    public double WithDraw(int Amount)
    {
        Balance -= Amount;
        return Balance;
    }
    public string AccountSummary()
    {
        return string.Format("Account Name: {0} Account Number: {1}Balance:{2} ", CustName, AccNo, Balance);
    }
        
}
class MainClass
{
   
        Accounts[] Acc = new Accounts[10];
        static String AccName; static int AccNo; static double Balance;   static int count;
        public static void AddAccount()
        {
             Console.WriteLine("Enter Account Number: ");
             AccNo =int.Parse(Console.ReadLine());
             Console.WriteLine("Enter Account Name: ");
            AccName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the initial Amount to be added: ");


        }


            
    }
