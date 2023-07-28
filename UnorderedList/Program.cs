using System;
using System.Net.NetworkInformation;
using UnorderedList.UnorderedList;

namespace UnorderedList
{
    class Program
    {
        static string unOrderedFilePath = @"D:\BridgeLabs Training\UnorderedList\UnorderedList\UnorderedList\UnOrderList.txt";
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            operation.ReadFileAndPerformOperation(unOrderedFilePath);
        }
    }
}