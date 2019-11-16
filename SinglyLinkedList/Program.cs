using System;
using System.Text.RegularExpressions;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class SinglyLinkedList
    {
        private Node first;
        public bool isEmpty()
        {
            return (first == null);
        }
        public void insertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = first;
            first = newNode;
        }

        string replaceAllDigitsRegExp(string s)
        {
            return Regex.Replace(s, "\\d", "#");
        }

        public Node deleteFirst()
        {
            Node temp = first;
            first = first.next;
            return temp;
        }
    }
    public class Node
    {
        public int data;
        public Node next;
        public void displayNode()
        {
            Console.WriteLine("<" + data + ">");
        }
    }
}
