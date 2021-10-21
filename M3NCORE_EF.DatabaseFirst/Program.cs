using M3NCORE_EF.DatabaseFirst.Models;
using System;
using System.Linq;

namespace M3NCORE_EF.DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //Query
            using var data = new CopaLibertadoresDBContext();

            var positions = data.SoccerPosition.ToList();

            foreach (var item in positions)
            {
                Console.WriteLine("La posición es: " + item.Description);
            }
           

        }
    }
}
