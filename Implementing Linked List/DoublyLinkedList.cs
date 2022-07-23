using System;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        private LinkedListItem<T> first;
        private LinkedListItem<T> last;

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

        public void AddFirst(T element)
        {
            var newItem = new LinkedListItem<T>(element);

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

        public void AddLast(T element)
        {
            var newItem = new LinkedListItem<T>(element);

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

        public T RemoveFirst()
        {
            if (first == null)
            {
                throw new InvalidOperationException("Linked list empty");
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

        public T RemoveLast()
        {
            if (last == null)
            {
                throw new InvalidOperationException("Linked list empty");
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

        public void ForEach(Action<T> action)
        {
            var current = first;

            while (current != null)
            {
               action(current.Value);
                current = current.Next;
            }
        }

        public T[] ToArray()
        {
            var array = new T[Count];
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
