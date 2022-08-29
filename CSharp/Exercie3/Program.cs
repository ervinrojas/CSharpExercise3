using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> listString = new List<string>();
            List<int> listInt = new List<int>();

            listString.Add("Text");
            listString.Add("Computer");
            listString.Add("Automation");
            listString.Add("Visual Studio");
            listString.Add("Auto Parts");

            listInt.Add(1);
            listInt.Add(1);
            listInt.Add(2);
            listInt.Add(3);
            listInt.Add(4);
            listInt.Add(4);
            listInt.Add(5);
            listInt.Add(6);
            listInt.Add(7);
            listInt.Add(8);
            listInt.Add(10);

            
            Console.Write("Give 1. word >");
            String word1 = Console.ReadLine();
            Console.Write("Give 2. word >");
            String word2 = Console.ReadLine();

            ClassA prueba = new ClassA();
            prueba.lengthString(word1, word2);

            ClassA size = new ClassA();
            size.sizeList(listString,listInt);

            ClassB inherits = new ClassB();
            inherits.sizeList(listString,listInt);
            
            ClassB Test = new ClassB();
            Test.Test();

            
            int opc;

            Console.WriteLine("1. Orden Ascendente");
            Console.WriteLine("2. Orden Descendente");
            opc = int.Parse(Console.ReadLine());

            ClassC Order = new ClassC();
            Order.orderLists(opc,listString,listInt);

            ClassC filter = new ClassC();
            filter.Filters(listInt);
            
        }
    }

interface IInterface
    {
        void Test();
    }

}
