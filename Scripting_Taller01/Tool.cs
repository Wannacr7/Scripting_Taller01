using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting_Taller01
{
    class Tool
    {


        public Stack<int> structureStack;
        public List<int> structureList;


        public Tool()
        {
           

        }
        public Tool(Stack<int> var)
        {
           structureStack = var;
            structureList = null;
            
        }
        public Tool(List<int> var)
        {
            structureList = var;
            structureStack = null;
            
        }
       


        /// <summary>
        /// llena una estructura de tipo stack o list
        /// </summary>
        /// <param name="a">primer rango del aleatorio</param>
        /// <param name="b">segunto rango del aleatorio</param>
        /// <param name="noRepet">deternima si se pueden o no repetir numeros</param>
        /// <param name="_length">determina el numero de datos a ingresar</param>
        public void FillStructure( int a, int b, bool noRepet, int _length)
        {

            
            Random r = new Random();
            int fillnumber;
            if (noRepet == true)
            {
                if (_length <= 0 || Math.Abs((a - b)) < _length)
                {
                    fillnumber = 0;
                    for (int i = 0; i < _length; i++)
                    {
                        //structure
                        
                        TypeOfStructure(fillnumber);
                    }
                }
                else
                {
                    int[] _noRepeted = new int[_length];
                    bool repeted;
                    int number;
                    int index = 0;
                    while (index < _noRepeted.Length)
                    {
                        repeted = false;
                        number = r.Next(a, b);
                        for (int i = 0; i < index; i++)
                        {
                            if (_noRepeted[i] == number)
                            {
                                repeted = true;
                            }
                        }
                        if (!repeted)
                        {
                            _noRepeted[index] = number;
                            index++;
                            TypeOfStructure(number);
                        }
                    }
                }  

            }
            else
            {
                

                for (int i = 0; i < _length; i++)
                {
                    int randomNumber = r.Next(a, b);
                    TypeOfStructure(randomNumber);
                    
                }
               
            }


            
            

        }

        /// <summary>
        /// Mira el tipo de estructura
        /// </summary>
        /// <param name="fill">Que variable va a ingresa</param>
        private void TypeOfStructure(int fill)
        {
          
            if (structureStack != null)
            {
                structureStack.Push(fill);
            }
            if (structureList != null)
            {
                structureList.Add(fill);
            }

        }

       /// <summary>
       /// Determina si un numero es primo
       /// </summary>
       /// <param name="_target"></param>
       /// <returns></returns>
        private bool PrimeNumbers(int _target)
        {
            int number = _target;
            bool breakVar = false;
            if (number > 0)
            {
                for (int j = 2; j < number - 1; j++)
                {

                    if (number % j == 0)
                    {
                        breakVar = true;
                        break;
                    }
                }
                if (!breakVar)
                {
                    return true;
                }
            }
            return false;
        }
        
        /// <summary>
        /// Determina los numetros primos de un stack y los retorna en una lista
        /// </summary>
        /// <param name="_stack"></param>
        /// <returns></returns>
        public List<int> DeterminatePrime(Stack<int> _stack)
        {
            
            List<int> primeNumbers = new List<int>();

            for (int i = 0; i < _stack.Count; i++)
            {
                

                int number = _stack.Pop();
                bool breakVar = false;
                if (number > 0)
                {
                    for (int j = 2; j < number - 1; j++)
                    {

                        if (number % j == 0)
                        {
                            breakVar = true;
                            break;
                        }
                    }
                    if (!breakVar)
                    {
                        primeNumbers.Add(number);
                    }
                }
                
            }


            return primeNumbers;
        }

        /// <summary>
        /// ordena listas
        /// </summary>
        /// <param name="_order">Lista a ordenar</param>
        /// <param name="ascendent">si es true ordena ascendente si es false descendente</param>
        /// <returns></returns>
        public List<int> OrderList(List<int> _order,bool ascendent)
        {
            _order.Sort();
            if (ascendent == true) _order.Reverse();
           
            
            return _order;
        }

        /// <summary>
        /// Determina si un numero se encuentra en una lista
        /// </summary>
        /// <param name="_target"> lista objetivo</param>
        /// <param name="_number"> numero que se busca</param>
        /// <returns></returns>
        public int NumberInList(List<int> _target, int _number)
        {
            int count = 0;
            for (int i = 0; i < _target.Count; i++)
            {
                if (_number == _target[i]) count++;
            }
            return count;
        }

        /// <summary>
        /// Returna un arreglo de una lista dada
        /// </summary>
        /// <param name="_fillList">Lista requerida</param>
        /// <returns></returns>
        public int[] ArrayFill(List<int> _fillList)
        {
            int[] returnArray = new int[_fillList.Count];
            for (int i = 0; i < returnArray.Length-1; i++)
            {
                int numb = _fillList[i];
                returnArray[i] = numb;
            }
            return returnArray;
        }

        /// <summary>
        /// Llena un diccionario a partir de un arreglo dado
        /// </summary>
        /// <param name="_array"></param>
        /// <returns></returns>
        public Dictionary<int,string> FillDictionary(int[] _array)
        {
            Dictionary<int, string> dictionaryreturn = new Dictionary<int, string>();
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] % 2 == 0) dictionaryreturn.Add(_array[i], "2");              
                else if (_array[i] % 3 == 0) dictionaryreturn.Add(_array[i], "3");
                else if (_array[i] % 5 == 0) dictionaryreturn.Add(_array[i], "5");
                else if (_array[i] % 7 == 0) dictionaryreturn.Add(_array[i], "7");
                else if (PrimeNumbers(_array[i]) == true) dictionaryreturn.Add(_array[i], "Prime");
                
            }

            return dictionaryreturn;
        }

        /// <summary>
        /// Devuelve un arreglo que acumula los elementos del mismo valos del diccionario
        /// </summary>
        /// <param name="_type"></param>
        /// <returns></returns>
        public int[] TypeValueDictionary(Dictionary<int, String> _type)
        {
            int[] typeDictionary = new int[5];
            int dos = 0, tres = 0, cinco = 0, siete = 0, prime = 0;
           

            foreach (KeyValuePair<int, string> kvp in _type)
            {
                if (kvp.Key % 2 == 0) dos++;
                else if (kvp.Key % 3 == 0) tres++;
                else if (kvp.Key % 5 == 0) cinco++;
                else if (kvp.Key % 7 == 0) siete++;
                else if (PrimeNumbers(kvp.Key) == true) prime++;
            }

            typeDictionary[0] = dos;
            typeDictionary[1] = tres;
            typeDictionary[2] = cinco;
            typeDictionary[3] = siete;
            typeDictionary[4] = prime;

            return typeDictionary;
        }

        public Dictionary<int,string> OrderDic(Dictionary<int, string> _dic)
        {
            var sortedDict = from entry in _dic orderby entry.Key descending select entry;

            var returndic = sortedDict.ToDictionary(x => x.Key, x => x.Value);

            return returndic;
        }

        
    }
}
