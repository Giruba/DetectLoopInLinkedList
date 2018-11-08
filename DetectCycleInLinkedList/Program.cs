using System;

namespace DetectCycleInLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Detect cycle in a Linked list!");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Enter the number of elements in the LinkedList");
            try
            {
                int noOfelements = int.Parse(Console.ReadLine());
                LinkedList linkedList = new LinkedList();
                Console.WriteLine("Enter the elements separated by space");
                String allElements = Console.ReadLine();
                String[] elements = allElements.Split(' ');
                for (int i = 0; i < elements.Length; i++)
                {
                    linkedList.Insert(int.Parse(elements[i]));
                }

                linkedList.DetectLoopInLinkedList(linkedList.GetHeadNode());
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            Console.ReadLine();
        }
    }
}
