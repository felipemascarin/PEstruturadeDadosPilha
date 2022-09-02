using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIntroducaoPilha
{
    internal class PilhaLivros
    {
        public Livro TOPO { get; set; }

        public PilhaLivros()
        {
            this.TOPO = null;
            //Console.WriteLine("Pilha Criada com Sucesso!!!");
        }

        //Insere um livro no topo da pilha de livros:
        public void Push(Livro aux)
        {
            if (Vazia())
                TOPO = aux;
            else
            {
                aux.Anterior = TOPO;
                TOPO = aux;
            }
        }

        //Deleta um livro do topo da pilha de livros:
        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("\nPilha Está Vazia");
            }
            else
            {
                TOPO = TOPO.Anterior;
                Console.Clear();
            }

        }

        //Imprime todos os livros da pilha de livros
        public void Print()
        {

            if (Vazia())
            {
                Console.WriteLine("\nPilha Vazia!!!");
            }
            else
            {
                Livro aux = TOPO;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Anterior;
                } while (aux != null);
                Console.WriteLine("Fim da Impressão!!!");
            }
        }

        //Verifica se a pilha de livros está vazia
        private bool Vazia()
        {

            if (this.TOPO == null)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        //Verifica a quantidade total de livros da pilha
        public int TotalItens()
        {
            int contador = 0;
            if (Vazia())
            {
                Console.WriteLine("\nPilha Vazia!!!");
            }
            else
            {
                Livro aux = TOPO;
                do
                {
                    contador++;
                    aux = aux.Anterior;
                } while (aux != null);
            }
            return contador;
        }

        //Pesquisa um livro na lista pelo título
        public void PesquisarTitulo(string titulo)
        {
            int livrosencontrados = 0;
            if (Vazia())
            {
                Console.WriteLine("\nPilha Vazia!!!");
            }
            else
            {
                Livro aux = TOPO;
                do
                {
                    if(titulo.ToUpper() == aux.Titulo)
                    {
                        Console.WriteLine("Livro encontrado\n");
                        Console.WriteLine(aux.ToString());
                        livrosencontrados ++;
                    }
                    aux = aux.Anterior;
                } while (aux != null);
                Console.WriteLine("\nQuantidade de livros encontrados: " + livrosencontrados);
            }
        }
    }
}
