Console.Clear();

Console.WriteLine("Определяем расстояние между двумя точками в 3-х мерном пространстве по указанным вами координатам");
Console.WriteLine("Координаты точек необходимо указать в целых числах!");

Console.Write("Введите координату Х первой точки=>");
int Xa = Int32.Parse(Console.ReadLine());
Console.Write("Введите координату Y первой точки=>");
int Ya = Int32.Parse(Console.ReadLine());
Console.Write("Введите координату Z первой точки=>");
int Za = Int32.Parse(Console.ReadLine());
Console.Write("Введите координату Х второй точки=>");
int Xb = Int32.Parse(Console.ReadLine());
Console.Write("Введите координату Y второй точки=>");
int Yb = Int32.Parse(Console.ReadLine());
Console.Write("Введите координату Z второй точки=>");
int Zb = Int32.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(Xb-Xa,2)+Math.Pow(Yb-Ya,2)+Math.Pow(Zb-Za,2));

Console.WriteLine($"Расстояние между этими точками составляет:{result:f2}");
