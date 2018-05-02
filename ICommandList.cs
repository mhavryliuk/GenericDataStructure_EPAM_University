namespace _20180327_Task4_Generic
{
    internal interface ICommandList<T>
    {
        void Add(T element);
        T Remove(int index);
        bool Contains(T element);
        void Swap(int index1, int index2);
        int CountGreaterThan(T element);
        T Max();
        T Min();
        void Print();
    }
}