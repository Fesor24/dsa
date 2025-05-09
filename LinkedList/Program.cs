// See https://aka.ms/new-console-template for more information
using static System.Console;

WriteLine("Linked List!!!");

Node<int> node = new Node<int>();

node.Creation(1).Creation(2).Creation(3).Creation(4);

node.Display();

WriteLine($"Length of  node is: {node.Length}");

ReadLine();

class Node<T>
{
    // When no element in the node, head should be null
    private Node<T>? _head;
    private Node<T> _current;

    public Node()
    {
        
    }
    public Node(T data, Node<T>? next)
    {
        Data = data;
        Next = next;
    }

    public T Data { get; init; }
    public Node<T>? Next { get; private set; }
    public int Length { get; private set; }
    public Node<T>? Head => _head;
    public Node<T> Current => _current;

    public Node<T> Creation(T data)
    {
        Node<T> node = new(data, null);

        if (_head == null)
        {
            _head = node;
            _current = node;
        }
        else
        {
            // say we are on the first element
            // we set the next to the new node
            // we then switch the current to the new node
            // this way, the new node is referenced by the preceding one
            _current.Next = node;
            _current = node;
        }
        
        Length++;

        return this;
    }

    public void Display()
    {
        if (_head == null) return;
        
        Node<T>? temp = _head;
        
        while (temp != null)
        {
            WriteLine(temp.Data);
            temp = temp.Next;
        }
    }
}