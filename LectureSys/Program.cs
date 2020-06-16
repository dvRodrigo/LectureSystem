using LectureSys.Entites;
using System;

namespace LectureSys
{
    class Program
    {
        static void Main(string[] args)
        {
            Sala sal = new Sala(10,10);        


            Console.Write("Operação: ");
             int op = int.Parse(Console.ReadLine());

             while (op==0)
             {
                //sal.RegistrarPoltrona(new Poltrona(sal), new Posicao(0, 9));
                sal.RegistrarPoltrona(new Poltrona(sal), new Posicao(0, 0));
                Tela.Assentos(sal);
                 Console.Write("Escolhar uma poltrona: ");
                 Posicao origem = Tela.LerPosicao().toPosicao();
            
                 sal.RegistrarPoltrona(new Poltrona(sal), origem);

                Tela.Assentos(sal);
                 Console.Clear();
                Console.ReadLine();
            }
            
            
         
        }
    }
}
