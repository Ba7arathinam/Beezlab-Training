using System;
using System.Collections.Generic;


namespace BankApplication
{
    class customer
    {
        public int age, amount, balance, deposit;
        public int initialamt;
        public string custnam, custid, gender, dept, passwrd;
    }
    class bank
    {
        public static void Main(String[] args)
        {
            List<customer> customerList = new List<customer>();
            int next = 0;
            do
            {
                Console.WriteLine("Enter 1 For Create Account");
                Console.WriteLine("Enter 2 For Withdraw Amount");
                Console.WriteLine("Enter 3 For Deposit Amount");
                Console.WriteLine("Enter 4 For Change Password");
                List<customer> customerWithdraw = new List<customer>();
                List<customer> customerdeposit = new List<customer>();
                List<customer> changepassword = new List<customer>();
                int open = Convert.ToInt32(Console.ReadLine());
                switch (open)
                {
                    case 1:
                        CreateCustomer(customerList);
                        break;
                    case 2:
                        WithdrawAmount(customerList);
                        break;
                    case 3:
                        DepositAmount(customerList);
                        break;
                    case 4:
                        ChangePassword(customerList);
                        break;
                    case 5:
                        break;
                }
                Console.WriteLine("Do You want to Enter Another Customer Details press 0");
                next = Convert.ToInt32(Console.ReadLine());
            } while (next == 0);

        }
        private static void CreateCustomer(List<customer> customerList)


        {
            customer NewCustomer = new customer();
            string custnam = " ";
            Console.WriteLine("Enter the Customername:");
            NewCustomer.custnam = Console.ReadLine();
            int Custid = 0;
            Console.WriteLine("Enter The CustomerID:");
            NewCustomer.custid = Console.ReadLine();
            int age = 0;
            Console.WriteLine("Enter Customer age:");
            NewCustomer.age = Convert.ToInt32(Console.ReadLine());
            string gender = " ";
            Console.WriteLine("Enter the Customer gender:");
            NewCustomer.gender = Console.ReadLine();
            string passwrd = " ";
            Console.WriteLine("Enter your Password:");
            NewCustomer.passwrd = Console.ReadLine();
            Console.WriteLine("Customer Name:" + NewCustomer.custnam);
            Console.WriteLine("Customer ID:" + NewCustomer.custid);
            Console.WriteLine("Age:" + NewCustomer.age);
            Console.WriteLine("Gender:" + NewCustomer.gender);
            Console.WriteLine("Password:" + NewCustomer.passwrd);
            customerList.Add(NewCustomer);
            Console.WriteLine("The List Of Customers:" + customerList.Count);



        }
        private static void WithdrawAmount(List<customer> customerwithdraw)
        {
            int initialamt = 0;
            int withdraw = 0;
            int amount = 1500;
            int balance = 0;
            string custid = "";
            Console.WriteLine("Enter Withdraw Amount:");
            withdraw = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Customer ID:");
            custid = Console.ReadLine();
            for (int i = 0; i < customerwithdraw.Count; i++)
            {
                if (customerwithdraw[i].custid == custid)
                {
                    if (withdraw > 1500)
                    {
                        Console.WriteLine("Insufficient Balance");
                    }
                    if (withdraw > 500)
                    {
                        Console.WriteLine("Collect Your Cash");
                    }
                    if (withdraw < 500)
                    {
                        Console.WriteLine("Please Enter Amount Above 500");
                    }
                    else
                    {
                        balance = amount - withdraw;
                        Console.WriteLine("Your Current balance is:" + balance);

                    }
                }
            }

        }
        private static void DepositAmount(List<customer> customerdeposit)
        {
            int amount = 1500;
            int deposit=0;
            string custid = "";
            int balance = 0;
            Console.WriteLine("ENTER THE DEPOSIT AMOUNT:");
            deposit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your CustomerID:");
            custid = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < customerdeposit.Count; i++)
            {

                if (customerdeposit[i].custid == custid)
                {
                   

                    
                    Console.WriteLine("YOUR AMOUNT WAS DEPOSITE SUCCESSFULLY");
                }
                if (customerdeposit[i].custid != custid)
                {
                    Console.WriteLine("INVALID CUSTOMER ID!!!!Please Enter Valid Customer ID......");
                }
                else
                {

                    balance = amount + deposit;
                    Console.WriteLine("YOUR TOTAL BALANCE IS Rs : {0}", balance);
                }
            }
        }
        private static void ChangePassword(List<customer> customerList)
        {
            customer Change = new customer();
            string oldpassword = "";
            string newpassword = "";
            string typeoldpassword = "";
            string custid;
            Console.WriteLine("Change My Password");
            Console.WriteLine("Enter Your CustomerID:");
            custid = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Your New Password:");
            newpassword= Convert.ToString(Console.ReadLine());

            for (int i = 0; i < customerList.Count; i++)
            {

                if (customerList[i].custid == custid && customerList[i].passwrd == oldpassword && customerList[i].passwrd != newpassword)
                {
                    Console.WriteLine("Enter Your Password:");
                    newpassword = Convert.ToString(Console.ReadLine());

                }

                if (customerList[i].passwrd != oldpassword && customerList[i].custid == custid)
                {


                    Console.WriteLine("INCORRECT PASSWORD!!!!Please Enter Valid Password......");
                }

                if (customerList[i].custid != custid && customerList[i].passwrd == oldpassword)
                {
                    Console.WriteLine("INVALID CUSTOMER ID!!!!Please Enter Correct ID.........");
                }

            }
        }
        private static bool ValidatePassword(customer customer, string Newpassword)
        {

            if (customer.passwrd != Newpassword)
            {
                Console.WriteLine("YOUR PASSWORD HAS BEEN CHANGED SUCCESSFULLY...");
                Console.WriteLine("Thank You..!!");
                return false;
            }
            else
            {
                Console.WriteLine("Your New Password as Same as Old Password !!!");
                return true;
            }
        }
    }
}
    




              
                    
                
