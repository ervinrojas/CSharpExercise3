using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercie3
{
    internal class ClassA
    {
        public void lengthString(string word1, string word2)
        {
            if (word1.Length > word2.Length)
            {
                Console.Write("String One is longer.");
            }
            else
            {
                Console.Write("String Two is longer.");
            }
        }

        public void sizeList(List<String> listString, List<int> listInt)
        {
            
            Console.WriteLine($"\n tamaño de la lista String es: " + listString.Count);
            Console.WriteLine($"\n tamaño de la lista Int es: " + listInt.Count);

            if (listString.Count > listInt.Count)
            {
                Console.Write("List One is longer.");
            }
            else
            {
                Console.Write("List Two is longer.");
            }
                                    
        }
    }

    class ClassB:ClassA, IInterface
    {
        public void Test()
        {
            Console.WriteLine("\n Hello Interface");
        }
    }

    class ClassC
    {
        public void orderLists(int opc, List<string> listString, List<int> listInt)
        { 
            

            if (opc == 1)
            { 
                //List<listString> orderList = list.OrderBy(listString => listString.Object).ToList();
                var orderList = listString.OrderBy(x=>x.Substring(0));
                foreach (string Item in orderList)
                Console.WriteLine(Item);
            }
            else
            {
                //List<listString> orderList = list.OrderByDescending(listString => listString.Object)/*.ThenByDescending(listString => listString.Object).ToList();
                var orderList = listString.OrderByDescending(x =>x.Substring(0));
                foreach (string Item in orderList)
                Console.WriteLine(Item);
            }
                        
        }

        public void Filters(List<int> listInt)
        {
            Console.WriteLine("List with duplicates");
            listInt.ForEach(Console.WriteLine);

            List<int> uniqueList = listInt.Distinct().ToList();
            Console.WriteLine("List after removing duplicates");
            uniqueList.ForEach(i => Console.WriteLine($"{i}"));
            Console.ReadLine();
        }
    }
    
    class listString
    {
        public String Object { get; set; }
    }

    class listInt
    {
        public int Number { get; set; }
    }
    
}
