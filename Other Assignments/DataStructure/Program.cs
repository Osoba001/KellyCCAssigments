// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class DoubleLinkedList<T>
{
    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
        }
        public T Value;
        public Node<T> Previous;
        public Node<T> Next;
    }
    Node<T> Head;
    Node<T> Tail;
    int count;
    private bool IsEmpty()
    {
        return Head == null;
    }
    public void AddFirst(T item)
    {
        var node = new Node<T>(item);
        if (IsEmpty())
        {
            Head = Tail = node;
            count++;
            return;
        }
        var temp = Head;
        node.Next = temp;
        temp.Previous = node;
        Head = node;
        count++;
    }
    public void AddLast(T item)
    {
        var node = new Node<T>(item);
        if (IsEmpty())
        {
            Head = Tail = node;
            count++;
            return;
        }
        var temp = Tail;
        node.Previous = temp;
        temp.Next = node;
        Tail = node;
        count++;
    }
    public void InsertAt(T item, int index)
    {
        if (index < count)
        {
            var node = new Node<T>(item);
            var current = Head;
            int i = 0;
            while (i < index)
            {
                current = current.Next;
                i++;
            }
            var temp = current.Previous;
            temp.Next = node;
            node.Previous = temp;
            node.Next = current;
            current.Previous = node;
            count++;
        }
    }
    public Node<T> Find(T item)
    {
        var current = Head;
        while (current != null)
        {
            if (Equals(current.Value, item))
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }
    public void RemoveItem(T item)
    {
        var current = Head;
        if (current == Head)
        {
            var temp = Head.Next;
            Head.Next = null;
            temp.Previous = null;
            Head = temp;
            count++;
        }
        if (current == Tail)
        {
            var temp = Tail.Previous;
            Tail.Previous = null;
            temp.Next = null;
            Tail = temp;
            count++;
        }
        while (current != null)
        {
            if (Equals(current.Value,item))
            {
                var temp1 = current.Previous;
                var temp2 = current.Next;
                temp1.Next = temp2;
                temp2.Previous = temp1;
                count--;
            }
            current = current.Next;
        }
    }
    public void ClearList()
    {
        Head=Tail = null;
    }
}
