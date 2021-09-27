using System;
using System.Collections.Generic;

namespace treino.Biblioteca{

    public class Livros : ILivro{

        List<ILivro> livros = new List<ILivro>();

        private string nome; 
        public string Nome{
             get{ return nome; } 
             set{ nome = value; } 
        }

        private string autor; 
        public string Autor{
             get{ return autor; } 
             set{ autor = value; } 
        }

        private int ano; 
        public int Ano{
             get{ return ano; } 
             set{ ano = value; } 
        }

        private double preco; 
        public double Preco{
             get {return preco; } 
             set{ preco = value; } 
        }

        public Livros(){ 

        }

        public Livros(string nome, string autor, int ano, double preco){

            Nome = nome;
            Autor = autor;
            Ano = ano;
            Preco = preco;
        }
        
        public void Dados(){

            Console.Write("\nDigite o nome do livro: ");
            Nome = Console.ReadLine();

            Console.Write("Autor: ");
            Autor = Console.ReadLine();

            Console.Write("Ano de lançamento: ");
            Ano = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço: ");
            Preco = Convert.ToDouble(Console.ReadLine());

            CadastrarNovoLivro();

            MostrarLivros();

            Console.Write("\nDeseja cadastrar outro livro? (S/N) ");
            string verify = Console.ReadLine().ToUpper();

            switch (verify){
                case "S":
                    Dados();
                    break;

                case "N":
                    AjustarCadastro(); //TESTAR FUNÇÕS DENTRO DE "Livros", MUDAR QUANDO RESOLVER O LANCE DE "uma vida"
                    break;

                default:
                    Console.WriteLine("Opção inválida, saindo do programa");
                    Environment.Exit(0);
                    break;
            }
        }

        public void CadastrarNovoLivro(){

            livros.Add(new Livros (Nome, Autor, Ano, Preco));
        }

        public void RemoverLivro(){

            string nomeLivro;

            Console.Write("\nDigite o nome do livro que deseja remover: "); //VERIFICAÇÃO FEITA PELO NOME, ALTERAR PARA ID
            nomeLivro = Console.ReadLine();

            int indexLivro = livros.FindIndex(livro => livro.Nome == nomeLivro);

            if(indexLivro == -1){
                Console.WriteLine("Livro não encontrada, tente novamente");
                RemoverLivro();
            }
            else{
                livros.RemoveAt(indexLivro);
                Console.WriteLine($"\nO livro {nomeLivro} foi removido com sucesso!");
                MostrarLivros();
            }
        }

        public void AjustarCadastro(){

            string nomeLivro;

            Console.Write("\nDigite o nome do livro que deseja alterar o cadastro: "); //VERIFICAÇÃO FEITA PELO NOME, ALTERAR PARA ID
            nomeLivro = Console.ReadLine();

            Console.WriteLine("\nO que deseja atualizar? ");
            Console.WriteLine("1 - Nome");
            Console.WriteLine("2 - Autor");
            Console.WriteLine("3 - Ano");
            Console.WriteLine("4 - Preço");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao){
                case 1: 
                    foreach (ILivro e in livros){
                        if(nomeLivro == e.Nome){ //VERIFICAÇÃO FEITA PELO NOME, ALTERAR PARA ID
                            Console.Write($"O nome {e.Nome} será ajustado para: ");
                            e.Nome = Console.ReadLine();

                            Console.WriteLine("\nAtualizado com sucesso!");
                        }
                    }   
                    break;
                
                case 2:
                    foreach (ILivro e in livros){
                        if(nomeLivro == e.Nome){ //VERIFICAÇÃO FEITA PELO NOME, ALTERAR PARA ID
                            Console.Write($"O autor {e.Autor} será ajustado para: ");
                            e.Autor = Console.ReadLine();

                            Console.WriteLine("\nAtualizado com sucesso!");
                        }
                    }   
                    break;

                case 3:
                    foreach (ILivro e in livros){
                        if(nomeLivro == e.Nome){ //VERIFICAÇÃO FEITA PELO NOME, ALTERAR PARA ID
                            Console.Write($"O ano {e.Ano} será ajustado para: ");
                            e.Ano = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nAtualizado com sucesso!");
                        }
                    }   
                    break;

                case 4:
                    foreach (ILivro e in livros){
                        if(nomeLivro == e.Nome){ //VERIFICAÇÃO FEITA PELO NOME, ALTERAR PARA ID
                            Console.Write($"O preço {e.Preco}R$ será ajustado para: ");
                            e.Preco = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("\nAtualizado com sucesso!");
                        }
                    }   
                    break;

                default:
                    Console.WriteLine("Opcao inválida, tente novamente");
                    AjustarCadastro();
                    break;
            }

            Console.Write("Deseja atualizar outro livro? (S/N) ");
            string simOuNao1 = Console.ReadLine().ToUpper();

            if(simOuNao1 == "S") AjustarCadastro();
        }

        public void MostrarLivros(){

            foreach (ILivro e in livros){
                Console.WriteLine($"\nNome: {e.Nome}");
                Console.WriteLine($"Autor: {e.Autor}");
                Console.WriteLine($"Ano de lançamento: {e.Ano}");
                Console.WriteLine($"Preço: {e.Preco}R$");
            }
        }
    }
}