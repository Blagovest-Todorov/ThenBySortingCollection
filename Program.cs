using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.thenBySortingCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> products = new Dictionary<int, string>()
            {
                { 1, "Product 1" },                  // populating the lsit with some products !
                { 2, "Aroduct 2"},
                { 3, "Croduct 3"},
                { -1, "Croduct 3"}           // adding an element with the same value,but differen key number value, it sorts them by priorirykey
            
            }; // we create a dictionary
            Dictionary<int, string> orderedProducts = products.OrderBy(pair => pair.Value)  //sorts by Value, 
                                                               .ThenBy(pair => pair.Key) // sorts additionally by Key
                                                               .ToDictionary(pair => pair.Key, pair => pair.Value); // transforms to pair key-Velue

            Console.WriteLine(string.Join("  ", orderedProducts)); // prints teh result alphabethically 
            // we are moving aroung the entries ordering them by value

        }
    }
}
