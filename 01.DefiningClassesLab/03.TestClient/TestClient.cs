using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TestClient
{
   public class TestClient
   {
       private ICollection<BankAccount> accounts;

       public TestClient()
       {
           this.accounts = new HashSet<BankAccount>();
       }
        public void Create(int id)
        {
            if (this.accounts.Any(ac => ac.ID == id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var bc = new BankAccount();
                bc.ID = id;
                this.accounts.Add(bc);
            }
        }

        public void Deposit(int Id, double amount)
        {
            if (accounts.All(a => a.ID != Id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                var bc = this.accounts.FirstOrDefault(a => a.ID == Id);
                bc.Balance += amount;
            }
            
        }

       public void Withdraw(int id, double amount)
       {
            if (accounts.All(a => a.ID != id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                var bc = this.accounts.FirstOrDefault(a => a.ID == id);
                if (bc.Balance < amount)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    bc.Balance -= amount;
                }
            }
        }

        public void Print(int id)
        {
            if (accounts.All(a => a.ID != id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                var bc = this.accounts.FirstOrDefault(b => b.ID == id);
                Console.WriteLine($"Account ID{id}, balance {bc.Balance:F2}");
            }
            
        }
    }
}
