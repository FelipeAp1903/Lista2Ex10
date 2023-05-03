using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1;
            double p2;
            double M;



            Console.Write("insira a nota da P1 da pessoa: ");
            p1 = double.Parse(Console.ReadLine());

            Console.Write("insira a nota da P2 da pessoa: ");
            p2 = double.Parse(Console.ReadLine());



            M = (p1 + 2 * p2) / 3;

            if (M < 5)
                Console.WriteLine("Aluno(a) Reprovado.");
            else
                Console.WriteLine("Aluno(a) Aprovado.");
        }
    }
}
