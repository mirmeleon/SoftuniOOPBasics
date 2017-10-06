using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
   {
       private int age;
       private string name;
       private List<BankAccount> accounts;

       public Person(string name, int age)
        : this(name, age, new List<BankAccount>())
       {
        //ctor chanining 
       }
    
       public Person(string name, int age, List<BankAccount> accounts)
       {
           this.accounts = accounts;
           this.name = name;
           this.age = age;
       }

    public List<BankAccount> Accounts
    {
        get { return this.accounts; }
        set { this.accounts = value; }
    }

    public int Age
       {
           get { return this.age; }
            set { this.age = value; }
       }

       public string Name
       {
           get { return this.name; }

            set { this.name = value; }
       }

       public double GetBalance()
       {
           var res = accounts.Sum(a => a.Balance);
           return res;
       }

   }
