/*
Create an application that will allow users to search for books by entering a query (Title, Author, etc). Display the resulting books in a list on the page with all the corresponding data.

User Stories
 User can enter a search query into an input field
 User can submit the query. This will call an API that will return an array of books with the corresponding data (Title, Author, Published Date, Picture, etc)
 User can see the list of books appearing on the page
*/

using System;

namespace treino.Biblioteca{ 

    class Program{

        static void Main(string[] args){
            
            Console.WriteLine("Bem vindo ao sistema da biblioteca HQM! ");
            ControleBiblioteca.Comeco();
         }  
    }
}
