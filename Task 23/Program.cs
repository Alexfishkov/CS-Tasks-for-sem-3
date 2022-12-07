Console.Clear();
Console.WriteLine("Показываем кубы всех чисел в диапазоне от 1 до введённого Вами N");
Console.Write("Введите ваш N (целое число > 0)=>");
int number = Int32.Parse(Console.ReadLine());
double res = 1;

for (int i = 1; i <= number; i++)
{
    res = Math.Pow(i, 3);
    Console.WriteLine($"куб числа {i} равен {res}");
}

