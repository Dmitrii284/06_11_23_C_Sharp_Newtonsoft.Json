using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Задание:
Вам необходимо создать простую консольную программу на C#, которая работает с JSON файлами. Программа должна выполнять следующие шаги:

Программа должна читать JSON файл "input.json", содержащий информацию о студентах. Файл должен иметь следующую структуру:
{
[
{
"name": "Иван",
"age": 20,
"grades": [88, 92, 76]
},
{
"name": "Мария",
"age": 19,
"grades": [95, 87, 92]
},
]
}

С помощью библиотеки Newtonsoft.Json (Newtonsoft.Json), программа должна сериализовать содержимое файла в список объектов типа "Student". 
Создайте соответствующий класс "Student" с необходимыми свойствами (name, age, grades).

Программа должна вычислить средний балл каждого студента и вывести информацию о студентах в следующем формате:

Имя: Иван
Возраст: 20
Средний балл: 85.3

Имя: Мария
Возраст: 19
Средний балл: 91.3

Всю полученную информацию о студентах необходимо сериализовать обратно в JSON формат и сохранить в файл "output.json".
Пожалуйста, обратите внимание на использование библиотеки Newtonsoft.Json для работы с JSON.
 
 */
namespace _06_11_23_C_Sharp_Randomaizer
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }


        // Метод для вычисления среднего балла
        public static double CalculateAverageGrade(List<int> grades)
        {
            int sum = 0;
            foreach (int grade in grades)
            {
                sum += grade;
            }
            return (double)sum / grades.Count;
        }
    }

}
