
public class LinkedList<T>
{

    private int counter;
    private Node<T> head;
    private Node<T> current;
    private Node<T> prev;
    
    

    public LinkedList()
    {
        counter = 0;
        head = null;
        current = null;
        prev = null;
        
    }





    public void Add(T data)
    {
        Node<T> myNode = new Node<T>(data);
        current = head;

        if (head == null)
        {
            head = myNode;
        }
        else
        {
            
            while (current.next != null)
            {
                current = current.next;
            }

            current.next = myNode;
        }

        counter++;
    }

    public bool Remove(T data)
    {
        current = head;
        Node<T> myNode = new Node<T>(data);
        
        if (head.data.Equals(myNode.data))
        {
            current = head.next;
            head = current;
            return true;
        }
        else
        {
            while (current != null)
            {
                if (current.data.Equals(myNode.data))
                {
                    prev.next = current.next;
                    current = prev;
                    return true;
                }
                else
                {
                    prev = current;
                    current = current.next;
                }
            }
        }

        counter--;

        return false;
    }


    public bool Check(T data)
    {
        var myNode = new Node<T>(data);

        var current = head;

        while (current != null)
        {
            if (current.data.Equals(myNode.data))
            {

                return true;
            }

            current = current.next;
        }
        return false;
    }


    public int Index(T data)
    {
        var myNode = new Node<T>(data);
        var current = head;
        int index = 0;
        
        while (current != null)
        {
            if (current.data.Equals(myNode.data))
            {
                return index;
            }
            index++;
            current = current.next;
        }

        return -1;
    }
    

    public T display()
    {
        current = head;

        while (current.next != null)
        {
            Console.WriteLine(current.data);
            current = current.next;

        }
        if (current.next == null)
        {
            Console.WriteLine(current.data);
        }

        return default;
        //return current.next.data;
    }

}