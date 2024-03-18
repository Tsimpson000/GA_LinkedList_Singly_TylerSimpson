namespace GA_LinkedList_Singly_TylerSimpson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.Add(10);
            linkedList.Add(20);
            linkedList.Add(30);

            Console.WriteLine("Linked List elements:");
            linkedList.Display();

            Console.WriteLine("Count of elements: " + linkedList.Count);

            int indexToAccess = 1;
            Console.WriteLine($"Element at index {indexToAccess}: {linkedList[indexToAccess]}");

            int valueToRemove = 20;
            if (linkedList.Remove(valueToRemove))
            {
                Console.WriteLine($"Removed {valueToRemove} from the list.");
            }
            else
            {
                Console.WriteLine($"{valueToRemove} not found in the list.");
            }

            Console.WriteLine("Updated Linked List elements:");
            linkedList.Display();

            Console.ReadLine();
        }
    }
}
