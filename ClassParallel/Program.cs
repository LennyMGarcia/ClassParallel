using System;
using System.Threading;
using System.Threading.Tasks;

namespace ClassParallel
{
    class Program
    {
        private static int acumulador = 0;
        static void Main(string[] args)
        {
            /* for(int i=0;i<100;i++)
             {
                 RealizarTarea(i);
                 Console.WriteLine($"Acumulador vale {acumulador} tarea realizada por el hilo> {Thread.CurrentThread.ManagedThreadId}");
             }*/
            //la clase paraller hace lo mismo que el for y se agrega el metodo, se hace de forma concurrente osea por varias tareas
            // Parallel.For(0,100, RealizarTarea);

           
        }

        static void RealizarTarea(int dato)
        {
            Console.WriteLine($"Acumulador vale {acumulador} tarea realizada por el hilo> {Thread.CurrentThread.ManagedThreadId}");
            if ((acumulador%2)==0)
            {
                acumulador += dato;
                Thread.Sleep(100);
            }
            else
            {
                acumulador -= dato;

                Thread.Sleep(100);
            }

        }

        
        
    }
   

     
}
