Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number > 0)
{
    Console.WriteLine("Число положительное!");
}
else if (number < 0)
{
    Console.WriteLine("Число отрицательное!");
}
else
{
    Console.WriteLine("Число равно нулю.");
}
Console.Write("Введите балл (0-100): ");
int score = int.Parse(Console.ReadLine());
if (score >= 91)
{
    Console.WriteLine("Оценка: Отлично (5)");
} else if (score >= 71)
{
    Console.WriteLine("Оценка: Хорошо (4)");
} else if (score >= 51)
{
    Console.WriteLine("Оценка: Удовлетворительно (3)");
} else
{
    Console.WriteLine("Оценка: Неудовлетворительно (2)");
}

Console.WriteLine("Введите кол-во посещений (из 19): ");
int attendance = int.Parse(Console.ReadLine());
Console.Write("Введите средний балл по практике: ");
double practiceGpa = double.Parse(Console.ReadLine());
bool goodAttendance = attendance >= 14;
bool goodGrades = practiceGpa >= 3.0;
if (goodAttendance && goodGrades)
{
    Console.WriteLine ("+ Допуск к экзамену разрешён.");   
}
else if (!goodAttendance && goodGrades)
{
    Console.WriteLine("- Недостаточкно посещений. Нужно отработать пропуски.");
}
else if (goodAttendance && !goodGrades)
{
    Console.WriteLine("- Низкий балл по практике. Нужно пересдать работы.");
}
else
{
    Console.WriteLine("- Проблемы и с посещаемостью, и с оценками. Срочно к преподавателю.");
}

Console.Write("Введите ваш возраст: ");
int age = int.Parse(Console.ReadLine());
string ageGroup = age >= 18 ? "совершеннолетний" : "несовершеннолетний";
Console.WriteLine($"Вы {ageGroup}.");

Console.Write("\nВведите температуру за окном (°C): ");
double temp = double.Parse(Console.ReadLine());
string weather = temp >= 20 ? "тепло" : (temp >= 0 ? "прохладно" : "мороз");
Console.WriteLine($"За окном {weather}.");

Console.Write("\nВведите число: ");
int n = int.Parse(Console.ReadLine());
string parity = n % 2 == 0 ? "чётное" : "нечётное";
Console.WriteLine($"Число {n} — {parity}.");
