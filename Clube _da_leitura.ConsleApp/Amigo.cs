using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube__da_leitura.ConsleApp
{
    internal class Amigo
    {
        public string  nome ;
        public string nomeResponsavel;
        public int  telefone;
        public string endereco ;
        public bool comEmprestimo;
       

      /*  public void EditarCadastro()
        {
             visualizarCadastro();
            if (idCadastro == 0)
            {
                Console.WriteLine("Sem cadastro!");
            }
            else
            {
                Console.ReadKey();
                Console.WriteLine("\nInforme o Id do cadastro que deseja Editar: ");
                int editarIDCadastro = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual Informação do Cadastro do" + nome[idCadastro] + " deseja Editar?\n");
                Console.WriteLine("\n1-Nome \n2- Responsavel\n3- Telefone\n4- Enderenço");
                int editarCadastro = int.Parse(Console.ReadLine());

                if (editarCadastro == 1)
                {
                    Console.WriteLine("\nNome:");
                    string editarNome = Console.ReadLine();

                    nome[editarIDCadastro] = editarNome;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nInformação Editada com Sucesso!");
                    Console.ResetColor();
                    Console.ReadKey();
                }
                else if (editarCadastro == 2)
                {
                    Console.WriteLine("\nNome Responsavel:");
                    string editarResponsavel = Console.ReadLine();

                    nomeResponsavel[editarIDCadastro] = editarResponsavel;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nInformação Editada com Sucesso!");
                    Console.ResetColor();
                    Console.ReadKey();
                }

                else if (editarCadastro == 3)
                {
                    Console.WriteLine("\nDigite novo Nº de Série:");
                    int editartelefone = int.Parse(Console.ReadLine());

                    telefone[editarIDCadastro] = editartelefone;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nInformação Editada com Sucesso!");
                    Console.ResetColor();
                    Console.ReadKey();
                }
                else if (editarCadastro == 4)
                {
                    Console.WriteLine("\nNovo endereço:");
                    string editarEndereco = Console.ReadLine();

                    endereco[editarIDCadastro] =  editarEndereco;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nInformação Editada com Sucesso!");
                    Console.ResetColor();
                    Console.ReadKey();
                }


            }
        }*/

    }
}
