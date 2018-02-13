using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimeKüsimisList
{
    class Program
    {
        public void Main(string[] args)
        {
            while (true)
            {
                var humans1 = new List<Human>
                {

                };


                var human2 = new Human();
                Console.WriteLine("sisestage nimi");
                human2.Name = Console.ReadLine();
                Console.WriteLine("sisestage vanus");
                human2.Age = int.Parse(Console.ReadLine());
                humans1.Add(human2);

                foreach (var item in humans1)
                {
                    Console.WriteLine(item.Name + " " + item.Age);
                }
            }

        }
    }
}
