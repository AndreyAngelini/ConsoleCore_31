using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1: iJogador 
    {
        
        public readonly string _nomeJogador;
        public Jogador1(string nome = "Ronaldo")
        {
            this._nomeJogador = nome;
        }

        // Chuta
        public string chutar()
        {
            return $"{this._nomeJogador} está chutando.";
        }
        // Corre
        public string correr()
        {
            return $"{this._nomeJogador} está correndo.";
        }

        // Passa
        public string passar()
        {
            return $"{this._nomeJogador} está passando.";
        }

    }
}