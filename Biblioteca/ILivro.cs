using System;


namespace treino.Biblioteca{

    public interface ILivro{

        string Nome { get; set; }
        string Autor { get; set; }

        int Ano { get; set; }

        double Preco { get; set; }
    }
}