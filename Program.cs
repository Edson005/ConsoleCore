using System;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA("Ronaldo Cagao");
            jogo.IniciarJogo();
        }
    }

    class JogoFODA{
        private readonly string _NomeJogador;

        public JogoFODA(string nome)
        {
            _NomeJogador = nome;
        }
        public void IniciarJogo(){

            Console.Write($"{_NomeJogador} Jogador 1 fez passe");
        }

    }


}
