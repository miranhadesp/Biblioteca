using System;

namespace treino.Biblioteca{

    public class Menu{
        
        public void Escolha(int opcao){

            Livros livros = new Livros();

            switch (opcao){
                case 1:
                    livros.Dados();
                    break;

                case 2:
                    livros.RemoverLivro();
                    break;

                case 3:
                    livros.AjustarCadastro();
                    break;

                case 4:
                    livros.MostrarLivros();
                    break;

                case 0:
                    Environment.Exit(0);
                    break;
                
                default:
                    Console.WriteLine("Opçõa inválida, tente novamente.");
                    ControleBiblioteca.Comeco();
                break;
            }
        }
    }
}