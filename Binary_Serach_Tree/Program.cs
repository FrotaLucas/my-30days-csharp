using System;

class Node
{
    public Node left, right;
    public int data;
    public Node(int data)
    {
        this.data = data;
        left = right = null;
    }
}

class Solution
{
    static int getHeight(Node root)
    {
        if (root == null)
        {
            return 0; // Height of an empty tree is 0
        }
        else
        {
            //Console.WriteLine("Comparando");
            int leftHeight = getHeight(root.left);
            int rightHeight = getHeight(root.right);

            // Height of the tree is the maximum of left and right subtree heights, plus 1 for the root
            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }

    static Node insert(Node root, int data)
    {
        if (root == null)
        {
            Console.WriteLine("Heey new Node");
            return new Node(data);
        }
        else
        {
            Node cur;
            if (data <= root.data)
            {
                Console.WriteLine("Hellow if");
                cur = insert(root.left, data);
                root.left = cur;
            }
            else
            {
                cur = insert(root.right, data);
                root.right = cur;
            }
            return root;
        }
    }

    static void Main(String[] args)
    {
        Node root = null;
        int T, count = 0;
        Console.WriteLine("type the total number of Nodes");
        T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            Console.WriteLine($"Type the {count+1}. Node");
            int data = Int32.Parse(Console.ReadLine());
            root = insert(root, data);
            count++;    
        }

        Console.WriteLine("The Height of the tree");
        int height = getHeight(root);
        Console.WriteLine(height);
    }
}



