using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variável
            int idade = 0;
            int ano = 0; //ano de nascimento
            int ano2 = ano - 2020;  //ano atual
            int semanas = (idade * 7);


            //Entrada de dados
            Console.WriteLine("Insira sua idade");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira seu ano de nascimento");
            ano = int.Parse(Console.ReadLine());

            //Processamento
            System.Console.WriteLine("Idade em anos : " + ano);
            System.Console.WriteLine("Idade em semanas: " + semanas);
            System.Console.WriteLine("Ano atual: " +ano2);
        }
    }
}
