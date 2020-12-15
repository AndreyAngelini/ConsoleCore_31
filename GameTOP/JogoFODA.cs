
using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly iJogador _JogadorA;
        private readonly iJogador _JogadorB;

        public JogoFODA(iJogador jogadorA, iJogador jogadorB)
        {
            this._JogadorA = jogadorA;
            this._JogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
            System.Console.WriteLine(this._JogadorA.chutar());
            System.Console.WriteLine(this._JogadorA.correr());
            System.Console.WriteLine(this._JogadorA.passar());

            System.Console.WriteLine("\n PRÓXIMO JOGADOR. \n");

            System.Console.WriteLine(this._JogadorB.chutar());
            System.Console.WriteLine(this._JogadorB.correr());
            System.Console.WriteLine(this._JogadorB.passar());
        }

    }

}