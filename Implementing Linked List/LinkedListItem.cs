namespace CustomDoublyLinkedList
{
    public class LinkedListItem
    {
        public LinkedListItem(int value)
        {
            Value = value;
        }

        public LinkedListItem Next { get; set; }
        public LinkedListItem Previous { get; set; }
        public int Value { get; set; }


    }
}
