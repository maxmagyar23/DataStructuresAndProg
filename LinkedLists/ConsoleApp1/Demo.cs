using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{
    class Demo
    {
        static void Main(string [] args)
        {

            int choice, data, k, x;

            SingleLinkedList list = new SingleLinkedList();

            list.CreateList();

            while (true)
            {
                Console.WriteLine("1. Display List");
                Console.WriteLine("2. Count the number of nodes");
                Console.WriteLine("3. Search for an element");
                Console.WriteLine("4. Insert in empty/Insert in beginning oof the list");
                Console.WriteLine("5. Insert a node at the end of the lsit");
                Console.WriteLine("6. Insert a node after a specific node");
                Console.WriteLine("7. Insert a node before a specific node");
                Console.WriteLine("8. Insert a node at a given position");
                Console.WriteLine("9. Delete first node");
                Console.WriteLine("10. Delete last node");
                Console.WriteLine("11. Delete any node");
                Console.WriteLine("12. Reverse the list");
                Console.WriteLine("13. Bubble sort by exchanging data");
                Console.WriteLine("14. Bubble sort by exchanging links");
                Console.WriteLine("15. MergeSort");
                Console.WriteLine("16. Insert cycle");
                Console.WriteLine("17. Detect Cycle");
                Console.WriteLine("18. Remove Cycle");
                Console.WriteLine("19. Quit");

                Console.WriteLine("Enter Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 19)
                    break;

                switch(choice)
                {
                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        list.CountNodes();
                        break;
                    case 3:
                        Console.WriteLine("Enter the element to be searched: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.Search(data);
                        break;
                    case 4:
                        Console.WriteLine("Enter the elementto be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInBeginning(data);
                        break;
                    case 5:
                        Console.WriteLine("Enter the element to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        break;
                    case 6:
                        Console.WriteLine("Enter the element to ber inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element after which to insert: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfter(data, x);
                        break;
                    case 7:
                        Console.WriteLine("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element before which to be inserted: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data, x);
                        break;
                    case 8:
                        Console.WriteLine("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the position at which to insert: ");
                        k = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtPosition(data, k);
                        break;
                    case 9:
                        list.DeleteFirstNode();
                        break;
                    case 10:
                        list.DeleteLastNode();
                        break;
                    case 11:
                        Console.WriteLine("Enter theelement to be deleted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(data);
                        break;
                    case 12:
                        list.ReverseList();
                        break;
                    case 13:
                        list.BubbleSortExData();
                        break;
                    case 14:
                        list.BubbleSortExLinks();
                        break;
                    case 16:
                        Console.WriteLine("Enter the element which the cycle has to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertCycle(data);
                        break;
                    case 17:
                        if (list.HasCycle())
                            Console.WriteLine("List has a cycle");
                        else
                            Console.WriteLine("List does not have a cycle");
                        break;
                    case 18:
                        list.RemoveCycle();
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Exiting");
        }
    }
}
