using LectureSys.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace LectureSys.Register
{
    class Ticket
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Identification Identification { get; set; }
        public string  Poltrona { get; set; }
        public DateTime Time { get; set; }

        public Ticket(string name, int age, Identification identification, string poltrona, DateTime time)
        {
            Name = name;
            Age = age;
            Identification = identification;
            Poltrona = poltrona;
            Time = time;
        }

        public override string ToString()
        {
            return "" +
                "-----------------------------------------" +
                "\nNome: "
                + Name
                + "\nIdade: "
                + Age
                +" Anos"
                + "\nIdentificação: "
                + Identification
                + "\nPoltrona: "
                + Poltrona.ToUpper()
                + "\nData: "
                + Time
            + "\n----------------------------------------";
        }
    }
}
