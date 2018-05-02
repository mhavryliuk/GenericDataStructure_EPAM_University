using System;
using System.Collections.Generic;
using System.Linq;

namespace _20180327_Task4_Generic
{
    internal class CustomList<T> : ICommandList<T> where T : IComparable<T>
    {
        private const int capacity = 2;   // Задаем исходный размер списка
        private T[] data;                 // Список
        private int filledСells;          // Контроль заполнения списка

        private IEnumerable<T> myList;

        /// <summary>
        /// Конструктор класса CustomList
        /// </summary>
        public CustomList()
        {
            data = new T[capacity];
            myList = new List<T>();
        }

        /// <summary>
        /// Метод Add() добавляет элемент в конец списка.
        /// </summary>
        /// <param name="element">Добавляемый в конец списка элемент передается в качестве параметра element.</param>
        public void Add(T element)
        {
            // Если список заполнен, увеличиваем его.
            if (filledСells == data.Length)
            {
                data = data.Concat(new T[filledСells]).ToArray();
            }

            data[filledСells] = element;
            filledСells++;
        }

        /// <summary>
        /// Метод Remove() удаляет элемент по указанному индексу.
        /// </summary>
        /// <param name="index">Индекс по которому будет удален элемент списка передается в качестве параметра index.</param>
        /// <returns></returns>
        public T Remove(int index)
        {
            var element = data[index];
            data = data.Take(index).Concat(data.Skip(index + 1)).ToArray();
            filledСells--;
            return element;
        }

        /// <summary>
        /// Метод Contains() возвращает True или False взависимости от того есть заданный элемент в списке или нет.
        /// </summary>
        /// <param name="specifiedElement">Заданный элемент передается в качестве параметра specifiedElement</param>
        /// <returns>Результат проверки на наличие заданного элемента в списке в виде True или False.</returns>
        public bool Contains(T specifiedElement)
        {
            if (filledСells == 0)
            {
                return false;
            }

            var comparer = EqualityComparer<T>.Default;

            foreach (var element in data)
            {
                if (comparer.Equals(element, specifiedElement))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Метод Swap() меняет местами два элемента по заданным индексам.
        /// </summary>
        /// <param name="index1">Первый индекс передается в качестве параметра index1.</param>
        /// <param name="index2">Второй индекс передается в качестве параметра index2.</param>
        public void Swap(int index1, int index2)
        {
            var temp = data[index1];
            data[index1] = data[index2];
            data[index2] = temp;
        }

        /// <summary>
        /// Метод CountGreaterThan() подсчитывает элементы, которые больше, чем заданный, и печатает их количество.
        /// </summary>
        /// <param name="element">Заданный элемент передается в качестве параметра element.</param>
        /// <returns>Количество элементов больше заданного.</returns>
        public int CountGreaterThan(T element)
        {
            var counter = 0;
            foreach (var currentElement in data)
            {
                if (element.CompareTo(currentElement) < 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        /// <summary>
        /// Метод Max() возвращает максимальный элемент из списка.
        /// </summary>
        /// <returns>Максимальный элемент из списка.</returns>
        public T Max()
        {
            return data.Max();
        }

        /// <summary>
        /// Метод Min() возвращает минимальный элемент из списка.
        /// </summary>
        /// <returns>Минимальный элемент из списка.</returns>
        public T Min()
        {
            return data.Min();
        }

        /// <summary>
        /// Вывод всех элементов в списке, каждый на отдельной строке.
        /// </summary>
        public void Print()
        {
            Console.WriteLine("All elements in the list:");
            foreach (var element in data)
                Console.WriteLine(element);
        }
    }
}