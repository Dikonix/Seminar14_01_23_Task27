void Sum(int number)
{
    int accumulator = number;
    int sum = 0;

    while (accumulator > 0)
    {
        sum += accumulator % 10;
        accumulator /= 10;
    }
    Console.WriteLine($"Сумма цифр в числе {number} равна {sum}");
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Sum(number);