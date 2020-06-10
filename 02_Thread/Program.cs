using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _02_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando um Fluxo alternativo(paralelo)
            Thread t1 = new Thread(ThreadRepeticao);
            t1.Start();

            //Este for será executado no "fluxo principal".
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Fluxo principal: " + i);
            }

            Console.ReadKey();
        }

        //IO - tela(Monitor), Rede, Armazenamento
        //causam atrasos, lentidão ao processamento.
        //Este método vai ser executado no "fluxo paralelo".
        static void ThreadRepeticao()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Fluxo paraleleo: " + i);
            }
        }
    }
}

