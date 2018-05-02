/** <remark>
 * Создайте общую структуру данных, которая может хранить любой тип, который можно сравнить.
 * Реализация функций:
 * void Add(T element)
 * T Remove(int index)
 * bool Contains(T element)
 * void Swap(int index1, int index2)
 * int CountGreaterThan(T element)
 * T Max()
 * T Min()
 *
 * Измените пользовательский список, который вы создали. Задайте тип настраиваемого списка для строки.
 * Внедрить команды:
 * Add<element> - добавляет данный элемент в конец списка.
 * Remove<index> - удаляет элемент по указанному индексу.
 * Contains<element> - печатает, если список содержит данный элемент (True или False).
 * Swap<index> <index> - свопит элементы по заданным индексам.
 * Greater<element> - подсчитывает элементы, которые больше, чем данный элемент, и печатает их количество.
 * Max – вывод максимального элемента в списке.
 * Min - вывод минимального элемента в списке.
 * Print - вывод всех элементов в списке, каждый на отдельной строке. 
</remark> */

using System;

namespace _20180327_Task4_Generic
{
    internal class Program
    {
        private static void Main()
        {
            ICommandList<string> myList = new CustomList<string>();

            try
            {
                Dialog.UserInterface(myList);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Please, read the first string and then restart program.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}