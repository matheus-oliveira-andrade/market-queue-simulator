namespace QueueSimulator.Model
{
    class No<T>
    {
        public No<T> Next { get; set; }
        public No<T> Anterior { get; set; }
        public T Item { get; set; }

        public No(T item, No<T> next)
        {
            Item = item;
            Next = next;
        }
        public No(T item) : this(item, null)
        {
        }
    }
}
