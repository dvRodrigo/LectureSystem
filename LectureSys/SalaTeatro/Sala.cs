using System;
using System.Collections.Generic;
using System.Text;

namespace LectureSys.Entites
{
    class Sala
    {

        public int linhas { get; set; }
        public int colunas { get; set; }

        public Poltrona[,] poltronas;

        public Sala(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            poltronas = new Poltrona [linhas,colunas];
        }

        public Poltrona poltrona(int linha, int coluna)
        {
            return poltronas[linha, coluna];
        }
        public void RegistrarPoltrona(Poltrona pol, Posicao pos)
        {
            poltronas[pos.linha, pos.coluna] = pol;
            
            pol.posicao = pos;
        }
        
    }
}
