using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empregado> list = new List<Empregado>();

            Console.Write("Quantas pessoas registradas? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Funcionario #" + i );
                
                Console.Write("Id :");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome :" );
                string nome = Console.ReadLine();
                Console.Write("Salario : ");
                double salary = int.Parse(Console.ReadLine());

                list.Add(new Empregado(id , nome , salary));

            }

            foreach (Empregado obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.ReadLine();
        }
    }
}
