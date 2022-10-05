using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            soma objb = new soma();
            Console.WriteLine(objb.letras());
            Console.WriteLine("digite o primeiro numero ");
            objb.numero1 = int.Parse (Console.ReadLine());
            Console.WriteLine("digite o segundo numero ");
            objb.numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o terceiro numero ");
            objb.numero3 = int.Parse(Console.ReadLine());

            Console.WriteLine("resultado da soma dos tres numeros : " + objb.somaa (objb.numero1 , objb.numero2,objb.numero3));




        }
    }
}
