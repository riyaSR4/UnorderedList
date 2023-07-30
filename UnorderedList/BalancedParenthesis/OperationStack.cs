using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnorderedList.BalancedParenthesis
{
    public class OperationStack
    {
        Stack<string> stack = new Stack<string>();
        public void ReadFileAndPerformOperation(string filePath)
        {
            string readAllText = File.ReadAllText(filePath);
            string[] words = readAllText.Split(" ");
            foreach (var data in words)
            {
                if(data.Equals("("))
                    stack.Push(data);
                if (data.Equals(")"))
                    stack.Pop();
            }
            if (stack.IsEmpty())
                Console.WriteLine("Balanced Parenthesis");
            else
                Console.WriteLine("Not a Balanced Parenthesis");

        }
    }
}
