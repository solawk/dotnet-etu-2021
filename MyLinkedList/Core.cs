using System;

namespace MyLinkedList
{
    class Core
    {
        static void Main(string[] args)
        {
            LinkedList MyList = new LinkedList();

            string answer = null;

            while (answer != "quit")
            {
                int data;
                int index;

                MyList.Print();
                Console.Write("Command: ");
                answer = Console.ReadLine();

                switch (answer)
                {
                    case "addfirst":
                        Console.Write("Data: ");
                        data = int.Parse(Console.ReadLine());
                        MyList.AddFirst(data);
                        break;

                    case "addas":
                        Console.Write("Index: ");
                        index = int.Parse(Console.ReadLine());
                        Console.Write("Data: ");
                        data = int.Parse(Console.ReadLine());
                        MyList.AddAs(index, data);
                        break;

                    case "addlast":
                        Console.Write("Data: ");
                        data = int.Parse(Console.ReadLine());
                        MyList.AddLast(data);
                        break;

                    case "set":
                        Console.Write("Index: ");
                        index = int.Parse(Console.ReadLine());
                        Console.Write("Data: ");
                        data = int.Parse(Console.ReadLine());
                        MyList[index] = data;
                        break;

                    case "remove":
                        Console.Write("Index: ");
                        index = int.Parse(Console.ReadLine());
                        MyList.Remove(index);
                        break;

                    case "clear":
                        MyList.Clear();
                        break;

                    case "foreach":
                        Console.Write("Printing via foreach: ");
                        foreach (int element in MyList)
                        {
                            Console.Write(element + " ");
                        }
                        Console.WriteLine();
                        break;

                    case "reverse":
                        MyList.Reverse();
                        break;
                }
            }
        }
    }
}
