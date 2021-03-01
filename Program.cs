using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadePessoa
{
    class Program
    {
        static void Main(string[] args)
        {


            
            


            Console.WriteLine("============= IDADE DE UMA PESSOA EM ANOS =========================");

            Console.Write("Insira sua idade em dias : ");
            int dias = int.Parse(Console.ReadLine());

            int ano = (dias / 365); // dias divide por 365 que equivale a 1 ano 
            int mes = (dias % 365 ) / 30; // dias dividie por 365, o resto da divisão  e dividido por  30 que equivale a 1 mes 
            int dia = (dias % 365) % 30;  // dias divide por 365 e usa o resto da divisão que divide por 30


            Console.WriteLine("O resultado é de {0}/{1}/{2}", dia,mes,ano);


        }
    }
}