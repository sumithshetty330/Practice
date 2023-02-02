﻿      using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ExceptionBank
{
        class Account
        {
            int _accountNumber;
            private String _customerName;
            private double _balance;
            private String _acc_type;

            public double Deposit(double Amount)
            {
                _balance = _balance + Amount;
                return _balance;
            }
            public double Withdraw(double Amount)
            {
                if (_balance>=Amount)
                {
                _balance = _balance - Amount;

                }
            else
            {
                throw new Transaction("Insufficeint balance");  
            }
               
                return _balance;
            }
            public string AccountSummary()
            {
                return string.Format("Account number: {0}\n Account Name:{1}\n Balance : {2}", _accountNumber, _customerName, _balance);

            }

            public Account(int acc_no, String _cname, double initialAmount, string account_type)
            {
                this._accountNumber = acc_no;
                this._customerName = _cname;
                this._balance = initialAmount;
                this._acc_type = account_type;
            }
            public double BalanceEnquiry
            {
                get
                {
                    return _balance;
                }
            }
            public int Accountno
            {
                get
                {
                    return this.Accountno;
                }
            }


        }


        class MainClass
        {
            static Account[] acc = new Account[10];
            static string name, acc_type;
            static double balance;
            static int counter;
            static int acc_no;
            public static void AddAccount()
            {
                Console.WriteLine("Enter Account Number");
                acc_no = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the account holders name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter the initial amount of the account");
                balance = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the account type:");
                acc_type = Console.ReadLine();

            }
            public static int searchAccount(int accNo)
            {
                for (int i = 0; i < counter; i++)
                {
                    if (acc[i].Accountno == accNo)
                    {
                        return i;
                    }
                }
                return 0;
            }
            static void Main()
            {
                float amount;
                char ch;
                do
                {
                    Console.WriteLine("1. Add Account\n2.Transaction Type\n3.Account Summary\n4.Exit \n");
                    int opt = int.Parse(Console.ReadLine());
                    switch (opt)
                    {
                        case 1:
                            AddAccount();
                            acc[counter++] = new Account(acc_no, name, balance, acc_type);
                            Console.WriteLine("Account created Succesfully!");
                            break;
                        case 2:
                            Console.WriteLine("Enter the account number");
                            int a = int.Parse(Console.ReadLine());
                            if (searchAccount(a) != null)
                            {
                                int i = searchAccount(a);
                                Console.WriteLine("1.Deposit\n2. Withdraw\n3.BalanceEnquiry\n4.Account Summary");
                                int option = int.Parse(Console.ReadLine());
                                switch (option)
                                {
                                    case 1:
                                        Console.WriteLine("Enter the amount to deposit");
                                        amount = float.Parse(Console.ReadLine());
                                        acc[i].Deposit(amount);
                                        break;
                                    case 2:
                                        Console.WriteLine("Enter the amount to withdraw");
                                        amount = float.Parse(Console.ReadLine());
                                        acc[i].Withdraw(amount);
                                        break;
                                    case 3:
                                        Console.WriteLine("Balance is " + acc[i].BalanceEnquiry);
                                        break;
                                    case 4:
                                        Console.WriteLine(acc[i].AccountSummary());
                                        break;

                                }

                            }
                            else
                            {
                                Console.WriteLine("Please enter valid account Number");
                            }

                            break;
                        case 3:
                            for (int i = 0; i < counter; i++)
                            {
                                Console.WriteLine(acc[i].AccountSummary());
                                Console.WriteLine("------------------------------");
                            }
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                    }
                    Console.WriteLine("Do you want to continue?(Y|N)");
                    ch = Console.ReadLine()[0];
                } while (ch == 'Y' || ch == 'y');
            }

        }

    }






