using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos_Bidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arreglo_bidimensional = new int[2, 5];
            arreglo_bidimensional[0, 0] = 36;
            arreglo_bidimensional[1, 0] = 39;
            arreglo_bidimensional[0, 1] = 23;
            arreglo_bidimensional[1, 1] = 40;
            arreglo_bidimensional[0, 2] = 5;
            arreglo_bidimensional[1, 2] = 1;
            arreglo_bidimensional[0, 3] = 4;
            arreglo_bidimensional[1, 3] = 78;
            arreglo_bidimensional[0, 4] = 3;
            arreglo_bidimensional[1, 4] = 65;



            Console.WriteLine($"La suma es: {sumaArregloBidemensional(arreglo_bidimensional).ToString()}");
            Console.WriteLine($"El número mayor es: {NumeroMayor(arreglo_bidimensional).ToString()}");
            Console.WriteLine($"El número menor es: {NumeroMenor(arreglo_bidimensional).ToString()}");
            Console.WriteLine($"El promedio es: {PromedioArregloBidemensional(arreglo_bidimensional).ToString()}");
            SumarElementosPorFila(arreglo_bidimensional);
            int numeroMultiplicador = 2;
            MultiplicarElementosPorNumero(arreglo_bidimensional, numeroMultiplicador);
            int limite = 20;
            Console.WriteLine($"Elementos mayores que {limite}: {ContarElementosMayoresQue(arreglo_bidimensional, limite)}");

            Console.ReadLine();


        }

        public static int sumaArregloBidemensional(int[,] arreglo_)
        {
            int resultado = 0;
            for (int i = 0; i < arreglo_.GetLength(0); i++)
            {
                for (int j = 0; j < arreglo_.GetLength(1); j++)
                {
                    resultado = resultado + arreglo_[i, j];
                }
            }

            return resultado;
        }

        public static int NumeroMayor(int[,] arreglo_)
        {
            int numero_mayor = arreglo_[0, 0];
            for (int i = 0; i < arreglo_.GetLength(0); i++)
            {
                for (int j = 0; j < arreglo_.GetLength(1); j++)
                {
                    if (arreglo_[i, j] > numero_mayor)
                    {
                        numero_mayor = arreglo_[i, j];
                    }
                }
            }

            return numero_mayor;
        }

        public static int NumeroMenor(int[,] arreglo_)
        {
            int numero_menor = arreglo_[0, 0];
            for (int i = 0; i < arreglo_.GetLength(0); i++)
            {
                for (int j = 0; j < arreglo_.GetLength(1); j++)
                {
                    if (arreglo_[i, j] < numero_menor)
                    {
                        numero_menor = arreglo_[i, j];
                    }
                }
            }

            return numero_menor;
        }

        public static decimal PromedioArregloBidemensional(int[,] arreglo_)
        {
            int sumador = 0;
            int contador = 0;
            decimal resultado = 0;
            for (int i = 0; i < arreglo_.GetLength(0); i++)
            {
                for (int j = 0; j < arreglo_.GetLength(1); j++)
                {
                    sumador = sumador + arreglo_[i, j];
                    contador = contador + 1;
                }
            }
            resultado = sumador / contador;
            return resultado;
        }

        public static void SumarElementosPorFila(int[,] matriz_)
        {

            for (int i = 0; i < matriz_.GetLength(0); i++)
            {
                int sumfila = 0;
                for (int j = 0; j < matriz_.GetLength(1); j++)
                {
                    sumfila = sumfila + matriz_[i, j];
                }

                Console.WriteLine($"La suma de los elementos de la fila {i} es: {sumfila}");
            }

        }

        public static void MultiplicarElementosPorNumero(int[,] matriz_, int numero)
        {
            Console.WriteLine($"Matriz multiplicada por {numero}:");

            for (int i = 0; i < matriz_.GetLength(0); i++)
            {
                for (int j = 0; j < matriz_.GetLength(1); j++)
                {
                    matriz_[i, j] = matriz_[i, j] * numero; 
                    Console.Write(matriz_[i, j] + " "); 
                }
                Console.WriteLine(); 
            }
        }

        public static int ContarElementosMayoresQue(int[,] matriz_, int limite)
        {
            int contador = 0;
            for (int i = 0; i < matriz_.GetLength(0); i++)
            {
                for (int j = 0; j < matriz_.GetLength(1); j++)
                {
                    if (matriz_[i, j] > limite)
                    {
                        contador++;
                    }
                }
            }
            return contador;
        }

    }
}
