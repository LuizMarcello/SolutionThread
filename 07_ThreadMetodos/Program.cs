using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _07_ThreadMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread Sleep()-Determina em milissegundos, quanto tempo 
            //a thread tem que esperar antes de prosseguir
            Console.WriteLine("Inicio do nosso programa");
            Thread.Sleep(5000);
            Console.WriteLine("Termino do nosso progama");

            Thread t1 = new Thread(ThreadRepeticao);
            t1.Start();
            //Thread Join()-Espera a execução da referida thread
            //terminar, para a thread principal(fluxo do programa)
            //prosseguir
            t1.Join();

            Console.WriteLine("Mensagem para ser exibida");
            Console.WriteLine("Mensagem para ser exibida");
            Console.WriteLine("Mensagem para ser exibida");
            Console.WriteLine("Mensagem para ser exibida");

            Console.ReadKey();
        }

        static void ThreadRepeticao(object Id)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Fluxo paralelo - Thread " + Id + " num: " + i + " Id interno: " + Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
            
