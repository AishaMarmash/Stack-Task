using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{ 
    public class MyStack<T>
    {
        private Node<T>? root;
        public MyStack()
        {
            root = null;
        }
        public void Push(T data)
        {
            Node<T> node = new Node<T>(data);
            if (root == null)
            {
                root = node;
            }
            else
            {
                Node<T> current = root;
                while (current.next !=null)
                {
                    current = current.next;
                }
                current.next = node;
            }
        }
        public T? Pop()
        {
            if (root == null)
            {
                return default;
            }
            else if (root.next == null)
            {
                T data = root.data;
                root= null;
                return data;
            }
            else
            {
                Node<T> current = root;
                while (current.next.next != null)
                {
                    current = current.next;
                }
                T data = current.next.data;
                current.next = null;
                return data;
            }
        }
        public void Print() 
        {
            Node<T>? current = root;
            if (root == null)
            {
                return;
            }
            else
            {
                while(current !=null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }
        }
        public T? Peak()
        {
            if (root == null)
            {
                return default;
            }
            else
            {
                Node<T> current = root;
                while (current.next != null)
                {
                    current = current.next;
                }
                T data = current.data;
                return data;
            }
        }
        public void Clear()
        {
            root = null;
        }
    }
}