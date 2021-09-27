using System;

namespace treino.Biblioteca{

    public class ControleBiblioteca{

        public static void Comeco(){
            
            Menu menu = new Menu();

            Console.WriteLine("\nDigite a opção que desejada");

            Console.WriteLine("1 - Cadastrar novo livro");      //CadastrarLivro()
            Console.WriteLine("2 - Remover livro existente");   //RemoverLivro()
            Console.WriteLine("3 - Ajustar cadastro");          //AjustarCadastro()
            Console.WriteLine("4 - Consultar id");              //MostrarId()
            Console.WriteLine("5 - Exibir livros cadastrados"); //MostrarLivros()
            Console.WriteLine("0 - Sair do programa");
            int op = Convert.ToInt32(Console.ReadLine());

            menu.Escolha(op);
        }
    }
}