using System;
using System.Net.NetworkInformation;
using UnorderedList.UnorderedList;
using UnorderedList.BalancedParenthesis;

namespace UnorderedList
{
    class Program
    {
        static string unOrderedFilePath = @"D:\BridgeLabs Training\UnorderedList\UnorderedList\UnorderedList\UnOrderList.txt";
        static string balancedFilePath = @"D:\BridgeLabs Training\UnorderedList\UnorderedList\BalancedParenthesis\Balanced.txt";
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            operation.ReadFileAndPerformOperation(unOrderedFilePath);
            Console.WriteLine("\nStack:");
            OperationStack operationStack = new OperationStack();
            operationStack.ReadFileAndPerformOperation(balancedFilePath);

        }
    }
}