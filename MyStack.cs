using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack2024
{
    public class MyStack<T> : IEnumerable<T>
    {
        private Node<T> head;

        public MyStack() 
        {
            head = null;
        }

        public void Push(T data)
        {
            Node<T> node = new Node<T>(data);
            node.Next = head;
            head = node;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            T value = head.Element;
            head = head.Next;
            return value;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            
            return head.Element;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Element;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
