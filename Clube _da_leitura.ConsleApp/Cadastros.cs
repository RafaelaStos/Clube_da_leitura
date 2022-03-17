using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube__da_leitura.ConsleApp
{ 
    internal class Cadastros
    {
        public Amigo[] amigos = new Amigo[100];
        public int idAmigo = 0;

        public Revista[] revistas = new Revista[100];
        public int idRevista = 0;

        public Caixa[] caixas = new Caixa[100];
        public int idCaixa = 0;

        public Emprestimo[] emprestimos = new Emprestimo[100];
        public int idEmprestimos;

        #region Cadastro
        public void obterAmigo()
        {
            Amigo cadastroAmigos = new Amigo();
            Console.WriteLine("Nome: ");
            string nomeAmigo = Console.ReadLine();
            cadastroAmigos.nome = nomeAmigo;
            Console.WriteLine("Nome do Responsavel:");
            string responsavel = Console.ReadLine();
            cadastroAmigos.nomeResponsavel = responsavel;
            Console.WriteLine("Telefone: ");
            int telefoneAmigo = int.Parse(Console.ReadLine());
            cadastroAmigos.telefone = telefoneAmigo;
            Console.WriteLine("Endereço: ");
            string enderecoAmigo = Console.ReadLine();
            cadastroAmigos.endereco = enderecoAmigo;
            cadastroAmigos.comEmprestimo = false;

            amigos[idAmigo] = cadastroAmigos;

            idAmigo++;
        }

        public void obterCaixa()
        {
            Caixa cadastroCaixa = new Caixa();

            Console.WriteLine("Informe a cor: ");
            string corCaixa = Console.ReadLine();
            cadastroCaixa.cor = corCaixa;
            Console.WriteLine("Informe etiqueta: ");
            string etiquetaCaixa = Console.ReadLine();
            cadastroCaixa.etiqueta = etiquetaCaixa;
            Console.WriteLine("Informe o numero de serie da caixa: ");
            int serie = int.Parse(Console.ReadLine());
            cadastroCaixa.NumeroSerie = serie;

            caixas[idCaixa] = cadastroCaixa;
            idCaixa++;
        }
        public void obterrRevista()
        {
            Revista cadastroRevista = new Revista();
            
            Console.WriteLine("Informe Coleção da revista: ");
            string colecao = Console.ReadLine();
            cadastroRevista.tipoColecao = colecao;
            Console.WriteLine("Informeo numero da edição: ");
            int edicao = int.Parse(Console.ReadLine());
            cadastroRevista.numeroEdicao = edicao;
            Console.WriteLine("Informe o ano da revista: ");
            int ano = int.Parse(Console.ReadLine());
            cadastroRevista.anoRevista= ano;
            Console.WriteLine("Informe o id da caixa que deseja guardar:");
            int idC =int.Parse(Console.ReadLine());
            cadastroRevista.cadastroCaixa = caixas[idC];

            revistas[idRevista]=cadastroRevista;
            idRevista++;
        
        }

        public void obterEmprestimo()
        {
            Emprestimo cadastroEmprestimo=new Emprestimo();
            obterAmigo();
            Console.Write("\nInforme o id do amigo: ");
            int idA = int.Parse(Console.ReadLine());
            cadastroEmprestimo.cadastrarAmigo = amigos[idA]; 
           // empretimoRevista.visualizarRevista();
            Console.WriteLine("\nInforme o id da revista: ");
            int idR = int.Parse(Console.ReadLine());
            cadastroEmprestimo.cadastraRevista = revistas[idR];
            Console.WriteLine("Data de emprestismo: ");
            DateTime dia = Convert.ToDateTime(Console.ReadLine());

            cadastroEmprestimo.statusEmprestimo = true;
            emprestimos[idEmprestimos] =cadastroEmprestimo;
            idEmprestimos++;


        }

        #endregion

       
       #region Visualizar
        public void visualizarAmigo()
        {
            if (idAmigo != -1)
            {
                Console.WriteLine("Lista de AMIGOS");
                for (int i = 0; i < idAmigo; i++)
                {
                    Console.WriteLine("\n==============================================");
                    Console.WriteLine("ID"+i+"Cor: " + amigos[i].nome + "\nResponsavel: " + amigos[i].nomeResponsavel + "\nTelefone: " + amigos[i].telefone + "\nEndereço: " + amigos[i].endereco);
                    Console.WriteLine("\n==============================================");
                }
            }
            else Console.WriteLine("Não possui cadastro ");
        }

        public void visualizarCaixa()
        {
            if (idCaixa != -1)
            {
                Console.WriteLine("Lista  de Caixas");
                for (int i = 0; i < idCaixa; i++)
                {
                    Console.WriteLine("\n==============================================");
                    Console.WriteLine("ID"+i+"Cor: " + caixas[i].cor + "\nEtiqueta: " + caixas[i].etiqueta + "\nNumero de Serie: " + caixas[i].NumeroSerie);
                    Console.WriteLine("\n==============================================");
                }
            }
            else Console.WriteLine("Não possui cadastro ");
        }

        public void visualizarRevista()
        {
            if (idRevista != -1)
            {
                Console.WriteLine("Lista de revista");
                for (int i = 0; i < idRevista; i++)
                {
                    Console.WriteLine("\n==============================================");
                    Console.WriteLine("ID" + i + "Coleção: " + revistas[i].tipoColecao + "\nEdição: " + revistas[i].numeroEdicao + "\nAno: " + revistas[i].anoRevista+"\nCaixa"+revistas[i].cadastroCaixa);
                    Console.WriteLine("\n==============================================");
                }
            }
            else Console.WriteLine("Não possui cadastro ");
        }

        public void visualizarEmprestimo()
        {
            if (idEmprestimos != -1)
            {
                Console.WriteLine("Lista de Emprestimo");
                for (int i = 0; i < idEmprestimos; i++)
                {
                    Console.WriteLine("\n==============================================");
                    Console.WriteLine("ID" + i + "nome: " + emprestimos[i].cadastrarAmigo + "\nRevista: " + emprestimos[i].cadastraRevista + 
                        "\nData do Emprestimo: " + emprestimos[i].diaEmprestimo);
                    Console.WriteLine("\n==============================================");
                }
            }
            else Console.WriteLine("Não possui cadastro ");
        }
        #endregion


    }
}
