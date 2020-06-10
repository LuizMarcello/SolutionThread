using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _05_ThreadSafe
{
    class Program
    {
        static int rede = 0;
        static object variavelDeControle = 0;

        //IO - Imput/Output Lento(tela, Rede, Armazenamento, impressora-rede)
        static void Main(string[] args)
        {
            Console.WriteLine("DataIni: " + DateTime.Now);

            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeticao);
                //Esta propriedade fará com que as threads fiquem totalmente
                //dependentes do fluxo principal, do "static void main".
                //Quando ele está executando, eleas continuam, quando ele
                //para, elas também param. Muito bom!
                t1.IsBackground = true;
                t1.Start();
            }
            Console.ReadKey();
        }

        //IO - tela(Monitor), Rede, Armazenamento
        //causam atrasos, lentidão ao processamento.
        //Este método vai ser executado no "fluxo paralelo".
        static void ThreadRepeticao()
        {
            //FIFO - First in first out
            for (int i = 0; i < 1000; i++)
            {
                lock (variavelDeControle)
                {
                    Console.WriteLine("Fluxo paraleleo: " + i);
                    rede++;
                }
            }


            Console.WriteLine("DataIni: " + DateTime.Now);
        }

    }
}

