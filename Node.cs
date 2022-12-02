public class Node
{
    public int data;
    public Node next;
}
public class LinkedList
{
    private Node head;

    public void AddFirst(int nodeValue)
    {
        Node toAdd = new Node();
        toAdd.data = nodeValue;
        toAdd.next = head;
        head = toAdd;
    }

    public void AddLast(int nodeValue)
    {
        if (head == null)
        {
            head = new Node();
            head.data = nodeValue;
            head.next = null;
        }
        else
        {
            Node toAdd = new Node();
            toAdd.data = nodeValue;
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = toAdd;

        }
    }
    public void PrintNodes()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.data + "->");
            current = current.next;
        }
    }
}