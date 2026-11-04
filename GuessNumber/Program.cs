// Console.Write("Введите число: ");

// if (int.TryParse(Console.ReadLine(), out int number))
// {
//     string message = number switch
//     {
//         > 0 => "Число положительное.",
//         < 0 => "Число отрицательное.",
//         _ => "Число равно нулю."
//     };

//     Console.WriteLine(message);
// }
// else
// {
//     Console.WriteLine("Ошибка: введено не число.");
// }

// Console.Write("Введите балл (0-100): ");

// if (int.TryParse(Console.ReadLine(), out int score) && score >= 0 && score <= 100)
// {
//     switch (score)
//     {
//         case >= 91:
//             Console.WriteLine("Оценка: Отлично (5)");
//             break;
//         case >= 71:
//             Console.WriteLine("Оценка: Хорошо (4)");
//             break;
//         case >= 51:
//             Console.WriteLine("Оценка: Удовлетворительно (3)");
//             break;
//         default:
//             Console.WriteLine("Оценка: Неудовлетворительно (2)");
//             break;
//     }
// }
// Console.Write("Введите количество посещений (из 19): ");
// int attendance = int.Parse(Console.ReadLine());
// Console.Write("Введите средний балл по практике: ");
// double practiceGpa = double.Parse(Console.ReadLine());
// bool goodAttendance = attendance >= 14; // посещаемость >= 75%
// bool goodGrades = practiceGpa >= 3.0;   // оценка не ниже 3
// if (goodAttendance && goodGrades) {
//     Console.WriteLine("+ Допуск к экзамену разрешён.");
// }
// else if (!goodAttendance && goodGrades) {
//     Console.WriteLine("- Недостаточно посещений. Нужно отработать пропуски.");
// }
// else if (goodAttendance && !goodGrades) {
//     Console.WriteLine("- Низкий балл по практике. Нужно пересдать работы.");
// }
// else {
//     Console.WriteLine("- Проблемы и с посещаемостью, и с оценками. Срочно к преподавателю.");
// }
// Console.Write("Введите ваш возраст: ");
// int age = int.Parse(Console.ReadLine());
// string ageGroup = age >= 18 ? "совершеннолетний" : "несовершеннолетний";
// Console.WriteLine($"Вы {ageGroup}.");

// Console.Write("\nВведите температуру за окном (°C): ");
// double temp = double.Parse(Console.ReadLine());
// string weather = temp >= 20 ? "тепло" : (temp >= 0 ? "прохладно" : "мороз");
// Console.WriteLine($"За окном {weather}.");

// Console.Write("\nВведите число: ");
// int n = int.Parse(Console.ReadLine());
// string parity = n % 2 == 0 ? "чётное" : "нечётное";
// Console.WriteLine($"Число {n} – {parity}.");

// Console.WriteLine("Меню");
// Console.WriteLine("1. Посмотреть расписание");
// Console.WriteLine("2. Посмотреть оценки");
// Console.WriteLine("3. Связаться с преподавателем");
// Console.WriteLine("4. Выйти");
// Console.Write("Выберите пункт (1-4): ");
// string choice = Console.ReadLine();
// switch (choice)
// {
//     case "1":
//         Console.WriteLine("Расписание: ИСП-241, каб. 1-36, 10:10");
//         break;
//     case "2":
//         Console.WriteLine("Ваши оценки: ИРСПО - мало, РПМ - чуть лучше");
//         break;
//     case "3":
//         Console.WriteLine("Email: denis.leontev92@yandex.ru");
//         break;
//     case "4":
//         Console.WriteLine("Пока!!");
//         break;
//     default:
//         Console.WriteLine($"Ошибка: пункт <<{choice}>> не существует");
//         break;
// }
// Console.WriteLine("Меню");
// Console.Write("Выберите месяц (1-12): ");
// string choice = Console.ReadLine();
// switch (choice)
// {
//     case "12":
//     case "1":
//     case "2":
//         Console.WriteLine("Зима");
//         break;
//     case "3":
//     case "4":
//     case "5":
//         Console.WriteLine("Весна");
//         break;
//     case "6":
//     case "7":
//     case "8":
//         Console.WriteLine("лето");
//         break;
//     case "9":
//     case "10":
//     case "11":
//         Console.WriteLine("Осень");
//         break;
//     default:
//         Console.WriteLine($"такого месяца <<{choice}>> нет, их всего 12");
//         break;
// }
// Random random = new Random();
// int secret = random.Next(1, 101);
// int attempts = 0;
// bool guessed = false;
// Console.WriteLine("Угадай число (1-100)");
// Console.WriteLine("Я загадал число. Попробуй угадать!");

// while (!guessed) {
//     Console.Write($"Попытка {attempts + 1}. Твой вариант: ");
//     string input = Console.ReadLine();

//     if (!int.TryParse(input, out int guess)) {
//         Console.WriteLine("Введи целое число, а не текст");
//         continue;
//     }

//     if (guess < 1 || guess > 100) {
//         Console.WriteLine("Число должно быть от 1 до 100");
//         continue;
//     }

//     attempts++;

//     if (guess < secret) {
//         int diff = secret - guess;
//         string hint = GetHint(diff);
//         Console.WriteLine($"Больше {hint}\n");
//     }
//     else if (guess > secret) {
//         int diff = guess - secret;
//         string hint = GetHint(diff);
//         Console.WriteLine($"Меньше {hint}\n");
//     }
//     else {
//         guessed = true; 
//     }
// }

// string result = attempts <= 7
//     ? $"Отличный результат! Всего {attempts} попыток."
//     : $"Число найдено за {attempts} попыток. Можно лучше!";

// Console.WriteLine($" Правильно! Загаданное число: {secret}");
// Console.WriteLine(result);

// string GetHint(int difference) {
//     switch (difference) {
//         case <= 3:
//             return "Горячо!";
//         case <= 10:
//             return "Тепло";
//         case <= 25:
//             return "Прохладно";
//         default:
//             return "Холодно";
//     }
// }

// Console.Write("Введите пароль: ");
// string p1 = Console.ReadLine();
// Console.Write("Подтвердите пароль: ");
// string p2 = Console.ReadLine();
// if (p1 == p2)
// {
//     Console.WriteLine("Пароль принят");
// }
// else
// {
//     Console.WriteLine("Пароль не принят");
// }

Console.Write("Введите ваш возраст: ");
int age = int.Parse(Console.ReadLine());
if (age >= 18)
{
    Console.WriteLine("Доступ разрешён");
}
else
{
    Console.WriteLine("Доступ запрещён");
}
