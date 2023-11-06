using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.Json;

/*
 Требуется разработать консольное приложение, которое выполняет операции с данными о футбольных командах.

Создайте класс "FootballTeam" со следующими свойствами:

"Name" - имя команды (строка);
"Country" - страна команды (строка);
"Ranking" - рейтинг команды (целое число);
"Players" - массив объектов "Player" (см. ниже).
Создайте класс "Player" со следующими свойствами:

"Name" - имя игрока (строка);
"Age" - возраст игрока (целое число);
"Position" - позиция игрока (строка).
Разработайте методы класса "FootballTeam":

"AddPlayer" - принимает объект "Player" и добавляет его в массив "Players";
"RemovePlayer" - принимает имя игрока и удаляет его из массива "Players";
"GetPlayersByPosition" - принимает позицию игрока и возвращает массив игроков с заданной позицией;
"ToJson" - возвращает JSON-представление объекта "FootballTeam".
Напишите консольное приложение с использованием вышеописанных классов, которое выполняет следующие действия:

Создает объект "FootballTeam";
Добавляет несколько игроков в команду;
Удаляет одного игрока из команды;
Получает массив игроков определенной позиции и выводит их на экран;
Преобразует объект "FootballTeam" в JSON и выводит его на экран.
 */
namespace _06_11_23_C_Sharp_Randomaizer
{

    public class FootballTeam
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Ranking { get; set; }
        public List<Player> Players { get; set; }

        public FootballTeam(string name, string country, int ranking)
        {
            Name = name;
            Country = country;
            Ranking = ranking;
            Players = new List < Player >();
        }

        // Добавляет несколько игроков в команду;
        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        //Удаляет одного игрока из команды;
        public void RemovePlayer(string playerName)
        {
            Player playerToRemove = Players.Find(player => player.Name.Equals(playerName));
            if (playerToRemove != null)
            {
                Players.Remove(playerToRemove);
            }
        }

        // Получаем массив игроков на определенной позиции
        public List<Player> GetPlayersByPosition(string position)
        {
            return Players.FindAll(player => player.Position.Equals(position));
        }


        public string ToJson()
        {
            return JsonConvert.SerializeObject(Players);
        }

    }
    public class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }

        public Player(string name, int age, string position)
        {
            Name = name;
            Age = age;
            Position = position;
        }
        

    }

}
