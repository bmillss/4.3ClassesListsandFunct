using System;
using System.Collections.Generic;

namespace Lab4._3ClassesContinued
{
    class customer
    {
        private string Company;
        private string ContactName;
        private string ContactEmail;
        private string Phone;

        public customer(string _Comp, string _Name, string _Email, string _Phone)
        {
            setComp(_Comp);
            setName(_Name);
            setEmail(_Email);
            setPhone(_Phone);
        }
        public string getComp()
        {
            return Company;
        }
        public string getName()
        {
            return ContactName;
        }
        public string getEmail()
        {
            return ContactEmail;
        }
        public string getPhone()
        {
            return Phone;
        }
        public void setComp(string _Comp)
        {
            Company = _Comp;
        }
        public void setName(string _Name)
        {
            ContactName = _Name;
        }
        public void setEmail(string _Email)
        {
            ContactEmail = _Email;

        }
        public void setPhone(string _Phone)
        {
            Phone = _Phone;
        }


        public override string ToString()
        {
            return $"\n==========================\nCompany:{getComp()} \nName:{getName()} \nEmail:{getEmail()} \nPhone:{getPhone()}\n===============================\n";
        }
    }
    class Program
    {
        static void ListCustomer(List<customer> customerList)
        {
            foreach (customer nextcustomer in customerList)
            {
                Console.WriteLine(nextcustomer);
            }
        }
        static customer SearchCustomers(List<customer> customers, string company)
        {
            foreach (customer nextCustomer in customers)
            {
                if (nextCustomer.getComp() == company)
                {
                    return nextCustomer;
                }

            }
            return null;
        }
        static void Main(string[] args)
        {

            List<customer> newbies = new List<customer>();

            customer brandnew = new customer("rocketmortgage", "bob", "bob@gmail.com", "704-777-1111");
            Console.WriteLine(brandnew);
            newbies.Add(brandnew);
            brandnew = new customer("quickenloans", "joe", "joe@hotmail.com", "995-999-5555");
            newbies.Add(brandnew);

            Console.WriteLine("Here are all the customers:");
            ListCustomer(newbies);

            Console.WriteLine("Please enter the name of a company to search!");
            string custSearch = Console.ReadLine().ToLower();

            brandnew = SearchCustomers(newbies, custSearch);
            if (brandnew != null)
            {
                Console.WriteLine(brandnew);
            }
            else
            {
                Console.WriteLine("Apologies this company does not exist!");
            }


        }
    }
}
