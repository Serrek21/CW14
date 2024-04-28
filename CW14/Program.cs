using System;
using System.Linq;

class Program
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string University { get; set; }
    }
    static void Main()
    {
        //1

        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 14, 16, 18, 21, 24, 28, 32 };

        // Отримати весь масив цілих.
        var allNumbers = numbers.ToArray();

        // Отримати парні цілі.
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToArray();

        // Отримати непарні цілі.
        var oddNumbers = numbers.Where(n => n % 2 != 0).ToArray();

        // Отримати значення більше заданого.
        int threshold = 10;
        var greaterThanThreshold = numbers.Where(n => n > threshold).ToArray();

        // Отримати числа в заданому діапазоні.
        int startRange = 5;
        int endRange = 15;
        var numbersInRange = numbers.Where(n => n >= startRange && n <= endRange).ToArray();

        // Отримати числа, кратні семи. Результат відсортуйте за зростанням.
        var multiplesOfSeven = numbers.Where(n => n % 7 == 0).OrderBy(n => n).ToArray();

        // Отримати числа, кратні восьми. Результат відсортуйте за спаданням.
        var multiplesOfEight = numbers.Where(n => n % 8 == 0).OrderByDescending(n => n).ToArray();

        // Вивід результатів
        Console.WriteLine("All numbers: " + string.Join(", ", allNumbers));
        Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
        Console.WriteLine("Odd numbers: " + string.Join(", ", oddNumbers));
        Console.WriteLine("Numbers greater than " + threshold + ": " + string.Join(", ", greaterThanThreshold));
        Console.WriteLine("Numbers in range " + startRange + " to " + endRange + ": " + string.Join(", ", numbersInRange));
        Console.WriteLine("Multiples of seven: " + string.Join(", ", multiplesOfSeven));
        Console.WriteLine("Multiples of eight: " + string.Join(", ", multiplesOfEight));


        //2
        string[] cities = { "Kyiv", "Lviv", "Odesa", "Kharkiv", "Dnipro", "Zaporizhzhia", "Mykolaiv", "Poltava" };

        // Отримати весь масив міст.
        var allCities = cities.ToArray();

        // Отримати міста з довжиною назви, що дорівнює заданому.
        int nameLength = 6;
        var citiesWithSpecificLength = cities.Where(c => c.Length == nameLength).ToArray();

        // Отримати міста, назви яких починаються з літери A.
        var citiesStartingWithA = cities.Where(c => c.StartsWith("A")).ToArray();

        // Отримати міста, назви яких закінчуються літерою M.
        var citiesEndingWithM = cities.Where(c => c.EndsWith("M")).ToArray();

        // Отримати міста, назви яких починаються з літери N і закінчуються літерою K.
        var citiesStartingWithNAndEndingWithK = cities.Where(c => c.StartsWith("N") && c.EndsWith("K")).ToArray();

        // Отримати міста, назви яких починаються з Ne. Результат відсортувати за спаданням.
        var citiesStartingWithNe = cities.Where(c => c.StartsWith("Ne")).OrderByDescending(c => c).ToArray();

        // Вивід результатів
        Console.WriteLine("All cities: " + string.Join(", ", allCities));
        Console.WriteLine("Cities with name length " + nameLength + ": " + string.Join(", ", citiesWithSpecificLength));
        Console.WriteLine("Cities starting with A: " + string.Join(", ", citiesStartingWithA));
        Console.WriteLine("Cities ending with M: " + string.Join(", ", citiesEndingWithM));
        Console.WriteLine("Cities starting with N and ending with K: " + string.Join(", ", citiesStartingWithNAndEndingWithK));
        Console.WriteLine("Cities starting with Ne (descending order): " + string.Join(", ", citiesStartingWithNe));


        List<Student> students = new List<Student>
        {
            new Student { FirstName = "Lox", LastName = "Goe", Age = 18, University = "Harvard" },
            new Student { FirstName = "Jon", LastName = "Gon", Age = 20, University = "MIT" },
            new Student { FirstName = "Veruca", LastName = "Ker", Age = 22, University = "Oxford" },
            new Student { FirstName = "Artem", LastName = "Dant", Age = 19, University = "MIT" },
            new Student { FirstName = "Maks", LastName = "Silver", Age = 21, University = "Oxford" }
        };

        // Отримати весь масив студентів.
        var allStudents = students.ToArray();

        // Отримати список студентів з ім'ям Boris.
        var LoxStudents = students.Where(s => s.FirstName == "Lox").ToArray();

        // Отримати список студентів з прізвищем, яке починається з Bro.
        var SilStudents = students.Where(s => s.LastName.StartsWith("Sil")).ToArray();

        // Отримати список студентів, старших 19 років.
        var olderThanNineteen = students.Where(s => s.Age > 19).ToArray();

        // Отримати список студентів, старших 20 років і молодших 23 років.
        var betweenTwentyAndTwentyThree = students.Where(s => s.Age > 20 && s.Age < 23).ToArray();

        // Отримати список студентів, які навчаються в MIT.
        var mitStudents = students.Where(s => s.University == "MIT").ToArray();

        // Отримати список студентів, які навчаються в Oxford, і вік яких старше 18 років. Результат відсортуйте за віком, за спаданням.
        var oxfordStudentsOver18 = students.Where(s => s.University == "Oxford" && s.Age > 18).OrderByDescending(s => s.Age).ToArray();

        // Вивід результатів
        Console.WriteLine("All students:");
        foreach (var student in allStudents)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, University: {student.University}");
        }

        Console.WriteLine();

        Console.WriteLine("Students with name Lox:");
        foreach (var student in LoxStudents)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, University: {student.University}");
        }

        Console.WriteLine();

        Console.WriteLine("Students with last name starting with Sil:");
        foreach (var student in SilStudents)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, University: {student.University}");
        }

        Console.WriteLine();

        Console.WriteLine("Students older than 19:");
        foreach (var student in olderThanNineteen)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, University: {student.University}");
        }

        Console.WriteLine();

        Console.WriteLine("Students between 20 and 23 years old:");
        foreach (var student in betweenTwentyAndTwentyThree)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, University: {student.University}");
        }

        Console.WriteLine();

        Console.WriteLine("Students studying at MIT:");
        foreach (var student in mitStudents)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, University: {student.University}");
        }

        Console.WriteLine();

        Console.WriteLine("Students studying at Oxford and over 18 years old (sorted by age, descending):");
        foreach (var student in oxfordStudentsOver18)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}, Age: {student.Age}, University: {student.University}");
        }
    }
}