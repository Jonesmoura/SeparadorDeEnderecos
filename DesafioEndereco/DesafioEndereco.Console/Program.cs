using System;
using System.Runtime.CompilerServices;
using DesafioEndereco.Model;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione enter para iniciar o programa");
            Console.ReadLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Processamento de Endereços:\n");
            Console.WriteLine("Caso 1: ");

            Console.WriteLine("Endereço 1: ");
            string stringEndereco1 = "Miritiba 339";
            Endereco endereco1 = new Endereco(stringEndereco1);
            Console.WriteLine("Entrada: " + stringEndereco1 + " -> Saída: "+ endereco1.ToString());

            Console.WriteLine("Endereço 2: ");
            string stringEndereco2 = "Babaçu 500";
            Endereco endereco2 = new Endereco(stringEndereco2);
            Console.WriteLine("Entrada: " + stringEndereco2 + " -> Saída: " + endereco2.ToString());

            Console.WriteLine("Endereço 3: ");
            string stringEndereco3 = "Cambuí 804B";
            Endereco endereco3 = new Endereco(stringEndereco3);
            Console.WriteLine("Entrada: " + stringEndereco3 + " -> Saída: " + endereco3.ToString());

            Console.WriteLine("Caso 2");

            Console.WriteLine("Endereço 4: ");
            string stringEndereco4 = "Rio Branco 23";
            Endereco endereco4 = new Endereco(stringEndereco4);
            Console.WriteLine("Entrada: " + stringEndereco4 + " -> Saída: " + endereco4.ToString());

            Console.WriteLine("Endereço 5: ");
            string stringEndereco5 = "Quirino dos Santos 23 b";
            Endereco endereco5 = new Endereco(stringEndereco5);
            Console.WriteLine("Entrada: " + stringEndereco5 + " -> Saída: " + endereco5.ToString());

            Console.WriteLine("Caso 3");

            Console.WriteLine("Endereço 6: ");
            string stringEndereco6 = "4, Rue de la République";
            Endereco endereco6 = new Endereco(stringEndereco6);
            Console.WriteLine("Entrada: " + stringEndereco6 + " -> Saída: " + endereco6.ToString());

            Console.WriteLine("Endereço 7: ");
            string stringEndereco7 = "100 Broadway Av";
            Endereco endereco7 = new Endereco(stringEndereco7);
            Console.WriteLine("Entrada: " + stringEndereco7 + " -> Saída: " + endereco7.ToString());

            Console.WriteLine("Endereço 8: ");
            string stringEndereco8 = "Calle Sagasta, 26";
            Endereco endereco8 = new Endereco(stringEndereco8);
            Console.WriteLine("Entrada: " + stringEndereco8 + " -> Saída: " + endereco8.ToString());

            Console.WriteLine("Endereço 9: ");
            string stringEndereco9 = "Calle 44 No 1991";
            Endereco endereco9 = new Endereco(stringEndereco9);
            Console.WriteLine("Entrada: " + stringEndereco9 + " -> Saída: " + endereco9.ToString());


            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Pressione enter para finalizar o programa.");
            Console.ReadLine();

        }
    }
}
