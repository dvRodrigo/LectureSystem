using LectureSys.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace LectureSys
{
    class Tela
    {
        public static void Menu()
        {
            Console.WriteLine("\tLECTURE SYSTEM");
            Console.WriteLine("1) Registrar         2)Visualizar");
            Console.WriteLine("3) Poltronas         4)Sair");
            Console.WriteLine();
            Console.Write("Operação: ");

        }
        public static void Assentos(Sala sal)
        {
            char lt = 'A';
            for (int i = 0; i < sal.linhas; i++)
            {
                Console.Write(lt++ + "|-");
                for (int j = 0; j < sal.colunas; j++)
                {
                    if (sal.poltrona(i,j)==null)
                    {
                        Console.Write($"[{j}]");
                    }
                    else
                    {
                        Console.Write(" x ");
                    }
                }
                Console.Write("|");
                Console.WriteLine();
            }
           
        }

        public static PosicaoSala LerPosicao(string s)
        {
           
            char linha = s[0];
            int coluna = int.Parse(s[1] + "");
            return new PosicaoSala(linha, coluna);
        }

    }
}
