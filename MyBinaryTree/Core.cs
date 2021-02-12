using System;

namespace MyBinaryTree
{
    class Core
    {
        static void Main(string[] args)
        {
            BinaryTree MyTree = new BinaryTree();
            Random rand = new Random();

            string answer = null;

            while (answer != "quit")
            {
                int key;
                string value;

                MyTree.Print();
                Console.Write("Command: ");
                answer = Console.ReadLine();

                switch (answer)
                {
                    case "add":
                        Console.Write("Key: ");
                        key = int.Parse(Console.ReadLine());
                        Console.Write("Value: ");
                        value = Console.ReadLine();
                        MyTree.Add(key, value);
                        break;

                    case "search":
                        Console.Write("Key: ");
                        key = int.Parse(Console.ReadLine());
                        MyTree.Search(key);
                        break;

                    case "remove":
                        Console.Write("Key: ");
                        key = int.Parse(Console.ReadLine());
                        MyTree.Remove(key);
                        break;

                    case "random":
                        for (int i = 0; i < 10; i++)
                        {
                            MyTree.Add(rand.Next(0, 1000), rand.Next(0, 1000).ToString());
                        }
                        break;
                }
            }
        }
    }
}
