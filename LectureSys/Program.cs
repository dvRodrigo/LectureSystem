using LectureSys.Entites;
using LectureSys.Register;
using System;
using System.Collections.Generic;

namespace LectureSys
{
    class Program
    {
        static void Main(string[] args)
        {
            Sala sal = new Sala(10, 10);
            int op=0;
            Tela.Menu();
            List<Ticket> list = new List<Ticket>();
            while (op != 4)
            {
                op = int.Parse(Console.ReadLine());
               

                switch (op)
                {
                    case 1:
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Age: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Identification: ");
                        Identification person = Enum.Parse<Identification>(Console.ReadLine());
                        Console.Clear();
                        Tela.Assentos(sal);
                        Console.Write("Escolhar uma poltrona: ");
                        string polt = Console.ReadLine();
                        Posicao destino = Tela.LerPosicao(polt).toPosicao();
                        sal.RegistrarPoltrona(new Poltrona(sal), destino);
                        DateTime TimeNow = DateTime.Now;
                        Ticket ticket = new Ticket(name, age, person, polt, TimeNow);
                        list.Add(new Ticket(name, age, person, polt, TimeNow));
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


                        
                }
            }
             



        }
    }
}
