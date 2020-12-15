using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string chutar()
        {
            return "Maradona está chutando.";
        }

        public string correr()
        {
            return "Maradona está correndo.";
        }

        public string passar()
        {
            return "Maradona está passando.";
        }
    }
}