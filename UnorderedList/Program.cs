using System;
using System.Net.NetworkInformation;
using UnorderedList.OrderedList;
using UnorderedList.UnorderedList;
<<<<<<< HEAD
using UnorderedList.UnorderedListQueue;
using UnorderedList.UnorderedListStack;
=======
using UnorderedList.BalancedParenthesis;
>>>>>>> UC2-UnorderedListStack

namespace UnorderedList
{
    class Program
    {
        static string unOrderedFilePath = @"D:\BridgeLabs Training\UnorderedList\UnorderedList\UnorderedList\UnOrderList.txt";
<<<<<<< HEAD
        static string OrderedFilePath = @"D:\BridgeLabs Training\UnorderedList\UnorderedList\OrderedList\OrderedList.txt";
=======
        static string balancedFilePath = @"D:\BridgeLabs Training\UnorderedList\UnorderedList\BalancedParenthesis\Balanced.txt";
>>>>>>> UC2-UnorderedListStack
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            operation.ReadFileAndPerformOperation(unOrderedFilePath);
            Console.WriteLine("\nStack:");
            OperationStack operationStack = new OperationStack();
<<<<<<< HEAD
            operationStack.ReadFileAndPerformOperation(unOrderedFilePath);
            Console.WriteLine("\nQueue:");
            OperationQueue operationqueue = new OperationQueue();
            operationqueue.ReadFileAndPerformOperation(unOrderedFilePath);
            OperationOrdered operationOrdered = new OperationOrdered();
            operationOrdered.ReadFileAndPerformOperation(OrderedFilePath);
=======
            operationStack.ReadFileAndPerformOperation(balancedFilePath);

>>>>>>> UC2-UnorderedListStack
        }
    }
}