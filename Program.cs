using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluación
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Generar matriz nxm de rango 6 a 15, debe llenarse con letras minusculas y se pedira al usuario una frase 
            //Se buscara en la matriz las palabras de la frase y dira si se encuentra y donde.

            int n, m;
            n = rnd.Next(6, 16);
            m = rnd.Next(6, 16);
            string[,] matriz = new string[n, m];

            Console.WriteLine("MATRIZ DE LETRAS: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    char c = (char)rnd.Next('a', 'z'+ 1);
                    matriz[i, j] = c.ToString();
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.Write("\nIngrese una frase --> ");
            string frase = Console.ReadLine().ToLower();
          
            string fcont = "";
            int conf = 0;
            for (int i = 0; i < n ; i++) 
            {
                fcont = "";
                for (int j = 0;j < m ; j++)
                {
                    fcont += matriz[i, j];
                }
                foreach (string palabra in frase.Split(' '))
                {
                    if (fcont.Contains(palabra))
                    {
                        Console.WriteLine("\nLa palabra {0} se encuentra en la fila {1}", palabra, i+1);
                        conf++;
                    }
                }
            }

            string contc = "";
            int contac = 0;
            for (int j = 0; j < m; j++)
            {
                contc = "";
                for (int i = 0; i < n; i++)
                {
                    contc += matriz[i, j];
                }
                foreach (string palabra in frase.Split(' '))
                {
                    if (contc.Contains(palabra))
                    {
                        Console.WriteLine("La palabra {0} se encuentra en la columna {1}", palabra, j+1);
                        contac++;
                    }
                }
            }
            if (conf == 0 & contac == 0)
            {
                Console.WriteLine("Ninguna palabra se encuentra en la matriz.");
            }

            Console.ReadKey();
        }
    }
}