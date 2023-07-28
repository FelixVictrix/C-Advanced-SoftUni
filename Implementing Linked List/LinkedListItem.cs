namespace Implementing_Linked_List
{
    public class LinkedListItem<T>
    {
        public LinkedListItem(T value)
        {
            Value = value;
        }

        public LinkedListItem<T> Next { get; set; }
        public LinkedListItem<T> Previous { get; set; }
        public T Value { get; set; }


    }
}
