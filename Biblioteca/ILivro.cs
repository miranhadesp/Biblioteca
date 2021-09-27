using System;


namespace treino.Biblioteca{

    public interface ILivro{

        string Id { get; set; }

        string Nome { get; set; }
        string Autor { get; set; }

        int Ano { get; set; }

        double Preco { get; set; }
    }
}