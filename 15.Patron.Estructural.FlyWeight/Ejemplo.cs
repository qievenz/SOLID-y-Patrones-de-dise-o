using System;
using System.Collections.Generic;

namespace _15.Patron.Estructural.FlyWeight.Ejemplo
{
    public interface IPlayer
    {
        void AssignWeapon(string weapon);
        void Mission();
    }

    public class Terrorist : IPlayer
    {
        private string _task;
        private string _weapon;

        public Terrorist()
        {
            _task = "Terrorist Colocar bomba";
        }

        public void AssignWeapon(string weapon)
        {
            _weapon = weapon;
        }

        public void Mission()
        {
            Console.WriteLine($"{_task} con {_weapon}");
            
        }
    }
    public class CounterTerrorist : IPlayer
    {
        private string _task;
        private string _weapon;

        public CounterTerrorist()
        {
            _task = "CounterTerrorist Desarmar bomba";
        }

        public void AssignWeapon(string weapon)
        {
            _weapon = weapon;
        }

        public void Mission()
        {
            Console.WriteLine($"{_task} con {_weapon}");
            
        }
    }

    public class Factory
    {
        Dictionary<string, IPlayer> _players = new Dictionary<string, IPlayer>();
        public int GetNumberOfInstances()
        {
            return _players.Count;
        }
        public IPlayer GetPlayer(string playerKey)
        {
            IPlayer player = null;
            if(_players.ContainsKey(playerKey))
            {
                player = _players[playerKey];
            }
            else
            {
                switch (playerKey)
                {
                    case "Terrorist":
                        player = new Terrorist();
                        break;
                    case "CounterTerrorist":
                        player = new CounterTerrorist();
                        break;
                    default:
                        break;
                }

                _players.Add(playerKey, player);
            }

            return player;
        }
    }

    public static class EjemploCliente
    {
        private static string[] playerType = { "Terrorist", "CounterTerrorist" };
        private static string[] weapons = { "pistola", "cuchillo" };
        public static string GetPlayerRandom()
        {
            var random = new Random();
            var rad = random.Next(playerType.Length);

            return playerType[rad];
        }
        public static string GetWeaponRandom()
        {
            var random = new Random();
            var rad = random.Next(weapons.Length);

            return weapons[rad];
        }
    }
}