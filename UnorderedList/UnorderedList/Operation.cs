using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnorderedList.UnorderedList
{
    public class Operation
    {
        public void ReadFileAndPerformOperation(string filePath)
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            string readAllText = File.ReadAllText(filePath);
            string[] words = readAllText.Split(" ");
            foreach(var data in words)
            {
                linkedList.Add(data);
            }
            linkedList.Display();
            Console.WriteLine("\nEnter a input :");
            string input = Console.ReadLine();
            linkedList.Operation(input);
            linkedList.Display();
        }
    }
}
