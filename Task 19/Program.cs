Console.Clear();

int yournumber = 1;

Console.WriteLine("Определяем, является ли введённое вами целое число палиндромом");

while (yournumber > 0)

{

Console.Write("Введите ваше новое целое число (>0)=>");
yournumber = Int32.Parse(Console.ReadLine());

if (yournumber > 0)
{

// Определяем, сколько цифр в введённом числе

int n = 0;
int number = yournumber;
while (number >= 1)
{
    number /= 10;
    n++;
}

// А теперь переворачиваем введённое число наоборот

double n1 = Math.Pow(10, n - 1);
int number1 = yournumber;
double number2 = 0;


for (int i = 0; i <= n; i++)
{
    number2 = number2 + number1 % 10 * n1;
    number1 /= 10;
    n1 /= 10;
}

// Проверяем соответствие исходного числа перевернутому

if (number2 == yournumber)
{
    Console.WriteLine("Данное число является палиндромом");
}

else
{
    Console.WriteLine("Данное число не является палиндромом");
}
}

else break;

}

Console.WriteLine("До свиданья!");