using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp7
{
    class Program
    {
        static void BubbleSort(List<int> minLista)
        {
            for (int i = 0; i < minLista.Count; i++)
            {
                for (int j = 0; j < minLista.Count - 1; j++)
                {
                    if (minLista[j] > minLista[j + 1]) //om elementen ligger i fel ordning
                    {
                        //Byt plats på elementen med j med det på j+1
                        int temp = minLista[j];
                        minLista[j] = minLista[j + 1];
                        minLista[j + 1] = temp;
                    }
                }
            }
        }        
        static void Main(string[] args)
        {
            var tallista = new List<int>();            

            Random slump = new Random()
            for (int i = 0; i < 100000; 1++)
            {
                
            }

            BubbleSort(tallista);
            Console.WriteLine("Listan är sorterad!");
        }       
    }
}