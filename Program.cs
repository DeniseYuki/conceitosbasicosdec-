using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

            var dic = new Dictionary<string, int>();
            id = 0;
            Console.WriteLine("ID: "+ id);
           
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();

            

            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            
            // adicionando ao dicionario nome e id
            dic.Add($"Nome : { nome }"+" ID :  ", id);
            
            Console.WriteLine("Digite o nome da sua cidade: ");
            cidade = Console.ReadLine();
            foreach (var item in dic)

                Console.WriteLine(item.Key + item.Value);

            Console.WriteLine("Deseja continuar cadastrando? [0/1]");
            continuar = int.Parse(Console.ReadLine());

            while (continuar == 0)
               
            if (continuar == 0)
                {
                    id++;
                    var cadastro = new Dictionary<string, int>();

                    Console.WriteLine("ID: " + id);
                    
                    Console.WriteLine("Digite seu nome");
                    nome = Console.ReadLine();
                    //cadastro.Add($"Nome : { nome }" + " ID :  ", id);
                    
                    Console.WriteLine("Digite sua idade: ");
                    idade = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o nome da sua cidade: ");
                    cidade = Console.ReadLine();
                   
                    Console.WriteLine("Deseja continuar cadastrando? [0/1]");
                    continuar = int.Parse(Console.ReadLine());
                    cadastro.Add($"Nome : { nome }" + " ID :  ", id);
                    foreach (var item in cadastro)
                    {
                        Console.WriteLine(item.Key +  item.Value );
                        if (continuar == 1)
                        break;
                        //Console.Write(" Cadastro Finzalizado!!");
                        

                    }
                }


            Console.WriteLine("Cadastro Finzalizado!!");

           // foreach (var item in dic)
            {
                //Console.WriteLine(item.Key + item.Value);












                Console.ReadKey();
        }

        }
    }
}
