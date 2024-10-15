using System;


class Node
{
    public int data;
    public Node next;

    public Node(int Data)
    {
        data = Data;
        next = null;
    }
}


class Solution
{
    //remove somente os nodes que tem dados duplicados subsequentes
    static Node removeDuplicate(Node head)
    {
        Node start = head;

        while (start != null)
        {

            if (start.next != null)
            {
                Node checkDup = start.next;

                if (start.data == checkDup.data)
                {
                    Node deletedNode = checkDup;
                    checkDup = null;
                    start.next = deletedNode.next;
                }

            }

            //ERRADO!
            // AQUI o start vai sempre esta mundando. Otimo para fazer o While seguir rodando, mas ....
            // para o caso de encontrar 3 vizinhos que sao iguais, ou seja, start.data == checkDup.data for true
            // o start vai automaticamente pular para o proximo, o que seria uma duplicata do anterior que
            // nao estara sendo removida
            //ex: 12, 13, 13, 13
            start = start.next;

        }

        return head;

    }
    static void display(Node root)
    {
        Node start = root;

        while (start != null)
        {
            Console.WriteLine($"Value of data: {start.data}");
            start = start.next;
        }
    }

    static Node insert(Node head, int data)
    {
        Node p = new Node(data);


        if (head == null)
        {
            head = p;
        }

        else if (head.next == null)
        {
            head.next = p;
        }

        else
        {
            Node start = head;

            while (start.next != null)
            {
                start = start.next;
            }
            start.next = p;
        }

        return head;
    }
    static void Main(string[] args)
    {
        int T, data;
        Node head = null;
        Console.WriteLine("Type the total of Nodes");

        T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            data = Int32.Parse(Console.ReadLine());
            head = insert(head, data);

        }
        Console.WriteLine("Result:\n");
        head = removeDuplicate(head);
        display(head);

    }



}