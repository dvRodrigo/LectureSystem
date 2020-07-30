using LectureSys.Entites;
using LectureSys.Register;
using LectureSys.SalaTeatro;
using System;
using System.Collections.Generic;

namespace LectureSys
{
    class Program
    {
        static void Main(string[] args)
        {
            Sala sal = new Sala(10, 10);
            int op = 0;
            Tela.Menu();
            List<Ticket> list = new List<Ticket>();
            try
            {
                while (op != 4)
                {
                    op = int.Parse(Console.ReadLine());


                    switch (op)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("|\t\tCADASTRO\t\t|");
                            Console.Write("\nNome: ");
                            string name = Console.ReadLine();
                            Console.Write("Idade: ");
                            int age = int.Parse(Console.ReadLine());
                            Console.Write("Identificação: ");
                            Identification person = Enum.Parse<Identification>(Console.ReadLine());
                            Console.Clear();
                            Tela.Assentos(sal);
                            Console.Write("\nEscolhar uma poltrona: ");
                            string polt = Console.ReadLine();
                            Console.Clear();
                            Posicao destino = Tela.LerPosicao(polt).toPosicao();
                            sal.RegistrarPoltrona(new Poltrona(sal), destino);
                            DateTime TimeNow = DateTime.Now;
                            list.Add(new Ticket(name, age, person, polt, TimeNow));
                            Ticket ticket = new Ticket(name, age, person, polt, TimeNow);
                            Console.WriteLine("|\t\t TICKET \t\t|");
                            Console.WriteLine(ticket);
                            Console.ReadLine(); Console.Clear();
                            Tela.Menu();
                            break;
                        case 2:

                            foreach (Ticket x in list)
                            {

                                Console.WriteLine(x);

                            }
                            Console.ReadLine(); Console.Clear();
                            Tela.Menu();
                            break;

                        case 3:
                            Tela.Assentos(sal);
                           
                            Console.ReadLine();
                            Console.Clear();
                            Tela.Menu();


                            break;


                    }
                }
            }
            catch (SalaException e)
            {

                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

            Tela.Menu();



        }
    }
}
