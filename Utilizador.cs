using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    class Utilizador : IUtilizador
    {
        #region Variaveis
        string nome;
        #endregion

        #region Properties
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// adiciona um ou varios utilizadores á array de utilizadores ja existente
        /// </summary>
        /// <param name="lista">array de utilizadores</param>
        /// <returns>retorna uma array de utilizadores atualizada</returns>
        public static Utilizador[] AdicionarUtilizador(Utilizador[] lista)
        {
            Utilizador[] b;
            int numutili;

            Console.WriteLine("Quantos Utilizadores pretende adicionar?");
            numutili = int.Parse(Console.ReadLine());

            if (numutili < 1 || numutili > 15)
            {
                Console.WriteLine("Numero de clientes invalido. Pf escolha entre 1-15.");
                numutili = int.Parse(Console.ReadLine());
            }

            b = new Utilizador[lista.Length + numutili];

            for (int i = 0; i < lista.Length; i++)
            {
                b[i] = lista[i];
            }

            for (int i = lista.Length; i < b.Length; i++)
            {
                string nome;
                Utilizador novouti = new Utilizador();

                Console.WriteLine("\nIntroduza o nome do Utilizador");
                nome = Console.ReadLine();

                novouti.Nome = nome;

                b[i] = novouti;

                Console.WriteLine("\nNovo utilizador {0} com o ID-{1} criado.", b[i].Nome, i);
            }
            return b;
        }

        /// <summary>
        /// lista todos os utilizadores registados no sistema
        /// </summary>
        /// <param name="lista"></param>
        public static void ListarUtilizador(Utilizador[] lista)
        {
            Console.WriteLine("Utilizadores:\n");

            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("ID-{0} Nome:{1}", i, lista[i].Nome);
            }
        }

        /// <summary>
        /// remove um utilizador do sistema a partir do seu ID
        /// </summary>
        /// <param name="lista">array com os utilizadores</param>
        /// <param name="uti">id do utlizador a ser removido</param>
        /// <returns>retorna uma array de utilizadores actualizada</returns>
        public static Utilizador[] RemoverUtilizador(Utilizador[] lista, int uti)
        {
            Utilizador[] b = new Utilizador[lista.Length - 1];
            int num = 0;

            for (int i = 0; i < lista.Length; i++)
            {
                if (i == uti)
                {
                    continue;
                }
                else
                {
                    b[num] = lista[i];
                }
                num++;
            }
            return b;
        }

        /// <summary>
        /// procura na array de utilizadores um utilizador a partir do seu id ou nome
        /// </summary>
        /// <param name="lista">array com os utlizadores</param>
        /// <returns>retorna id do utlizador procurado</returns>
        public static int ProcurarUtilizador(Utilizador[] lista)
        {
            int escolha, numuti, count = 0;
            string nome;

            Console.WriteLine("Procurar por:\n 1 - ID\n 2 - Nome");
            escolha = int.Parse(Console.ReadLine());
            if(escolha < 1 || escolha > 2)
            {
                Console.WriteLine("Escolha invalida. Pf escolha de novo.");
                escolha = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            if(escolha == 1)
            {
                for (int i = 0; i < lista.Length; i++)
                {
                    Console.WriteLine("ID-{0}  Nome:{1}", i, lista[i].Nome);
                }

                Console.WriteLine("\nQual o ID do Utilizador que pretende remover?");
                numuti = int.Parse(Console.ReadLine());
                if(numuti < 0 || numuti > lista.Length)
                {
                    Console.WriteLine("ID invalido. Pf escolha de novo.");
                    numuti = int.Parse(Console.ReadLine());
                }
                return numuti;
            }
            else
            {
                Console.WriteLine("Insira o nome Utilizador:");
                nome = Console.ReadLine();

                for (int i = 0; i < lista.Length; i++)
                {
                    if (lista[i].Nome.Contains(nome))
                    {
                        Console.WriteLine("ID-{0} Nome:{1}", i, lista[i].Nome);
                        count++;
                    }
                }

                if (count != 0)
                {
                    Console.WriteLine("\n1 - Inserir o ID do Utilizador\n2 - Procurar de novo");
                    escolha = int.Parse(Console.ReadLine());

                    if (escolha < 1 || escolha > 2)
                    {
                        Console.WriteLine("Escolha invalida. Pf escolha de novo.");
                        escolha = int.Parse(Console.ReadLine());
                    }

                    if (escolha == 1)
                    {
                        Console.Write("ID-");
                        numuti = int.Parse(Console.ReadLine());

                        if (numuti < 0 || numuti > (lista.Length - 1))
                        {
                            Console.WriteLine("ID invalido. Pf escolha de novo.");
                            numuti = int.Parse(Console.ReadLine());
                        }
                        return numuti;
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("Insira o nome Utilizador:");
                        nome = Console.ReadLine();

                        for (int i = 0; i < lista.Length; i++)
                        {
                            if (lista[i].Nome.Contains(nome))
                            {
                                Console.WriteLine("ID-{0} Nome:{1}", i, lista[i].Nome);
                            }
                        }
                        Console.Write("ID-");
                        numuti = int.Parse(Console.ReadLine());

                        if (numuti < 0 || numuti > (lista.Length - 1))
                        {
                            Console.WriteLine("ID invalido. Pf escolha de novo.");
                            numuti = int.Parse(Console.ReadLine());
                        }
                        return numuti;
                    }
                }
                else
                {
                    Console.WriteLine("Nao foram encontrados Utilizadores com o Nome:{0}", nome);
                    return -1;
                }
           }
       }

        #endregion
    }
}
