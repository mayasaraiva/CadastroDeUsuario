using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeUsuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            do
            {
                Console.WriteLine("Pressione C para cadastrar um usuário ou S para sair:");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (opcao == "c")
                {
                    Console.WriteLine("Digite seu nome completo:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Pressione F para Feminino e M para Masculino:");
                    char genero = Console.ReadKey(true).KeyChar;
                    Console.WriteLine("Digite sua data de nascimento (DD/MM/AAAA):");
                    DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Digite o nome da sua rua:");
                    string endereco = Console.ReadLine();
                    Console.Clear();
                }
                else if (opcao == "s")
                {
                    Console.WriteLine("Encerrando o programa!");
                }
                else
                {
                    Console.WriteLine("Opção Inválida.");
                }
            } while ( opcao != "s");

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
