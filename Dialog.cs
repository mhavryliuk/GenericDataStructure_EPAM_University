using System;

namespace _20180327_Task4_Generic
{
    internal class Dialog
    {
        public static void UserInterface(ICommandList<string> myList)
        {
            Console.WriteLine("Please, select the command, then press the spacebar and enter your element, index(es) if necessary.");

            Console.Write("1 -");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [Add]");
            Console.ResetColor();
            Console.WriteLine(" an element to the list");

            Console.Write("2 -");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [Remove]");
            Console.ResetColor();
            Console.WriteLine(" item at specified index");

            Console.Write("3 - Check if the list");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [Contains]");
            Console.ResetColor();
            Console.WriteLine(" the specified element");

            Console.Write("4 -");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [Swap]");
            Console.ResetColor();
            Console.WriteLine(" of the elements by the indexes");

            Console.Write("5 - Counting the number of elements that are");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [Greater]");
            Console.ResetColor();
            Console.WriteLine(" than the specified");

            Console.Write("6 - Prints the");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [Max]");
            Console.ResetColor();
            Console.WriteLine(" element in the list");

            Console.Write("7 - Prints the");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [Min]");
            Console.ResetColor();
            Console.WriteLine(" element in the list");

            Console.Write("8 -");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [Print]");
            Console.ResetColor();
            Console.WriteLine(" all elements in the list");

            Console.Write("0 -");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" [Exit]");
            Console.ResetColor();

            Console.WriteLine("\nYour choice:");

            var command = Console.ReadLine();

            // Проверка, что первое введенное значение число
            bool num = command != null && char.IsDigit(command[0]);
            if (!num)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error. The first value must be a number from 1 to 8 or 0.");
                Console.WriteLine("Please try again.");
                Console.ResetColor();
            }

            while (command != "0")
            {
                Execute.CommandProcessing(command, myList);
                command = Console.ReadLine();
            }
        }
    }
}