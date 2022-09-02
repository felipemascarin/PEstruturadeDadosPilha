using System;

namespace PIntroducaoPilha
{
    internal class Program
    {
        static void MenuPrincipal(PilhaLivros pilhalivros)
        {
            int op;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Escolha a opçaõ desejada:");
                    Console.WriteLine("1 - Inserir Livro na pilha.");
                    Console.WriteLine("2 - Remover Livro da pilha.");
                    Console.WriteLine("3 - Imprimir a pilha.");
                    Console.WriteLine("4 - Imprimir a quantidade de livros na pilha.");
                    Console.WriteLine("5 - Localizar um livro na pilha pelo título.");
                    Console.WriteLine("0 - Sair.");
                    op = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    op = 6;
                }


                switch (op)
                {
                    case 1:
                        pilhalivros.Push(InserirLivro());
                        Console.Clear();
                        Console.WriteLine("Mensagem: Livro inserido com sucesso na pilha!");
                        Console.WriteLine("PRESSIONE ENTER");
                        Console.ReadKey();
                        break;
                    case 2:
                        pilhalivros.Pop();
                        Console.Clear();
                        Console.WriteLine("Mensagem: Livro removido do topo da pilha com sucesso.");
                        Console.WriteLine("PRESSIONE ENTER");
                        Console.ReadKey();
                        break;
                    case 3:
                        pilhalivros.Print();
                        Console.WriteLine("PRESSIONE ENTER");
                        Console.ReadKey();
                        break;
                    case 4:
                        int total = pilhalivros.TotalItens();
                        Console.WriteLine("Quantidade de itens na lista: " + total);
                        Console.WriteLine("PRESSIONE ENTER");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Insira o título do livro:");
                        bool tituloverdade = false;
                        string titulo = " ";
                        do
                        {
                            try
                            {
                                titulo = Console.ReadLine();
                                tituloverdade = true;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                tituloverdade = false;
                            }
                        } while (tituloverdade == false);

                        pilhalivros.PesquisarTitulo(titulo);
                        Console.WriteLine("PRESSIONE ENTER");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Programa encerrado com sucesso!");
                        break;
                }
            } while (op != 0);
        }

        static public Livro InserirLivro()
        {
            Console.Clear();
            Console.WriteLine("Inserir um livro no top da pilha:");
            bool tentativa = false;
            string titulo = " ", autor = " ";
            int isbn = 0;

            do
            {
                try
                {
                    Console.WriteLine("Título:");
                    titulo = Console.ReadLine();
                    tentativa = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Insira um valor válido!");
                    tentativa = false;
                }
            } while (tentativa == false);

            do
            {
                try
                {
                    Console.WriteLine("Autor:");
                    autor = Console.ReadLine();
                    tentativa = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Insira um valor válido!");
                    tentativa = false;
                }
            } while (tentativa == false);

            do
            {
                try
                {
                    Console.WriteLine("ISBN:");
                    isbn = int.Parse(Console.ReadLine());
                    tentativa = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Insira um valor válido!");
                    tentativa = false;
                }
            } while (tentativa == false);

            Livro livro = new Livro(titulo.ToUpper(), isbn, autor);

            return livro;
        }

        static void Main(string[] args)
        {
            PilhaLivros pilhaLivros = new PilhaLivros();

            MenuPrincipal(pilhaLivros);



        }
    }
}

