using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnorderedList.UnorderedListQueue
{
    public class OperationQueue
    {
        Queue<string> queue = new Queue<string>();
        int amount;
        public OperationQueue(int amount) 
        {
            this.amount = amount;
        }
        public void AddPersonInQueue()
        {
            Console.WriteLine("Enter number of persons in Queue");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < num; i++)
            {
                queue.Enqueue(Console.ReadLine());
            }
            while(num>0)
            {
                Console.WriteLine("Choose an option to proceed\n 1.Withdraw\n 2.Deposit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        WithDraw();
                        break;
                    case 2:
                        Deposit();
                        break;
                    case 3:
                        DisplayAmountInATM();
                        break;
                }
                queue.Dequeue();
                num--;
            }
        }
        private void DisplayAmountInATM()
        {
            Console.WriteLine(amount);
        }
        private void Deposit()
        {
            Console.WriteLine("Enter amount to withdraw");
            int depositAmount = Convert.ToInt32(Console.ReadLine());
            amount += depositAmount;
        }
        private void WithDraw()
        {
            Console.WriteLine("Enter amount to withdraw");
            int withDrawAmount = Convert.ToInt32(Console.ReadLine());   
            if(withDrawAmount <= amount)
                amount -= withDrawAmount;
            else
                Console.WriteLine("Insufficient Amount...Please try again later");
        }
    }
}
