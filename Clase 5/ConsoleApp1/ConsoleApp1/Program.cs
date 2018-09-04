using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();
            tinta miTintilla = new tinta();
            tinta miTinta = new tinta();
            bool todoOk;

         //  Console.WriteLine(tinta.mostrar(miTintilla));

            todoOk = miTintilla == miTinta;

            if (todoOk)
                Console.WriteLine("las tintas son iguales");
            else
                Console.WriteLine("las tintas son diferentes");


            Console.ReadKey();

        }
    }
}
