using System;
using System.Collections.Generic;
using System.Text;

namespace LectureSys.Entites
{
    class Poltrona
    {
        public Posicao posicao { get; set; }
        public Sala sal { get; set; }

        public Poltrona(Sala sal)
        {
            this.posicao = posicao;
            this.sal = sal;

        }
    }
}
