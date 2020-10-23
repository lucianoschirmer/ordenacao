using System;
using System.Collections.Generic;
using System.Linq;

namespace Ordenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            byte[] values = new byte[10000];
            random.NextBytes(values);
            Console.WriteLine(string.Join(", ", values));
            Console.WriteLine("##################");

            //byte[] a = values;
            //var min = values.Min();
            //var max = values.Max();
            ////byte[] a = aqui colocaria meus numeros da lista;
            //List<byte[]> bit = new List<byte[]>();

            //for (max = 0; min < 3; values.Length ++)
            //{

            //}
            //Console.WriteLine(string.Join(", ", min));
            //Console.WriteLine(string.Join(", ", max));
            //Console.WriteLine(string.Join(", ", a));
            //Console.WriteLine(string.Join(", ", values));
            //percorre a lista até o fim, verificando a ordem dos elementos de dois em dois, e trocando de lugar se necessário.
            //Percorre a lista até que nenhum elemento tenha sido trocado de lugar na passagem anterior

            byte shitTemporaria = 0;
            //ler minha lista e comparar valores quais sao os menores
            for (int vapoVapo = 0; vapoVapo < values.Length; vapoVapo++) // sequencia de toma toma sequencia de vapo vapo/ le a lista ate o fim
            {
                for (int ordenaEssaPorra = 0; ordenaEssaPorra < values.Length - 1; ordenaEssaPorra++) //compara de 2 em 2
                {
                    if (values[ordenaEssaPorra] > values[ordenaEssaPorra + 1]) //ponteiro da porra toda recebendo a porra da lista e fazendo a troca
                    {
                        shitTemporaria = values[ordenaEssaPorra + 1];
                        values[ordenaEssaPorra + 1] = values[ordenaEssaPorra]; // pra mudar a ordem só trocar o o > pra <
                        values[ordenaEssaPorra] = shitTemporaria;
                    }
                }
            }
            for (int i = 0; i < values.Length; i++)
                Console.Write(values[i] + " "); //vapo
            Console.ReadKey();
        }
    }
}
