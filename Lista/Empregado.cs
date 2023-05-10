using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class Empregado
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Empregado(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
    }
}
