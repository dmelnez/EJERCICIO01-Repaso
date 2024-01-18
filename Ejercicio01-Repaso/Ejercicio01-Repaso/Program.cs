
using System.Security.Cryptography;

class Program
{

    static void Main(string[] args)
    {
        /*
        

       
        

        = numeroMinutos / (8*60) ;
        = numeroMinutos / (8 * 60) /60;
         = numeroMinutos % 60;

        string trabajado = "Has Trabajado: ";


        if (numDias > 1)
        {
            Console.WriteLine(trabajado + numDias + " dias");

        }
        else
        {
            Console.WriteLine(trabajado + numDias + " dia");
        }

        if (numHoras > 1)
        {
            Console.WriteLine(trabajado + numHoras + " horas");
        }
        else
        {
            Console.WriteLine(trabajado + numHoras + " hora");
        }

        if (numMinutos > 1)
        {
            Console.WriteLine(trabajado + numeroMinutos + " minutos");
        }
        else
        {
            Console.WriteLine(trabajado + numeroMinutos + " minuto");
        }
        */

        Console.WriteLine("###################################");
        Console.WriteLine("# Introduzca el Numero de Minutos #");
        Console.WriteLine("###################################");
        int numeroMinutos = Convert.ToInt32(Console.ReadLine());




        int numDias = numeroMinutos / (8 * 60);
        int numHoras = numeroMinutos % (8 * 60) / 60;
        int numMinutos = numeroMinutos % 60;

        string trabajo = "Has trabajado: ";

        if (numDias > 1)
        {
            Console.WriteLine(trabajo + numDias + " dias");

        }
        else
        {
            Console.WriteLine(trabajo + numDias + " dia");
        }

        if (numHoras > 1)
        {
            Console.WriteLine(trabajo + numHoras + " horas");
        }
        else
        {
            Console.WriteLine(trabajo + numHoras + " hora");
        }

        if (numMinutos > 1)
        {
            Console.WriteLine(trabajo + numMinutos + " minutos");
        }
        else
        {
            Console.WriteLine(trabajo + numMinutos + " minuto");
        }


    }
}


    