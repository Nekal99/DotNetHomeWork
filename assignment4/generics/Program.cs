public class Node<T>
{
    public Node<T>? Next { get; set; }
    public T Data { get; set; }

    public Node(T t)
    {
        this.Next = null;
        this.Data = t;
    }
    public Node(Node<T> t)
    {
        this.Next = t.Next;
        this.Data = t.Data;
    }
}

public class GenericList<T>
{
    private Node<T>? head;
    private Node<T>? tail;

    public Node<T>? Head
    {
        get
        {
            return head;
        }
        private set
        {
            head = value;
        }
    }

    public Node<T>? Tail
    {
        get
        {
            return tail;
        }
        private set
        {
            tail = value;
        }
    }

    public GenericList()
    {
        head = tail = null;
    }

    public void Add(T t)
    {
        Node<T> n = new(t);
        if (tail == null)
        {
            head = tail = n;
        }
        else
        {
            tail.Next = n;
            tail = n;
        }
    }

    public void ForEach(Action<Node<T>> action)
    {

        for (Node<T>? i = head; i != null; i = i.Next)
        {
            action(i);
        }
    }
}

public class Test
{
    static void Main()
    {
        GenericList<int> genericList = new GenericList<int>();
        int max = int.MinValue;
        int min = int.MaxValue;
        int sum = 0;

        for (int i = 0; i < 10; i++)
        {
            genericList.Add(i);
        }

        Console.WriteLine("泛型链表的各个元素为值");

        genericList.ForEach(s => Console.WriteLine(s.Data));
        genericList.ForEach(s =>
        {
            sum += s.Data;
            if (max <= s.Data)
            {
                max = s.Data;
            }
            if (min >= s.Data)
            {
                min = s.Data;
            }
        });

        Console.WriteLine("泛型链表的和为" + sum);
        Console.WriteLine("最大值为" + max);
        Console.WriteLine("最小值为" + min);
    }
}