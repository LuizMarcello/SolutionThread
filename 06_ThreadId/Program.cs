using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _06_ThreadId
{
    class Program
    {
        //Método main é a thread principal
        static void Main(string[] args)
        {
            //Este "for" será no fluxo principal
            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeticao);
                t1.Start(i);
            }
            Console.ReadKey();
        }

        //IO - tela(Monitor), Rede, Armazenamento
        //causam atrasos, lentidão ao processamento.
        //Este método vai ser executado no "fluxo paralelo".
        static void ThreadRepeticao(object Id)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Fluxo paralelo - Thread " + Id + " num: " + i + " Id interno: " + Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}




