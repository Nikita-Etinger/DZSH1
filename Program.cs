using System;

class Program
{
    static string GetSeason(int month)
    {
        if (month >= 3 && month <= 5)
        {
            return "Весна";
        }
        else if (month >= 6 && month <= 8)
        {
            return "Лето";
        }
        else if (month >= 9 && month <= 11)
        {
            return "Осень";
        }
        else
        {
            return "Зима";
        }
    }
    static void Main()
    {
        Console.WriteLine("Введите число от 1 до 100:");/////////////////////////////////////////////////////////////////////////////////////////////
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number >= 1 && number <= 100)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Ошибка: число не в диапазоне от 1 до 100");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: введено некорректное число");
        }




        Console.WriteLine("Введите два числа (значение и процент):");////////////////////////////////////////////////////////////////////////////////////////////
        if (double.TryParse(Console.ReadLine(), out double value) && double.TryParse(Console.ReadLine(), out double percent))
        {
            double result = (value * percent) / 100;
            Console.WriteLine($"Результат: {result}");
        }
        else
        {
            Console.WriteLine("Ошибка: введены некорректные числа");
        }




        Console.WriteLine("Введите четыре цифры:");////////////////////////////////////////////////////////////////////////////////////////////
        if (int.TryParse(Console.ReadLine(), out int digit1) &&
            int.TryParse(Console.ReadLine(), out int digit2) &&
            int.TryParse(Console.ReadLine(), out int digit3) &&
            int.TryParse(Console.ReadLine(), out int digit4))
        {
            int numberX = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;
            Console.WriteLine($"Сформированное число: {numberX}");
        }
        else
        {
            Console.WriteLine("Ошибка: введены некорректные цифры");
        }


        Console.WriteLine("Введите шестизначное число:");///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (int.TryParse(Console.ReadLine(), out int numberZ))
        {
            if (numberZ >= 100000 && numberZ <= 999999)
            {
                Console.WriteLine("Введите номера разрядов для обмена (например, 1 и 6):");
                if (int.TryParse(Console.ReadLine(), out int digit1Z) && int.TryParse(Console.ReadLine(), out int digit2Z))
                {
                    if (digit1Z >= 1 && digit1Z <= 6 && digit2Z >= 1 && digit2Z <= 6)
                    {
                        int[] digits = new int[6];
                        int temp = numberZ;

                        for (int i = 5; i >= 0; i--)
                        {
                            digits[i] = temp % 10;
                            temp /= 10;
                        }

                        int tempDigit = digits[digit1 - 1];
                        digits[digit1Z - 1] = digits[digit2Z - 1];
                        digits[digit2Z - 1] = tempDigit;

                        int result = 0;
                        for (int i = 0; i < 6; i++)
                        {
                            result = result * 10 + digits[i];
                        }

                        Console.WriteLine($"Измененное число: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: номера разрядов должны быть от 1 до 6");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: введены некорректные номера разрядов");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: число не шестизначное");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: введено некорректное число");
        }

        Console.WriteLine("Введите дату в формате dd.MM.yyyy:");
        if (DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
        {
            string season = GetSeason(date.Month);
            string dayOfWeek = date.ToString("dddd", System.Globalization.CultureInfo.GetCultureInfo("ru-RU"));//для корректировки дней недели

            Console.WriteLine($"Сезон: {season}, День недели: {dayOfWeek}");
        }
        else
        {
            Console.WriteLine("Ошибка: введена некорректная дата");
        }

        Console.WriteLine("Введите температуру:");//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (double.TryParse(Console.ReadLine(), out double temperature))
        {
            Console.WriteLine("Выберите действие (1 - Фаренгейт в Цельсий, 2 - Цельсий в Фаренгейт):");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                double convertedTemperature;

                if (choice == 1)
                {
                    convertedTemperature = (temperature - 32) * 5 / 9;
                    Console.WriteLine($"Температура в Цельсиях: {convertedTemperature} °C");
                }
                else if (choice == 2)
                {
                    convertedTemperature = (temperature * 9 / 5) + 32;
                    Console.WriteLine($"Температура в Фаренгейтах: {convertedTemperature} °F");
                }
                else
                {
                    Console.WriteLine("Ошибка: выберите действие 1 или 2");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введено некорректное действие");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: введена некорректная температура");
        }

        Console.WriteLine("Введите два числа (границы диапазона):");///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (int.TryParse(Console.ReadLine(), out int num1) && int.TryParse(Console.ReadLine(), out int num2))
        {
            int start = Math.Min(num1, num2);
            int end = Math.Max(num1, num2);

            if (start % 2 != 0)
            {
                start++; 
            }

            for (int i = start; i <= end; i += 2)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Ошибка: введены некорректные числа");
        }
    }
}