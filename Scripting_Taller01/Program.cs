using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting_Taller01
{
    class Program
    {
        static void Main(string[] args)
        {

            int iteractions=20;
            int numbertosearch = 2;

            Stack<int> teststack = new Stack<int>();
            List<int> autoGeList=new List<int>();
            List<int> firstPoint = new List<int>();
            List<int> secondPoint = new List<int>();
            List<int> thirdPoint = new List<int>();
            int[] testup;
            Dictionary<int, string> thirdDictionary;
            Dictionary<int, string> orderDictionary;
            int[] typeDictionary;

            Tool testing = new Tool(teststack);
            Tool testing1 = new Tool(autoGeList);
            Tool arrayCreation = new Tool(thirdPoint);
            Tool empty = new Tool();
            


            //stack
            testing.FillStructure(-100, 56, false, 20);
            teststack = testing.structureStack;

            //list
            testing1.FillStructure(-100,100, false, 40);
            autoGeList = testing1.structureList;
            //for (int i = 0; i < test1.Count; i++) Console.WriteLine(test1[i] + " , ");

            //Array
            arrayCreation.FillStructure(-100, 100, true, 20);
            thirdPoint = arrayCreation.structureList;
            testup= arrayCreation.ArrayFill(thirdPoint);


            //Devuelve primos
            firstPoint = empty.DeterminatePrime(teststack);
            Console.WriteLine("valor primo de la stack");
            for (int i = 0; i < firstPoint.Count; i++) Console.WriteLine(firstPoint[i] + "  first");//asi no hay problema cuando no hay valor en la posición 0
            

            //ordenalista
            secondPoint = empty.OrderList(autoGeList,true);
            Console.WriteLine("Ordena lista y busca numero en ella");
            for (int i = 0; i < secondPoint.Count; i++) Console.WriteLine(secondPoint[i] + "  Second");
            Console.WriteLine("El numero: "+numbertosearch+" esta: "+empty.NumberInList(secondPoint,numbertosearch));

            //mira arreglo 
            Console.WriteLine("Mira el arreglo creado");
            for (int i = 0; i < testup.Length; i++) Console.WriteLine(testup[i] + "  third");
            thirdDictionary = empty.FillDictionary(testup);
            typeDictionary = empty.TypeValueDictionary(thirdDictionary);
            Console.WriteLine("Mira el diccionario");
            foreach (KeyValuePair<int, string> kvp in thirdDictionary)
            {
                //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine("tipodiccionario");
            Console.WriteLine("multiplos de dos, tres, cinco, siete, primos");
            for (int i = 0; i < typeDictionary.Length; i++) Console.WriteLine(typeDictionary[i]);
            Console.WriteLine("Orden ascendente");
            orderDictionary = empty.OrderDic(thirdDictionary);
            foreach (KeyValuePair<int, string> kvp in orderDictionary)
            {
                //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }







            Console.ReadKey();
        }
    }
}
