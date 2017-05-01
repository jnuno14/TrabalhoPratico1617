//  <author>Joao Nuno da Cunha Rodrigues - 13246        Turno 1</author>
//  <author>Miguel Alberto Gonçalves Pereira - 13256        Turno 1</author>
//  <time>20:05</time>
//  <date>2017/04/26</date>
//  <email>a13246@alunos.ipca.pt</email>
//  <email>a13256@alunos.ipca.pt</email>
//  <desc>Trabalho Pratico (Parte 1) - Turno 1</desc>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    class Program
    {
        /// <summary>
        /// main com a array de Utilizadores e metodos dos menus
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const int MAXUTI = 1;
            Utilizador[] lista = new Utilizador[MAXUTI];
            lista[0] = new Utilizador();
            lista[0].Nome = "nuno";

            MainMenu(lista);

            /*Tarefa tar = new Tarefa();
            tar.Tare = "fazer o template";

            Projeto p = new Projeto();
            p.Taref = tar;
            Console.WriteLine(p.Taref.Tare);*/
        }

        /// <summary>
        /// Mainmenu com as opçoes de projetos e utilizadores
        /// </summary>
        /// <param name="lista"></param>
        static void MainMenu(Utilizador[] lista)
        {
            int escolha;

            Console.Clear();

            Console.WriteLine("Gestão de Software - Menu\n\n1 - Projetos\n2 - Utilizadores\n3 - Sair");
            escolha = int.Parse(Console.ReadLine());

            if (escolha < 1 || escolha > 3)
            {
                Console.WriteLine("Escolha invalida. Pf escolha de novo.");
                escolha = int.Parse(Console.ReadLine());
            }

            if (escolha == 1) //projetos
            {

            }
            else if (escolha == 2) //utilizadores
            {
                lista = MenuUtilizadores(lista);

                Console.ReadKey();
                MainMenu(lista);
            }
        }

        /// <summary>
        /// Menu de utilizadores com as opçoes de adicionar, remover e listar os utilizadores registados no sistema
        /// </summary>
        /// <param name="lista">array de utilizadores</param>
        /// <returns>retorna a aray de utilizadores actualizada</returns>
        static Utilizador[] MenuUtilizadores(Utilizador[] lista)
        {
            int escolha;

            Console.Clear();

            Console.WriteLine("Utilizadores - Menu\n\n1 - Adicionar Utilizador\n2 - Remover Utilizadores\n3 - Ver Utilizadores\n4 - Sair");
            escolha = int.Parse(Console.ReadLine());
            if (escolha < 1 || escolha > 4)
            {
                Console.WriteLine("Escolha invalida. Pf escolha de novo.");
                escolha = int.Parse(Console.ReadLine());
            }

            switch (escolha)
            {
                case 1: //adicionar
                    Console.Clear();
                    lista = Utilizador.AdicionarUtilizador(lista);
                    break;
                case 2: //remover
                    Console.Clear();
                    int idrm;

                    Console.WriteLine("Utilizador que pretende remover:\n1 - Inserir ID do utilizador\n2 - Procurar pelo nome do Utilizador");
                    int escolha2 = int.Parse(Console.ReadLine());

                    if(escolha2 < 1 || escolha2 > 2)
                    {
                        Console.WriteLine("Escolha invalida. Pf escolha de novo.");
                        escolha2 = int.Parse(Console.ReadLine());
                    }

                    if (escolha2 == 1)
                    {
                        Console.WriteLine("Insira o ID do Utilizador a remover:");
                        idrm = int.Parse(Console.ReadLine());

                        if (idrm < 0 || idrm > (lista.Length - 1))
                        {
                            Console.WriteLine("ID for dos limites. Pf escolha de novo.");
                            idrm = int.Parse(Console.ReadLine());
                        }
                        lista = Utilizador.RemoverUtilizador(lista, idrm);
                        Console.WriteLine("Utilizador removido.");
                    }
                    else if (escolha2 == 2)
                    {
                        Console.Clear();
                        idrm = Utilizador.ProcurarUtilizador(lista);
                        if(idrm == -1)
                        {
                            Console.WriteLine("Nao foi removido Utilizador.");
                        }
                        else
                        {
                            lista = Utilizador.RemoverUtilizador(lista, idrm);
                            Console.WriteLine("Utilizador removido.");
                        }
                    }
                    break;
                case 3: //listar
                    Console.Clear();
                    Utilizador.ListarUtilizador(lista);
                    break;
                default:
                    break;
            }
            return lista;
        }
    }
}
