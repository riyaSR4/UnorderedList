using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnorderedList.UnorderedList
{
    public class Operation
    {
        LinkedList<string> linkedList = new LinkedList<string>();
        public void ReadFileAndPerformOperation(string filePath)
        {
            string readAllText = File.ReadAllText(filePath);
            string[] words = readAllText.Split(" ");
            foreach(var data in words)
            {
                linkedList.Add(data);
            }
            linkedList.Display();
            Console.WriteLine("\nEnter number to search");
            string word = Console.ReadLine();
            int position = linkedList.Search(word);
            if(position == -1)
            {
                linkedList.Add(word);
            }
            else
            {
                linkedList.DeleteNodeAtParticularPosition(position);
            }
            linkedList.Display();
        }
    }
}
