using System;

namespace Clube__da_leitura.ConsleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cadastros cadastros = new Cadastros();

            string opcaoPrincipal;
            string opcaoRevista;
            string opcaoCaixa;
            string opcaoEmprestimo;
            string opcaoAmigo;

            MenuInicial();
            opcaoPrincipal = opcaoMenu();
            bool condicao = 1 == 1;
            while (condicao)
            {

                if (opcaoPrincipal == "s")
                {
                    Console.WriteLine("\nPrograma esta sendo encerrado...");
                    break;
                }


                
                if (opcaoPrincipal == "1")
                {
                    Console.Clear();
                    Console.WriteLine("     Emprestimo");
                    MenuOpcoes();
                    opcaoEmprestimo = opcaoMenu();


                    if (opcaoEmprestimo == "1")
                    {
                        cadastros.obterEmprestimo();
                        continue;
                    }


                    else if (opcaoEmprestimo == "2")

                    {
                        cadastros.visualizarEmprestimo();
                        continue;
                    }



                    else if (opcaoEmprestimo == "s")
                    {
                        Console.Clear();
                        MenuInicial();
                        opcaoPrincipal = opcaoMenu();
                        continue;
                    }


                }



                else if (opcaoPrincipal == "2")
                {
                    Console.Clear();
                    Console.WriteLine("     Amigos");
                    MenuOpcoes();
                    opcaoAmigo = opcaoMenu();


                    if (opcaoAmigo == "1")
                    {
                        cadastros.obterAmigo();
                        continue;
                    }


                    else if (opcaoAmigo == "2")

                    {
                        cadastros.visualizarAmigo();
                        continue;
                    }



                    else if (opcaoAmigo == "s")
                    {
                        Console.Clear();
                        MenuInicial();
                        opcaoPrincipal = opcaoMenu();
                        continue;
                    }


                }
               
               
                else if (opcaoPrincipal == "3")
                {
                    Console.Clear();
                    Console.WriteLine("     Caixas");
                    MenuOpcoes();
                    opcaoCaixa = opcaoMenu();


                    if (opcaoCaixa == "1")
                    {
                        cadastros.obterCaixa();
                        continue;
                    }


                    else if (opcaoCaixa == "2")

                    {
                        cadastros.visualizarCaixa();
                        continue;

                    }



                    else if (opcaoCaixa== "s")
                    {
                        Console.Clear();
                        MenuInicial();
                        opcaoPrincipal = opcaoMenu();
                        continue;
                    }


                }

                else if (opcaoPrincipal == "4")
                {
                    Console.Clear();
                    Console.WriteLine("     Revistas");
                    MenuOpcoes();
                    opcaoRevista = opcaoMenu();


                    if (opcaoRevista == "1")
                    {
                        cadastros.obterrRevista();
                        continue;
                    }


                    else if (opcaoRevista == "2")

                    {
                        cadastros.visualizarRevista();
                        continue;

                    }



                    else if (opcaoRevista == "s")
                    {
                        Console.Clear();
                        MenuInicial();
                        opcaoPrincipal = opcaoMenu();
                        continue;
                    }


                }
            }


            static void MenuOpcoes()
            {


                Console.WriteLine("1 - Cadastrar\n2 - Visualizar \n"
                                 + " \ns - Menu Principal");
            }

            static void MenuInicial()
            {

                Console.WriteLine("     Clube da leitura\n");
                Console.WriteLine("1 - Empretimo\n2 - Amigos\n3 - Caixas\n4- Revistas\ns- Sair");

            }
            static string opcaoMenu()
            {
                string opcao;
                Console.Write("\nInforme a opção desejada: ");
                opcao = Console.ReadLine();
                return opcao;
            }





        }
    }
}