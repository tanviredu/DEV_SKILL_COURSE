namespace AllDataStructure
{
    public interface ISimpleStack<T>
    {
        bool IsEmpty();
        bool Push(T item);
        T Pop();
        void Peek();
        void PrintStack();
    }
}
