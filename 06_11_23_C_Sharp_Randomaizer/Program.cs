using System.Numerics;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace _06_11_23_C_Sharp_Randomaizer
{

    public class Randomaizer
    {
        private const int Multiplier = 1103515245;
        private const int Increment = 12345;
        private const int Modulus = 2147483647;

        private int seed;
        public Randomaizer(int seed)
        {
            this.seed = seed;
        }

        public int Next(int min, int max)
        {
            seed = (Multiplier * seed + Increment) % Modulus;
            return min + seed % (max - min + 1);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //// Чтение файла
            //string json = System.IO.File.ReadAllText("input.json"); // Создай путь к папке и папку!!!
            //// Десериализация файла
            //List<Student> students = JsonConvert.DeserializeObject<List<Student>>(json);
            //// Считаем среднее арифметическое
            //foreach (Student student in students)
            //{
            //  double averageGrade = Student.CalculateAverageGrade(student.Grades);

            //    Console.WriteLine("Имя: " + student.Name);
            //    Console.WriteLine("Возраст: " + student.Age);
            //    Console.WriteLine("Средний балл: " + averageGrade.ToString("F1"));
            //    Console.WriteLine();
            //}
            //// Сериализация списка студентов в JSON формат
            //string outputJson = JsonConvert.SerializeObject(students);

            //// Сохранение JSON в файл
            //System.IO.File.WriteAllText("output.json", outputJson);

            // Task 2 Links
            // Создаем объект FootballTeam
            FootballTeam team = new FootballTeam("Команда A", "Россия", 1);

            // Добавляем игроков в команду
            team.AddPlayer(new Player("Дмитрий Давыдов", 35, "Форвард"));
            team.AddPlayer(new Player("Артем Шеколадолв", 20, "СреднийФорвард"));
            team.AddPlayer(new Player("Боб Мартинас", 23, "Нападающий"));

            // Удаляем одного игрока из команды (Дмитрий Давыдов)
            team.RemovePlayer("Дмитрий Давыдов");

            // Получаем массив игроков на определенной позиции
            List<Player> midfielders = team.GetPlayersByPosition("СреднийФорвард");

            // Выводим игроков на экран
            Console.WriteLine("СреднийФорвард:");
            foreach (Player player in midfielders)
            {
                Console.WriteLine($"{player.Name}, {player.Age}, {player.Position}");
            }

            // Преобразуем объектl FootballTeam в JSON и выводим его на экран          

            string json = team.ToJson();
            Console.WriteLine("FootballTeam JSON:");
            Console.WriteLine(json);

            Console.ReadLine();
        }

    }        
    
}