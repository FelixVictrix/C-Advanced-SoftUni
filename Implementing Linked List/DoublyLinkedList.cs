using System;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        private LinkedListItem first;
        private LinkedListItem last;

        public int Count
        {
            get
            {
                var count = 0;
                var currElement = first;

                while (currElement != null )
                {
                    count++;
                    currElement = currElement.Next;
                }
                return count;
            }
        }

        public void AddFirst(int element)
        {
            var newItem = new LinkedListItem(element);

            if (first == null)
            {
                first = newItem;
                last = newItem;
            }
            else
            {
                newItem.Next = first;
                first.Previous = newItem;
                first = newItem;
            }
        }

        public void AddLast(int element)
        {
            var newItem = new LinkedListItem(element);

            if (first == null)
            {
                first = newItem;
                last = newItem;
            }
            else
            {
                newItem.Previous = last;
                last.Next = newItem;
                last = newItem;
            }
        }

        public int RemoveFirst()
        {
            if (first == null)
            {
                return 0;
            }

            var currFstVavlue = first.Value;

            if (first == last)
            {
                first = null;
                last = null;
            }
            else
            {
                var newFirst = first.Next;
                newFirst.Previous = null;
                first = newFirst;
            }
            return currFstVavlue;
        }

        public int RemoveLast()
        {
            if (last == null)
            {
                return 0;
            }

            var currLstVavlue = last.Value;

            if (first == last)
            {
                first = null;
                last = null;
            }
            else
            {
                var newLast = last.Previous;
                newLast.Next = null;
                last = newLast;
            }
            return currLstVavlue;
        }

        public void ForEach(Action<int> action)
        {
            var current = first;

            while (current != null)
            {
               action(current.Value);
                current = current.Next;
            }
        }

        public int[] ToArray()
        {
            var array = new int[Count];
            var index = 0;
            var current = first;

            while (current != null)
            {
                array[index] = current.Value;
                index++;
                current = current.Next;
            }
            return array;
        }
    }
}
