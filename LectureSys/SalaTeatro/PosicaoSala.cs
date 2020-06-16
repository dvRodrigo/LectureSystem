using System;
using System.Collections.Generic;
using System.Text;

namespace LectureSys.Entites
{
    class PosicaoSala
    {
        public char linha { get; set; }
        public int coluna { get; set; }

        public PosicaoSala(char linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }
        public Posicao toPosicao()
        {
            return new Posicao(linha - 'a' , coluna  );
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
