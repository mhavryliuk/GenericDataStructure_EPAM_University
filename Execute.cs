using System;

namespace _20180327_Task4_Generic
{
    internal class Execute
    {
        /// <summary>
        /// Метод CommandProcessing() обрабатывает комманды пользователя.
        /// </summary>
        /// <param name="command">Наименование комманды передается в качестве параметра command.</param>
        /// <param name="myList">Пользовательский список передается в качестве параметра myList.</param>
        public static void CommandProcessing(string command, ICommandList<string> myList)
        {
            var commandArgs = command.Split();
            switch (commandArgs[0])
            {
                case "1":
                    myList.Add(commandArgs[1]);
                    break;
                case "2":
                    myList.Remove(int.Parse(commandArgs[1]));
                    break;
                case "3":
                    Console.WriteLine(myList.Contains(commandArgs[1]));
                    break;
                case "4":
                    myList.Swap(int.Parse(commandArgs[1]), int.Parse(commandArgs[2]));
                    break;
                case "5":
                    Console.WriteLine(myList.CountGreaterThan(commandArgs[1]));
                    break;
                case "6":
                    Console.Write("Maximum element in the list: ");
                    Console.WriteLine(myList.Max());
                    break;
                case "7":
                    Console.Write("Minimum element in the list: ");
                    Console.WriteLine(myList.Min());
                    break;
                case "8":
                    myList.Print();
                    break;
                default:
                    break;
            }
        }
    }
}