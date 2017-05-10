using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();

            Console.WriteLine("Adding some elements as numbers:");
            myArrayList.Add(45);
            myArrayList.Add(78);
            myArrayList.Add(33);
            myArrayList.Add(56);
            myArrayList.Add(12);
            myArrayList.Add(23);
            myArrayList.Add(9);

            Console.WriteLine("ArrayList Capacity: {0} ", myArrayList.Capacity);
            Console.WriteLine("ArrayList Count: {0}", myArrayList.Count);

            Console.Write("ArrayList Content: ");
            //To print all the ArrayList elements, we must use the property Count not Capacity
            //Because Capacity reflect the whole capacity of the arraylist, while the Count reflect
            // the actual number of elements in the arraylists
            for (int i = 0; i < myArrayList.Count; i++)
                Console.Write(myArrayList[i].ToString() + " ");

            Console.WriteLine();
            Console.Write("Sorted Content: ");
            myArrayList.Sort();
            foreach (int i in myArrayList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
