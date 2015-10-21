using System;
using System.Collections;
using System.Collections.Generic;

namespace Day6
{
    class MyEnumerator : IEnumerator
    {

        public static LinkedList<Person> myLinkedList;

        public LinkedListNode<Person> currentNode;

        public MyEnumerator() {
            myLinkedList = new LinkedList<Person>();
            myLinkedList.AddLast(new Person { Id = 1, Name = "Sijo", Location = "Bhopal" });
            myLinkedList.AddLast(new Person { Id = 2, Name = "Midhila", Location = "Hyderabad" });
            myLinkedList.AddLast(new Person { Id = 3, Name = "Subin", Location = "Tiruvalla" });
            myLinkedList.AddLast(new Person { Id = 4, Name = "Srininvas", Location = "Bangalore" });
            myLinkedList.AddLast(new Person { Id = 5, Name = "Priya", Location = "Kochi" });
        }

        public object Current
        {

            get { return currentNode.Value; }
        }

        public bool MoveNext()
        {

            if (currentNode == null && myLinkedList.First != null)
            {

                currentNode = myLinkedList.First;
                return true;
            }
            if (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Reset()
        {
            currentNode = null;
        }
    }

}
