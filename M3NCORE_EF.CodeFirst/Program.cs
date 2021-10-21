using M3NCORE_EF.CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace M3NCORE_EF.CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using var data = new CopaLibertadoresDBContext();

            //Add SoccerPosition
            //var position1 = new SoccerPosition()
            //{
            //    Description = "Portero",
            //    Code = "PT"
            //};

            //data.SoccerPosition.Add(position1);
            //data.SaveChanges();
            //Add Range SoccerPosition
            //var position2 = new SoccerPosition()
            //{
            //    Description = "Lateral Izquierdo",
            //    Code = "LI"
            //};
            //var position3 = new SoccerPosition()
            //{
            //    Description = "Mediocampista Ofensivo",
            //    Code = "MO"
            //};
            //var position4 = new SoccerPosition()
            //{
            //    Description = "Centro Delantero",
            //    Code = "CD"
            //};

            //var listPosition = new List<SoccerPosition>();
            //listPosition.Add(position2);
            //listPosition.Add(position3);
            //listPosition.Add(position4);


            //data.SoccerPosition.AddRange(listPosition);
            //data.SaveChanges();

            //var player1 = new Player() {
            //    FullName = "Cristiano Ronaldo",
            //    Dorsal = 7,
            //    Age = 35,
            //    SoccerPositionId = 4
            //};
            //data.Player.Add(player1);
            //data.SaveChanges();

            //var player2 = new Player()
            //{
            //    FullName = "Lionel Messi",
            //    Dorsal = 10,
            //    Age = 34,
            //    SoccerPositionId = 3
            //};
            //data.Player.Add(player2);
            //data.SaveChanges();

            //var player3 = new Player()
            //{
            //    FullName = "Luis Suarez",
            //    Dorsal = 9,
            //    Age = 36,
            //    SoccerPositionId = 4
            //};
            //data.Player.Add(player3);
            //data.SaveChanges();

            //Query LINQ

            //var players = (from p in data.Player
            //               join s in data.SoccerPosition on p.SoccerPositionId equals s.Id
            //               //where p.SoccerPositionId == 4
            //               select p).ToList();

            //Query Lambda Expressions
            //var players = data.Player.Include(x=>x.SoccerPosition).ToList();
            //foreach (var item in players)
            //{
            //    Console.WriteLine("El jugador es: " + item.FullName + " y su posición es: " + item.SoccerPosition.Description);
            //}
            //Delete Range
            //var players = data.Player.Where(p=>p.SoccerPositionId == 4).ToList();

            //data.Player.RemoveRange(players);
            //data.SaveChanges();

            //Update

            //var search = data.Player.Where(p => p.Id == 2).FirstOrDefault();
            //search.FullName = "Leonel Messi X";
            //search.Age = 35;

            //data.SaveChanges();

            //Delete Player
            var search = data.Player.Where(p => p.Id == 2).FirstOrDefault();
            if (search != null)
            {
                data.Player.Remove(search);
                data.SaveChanges();
            }
            else
                Console.WriteLine("No se encontraron coincidencias para la eliminación");

        }
    }
}
