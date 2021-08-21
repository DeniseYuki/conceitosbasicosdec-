using System;

namespace Desafio00
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            String nome;
            int idade;
            String cidade;
            int continuar;

            id = 0;
            Console.WriteLine("ID: "+ id);

            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da sua cidade: ");
            cidade = Console.ReadLine();
        
        
            Console.WriteLine("Deseja continuar cadastrando? [0/1]");
            continuar = int.Parse(Console.ReadLine());

            while (continuar == 0)
               // id++;
            //Console.WriteLine(id);
            if (continuar == 0)
                {
                    id++;
                    Console.WriteLine("ID: " + id);
                    
                    Console.WriteLine("Digite seu nome");
                    nome = Console.ReadLine();

                    Console.WriteLine("Digite sua idade: ");
                    idade = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o nome da sua cidade: ");
                    cidade = Console.ReadLine();
                    //continue;
                    Console.WriteLine("Deseja continuar cadastrando? [0/1]");
                    continuar = int.Parse(Console.ReadLine());
                    

                    if (continuar == 1)
                        break;
                       //Console.Write("Cadastro Finzalizado!!");
                }
            Console.Write("Cadastro Finzalizado!!");
            













            Console.ReadKey();
        }
    }
}
