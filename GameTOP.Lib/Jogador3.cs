using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : iJogador
    {
        public string chutar()
        {
            return "Teste chuta.";
        }

        public string correr()
        {
            return "Teste corre.";
        }

        public string passar()
        {
            return "Teste passa.";
        }
    }
}