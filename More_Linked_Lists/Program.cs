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
                //para fazer o while andar quando o if de cima nao for antendido. Valores diferentes. Ex 12, 13, 14
                else start = start.next;

            }
            //quando o start.next for nulo. Ja chegamo no final da fila. Nesse momento para sair do 
            //while a variavel start PRECISA ser null. A UNICA FORMA DE SAIR DO WHILE.
            //E start = start.next, eh igual dizer start = null
            else start = start.next;


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
        else
        {
            Node start = head;
            while (start.next != null)
            {
                start = start.next;
            }
            start.next = p;
            //Pq head esta sendo atualizado se em nenhum momento ele ta sendo alterado ?
            //Ex: total de 2 nodes. Node 10 e Node 20, o resultado desse console abaixo vai ser 20. 
            //Console.WriteLine(head.next.data);
            //Obs nao esquecer de apagar as chamadas de removeDuplicates e display la na main
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
        head = removeDuplicate(head);
        display(head);
       
    }


}