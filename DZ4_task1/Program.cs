/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
Console.Clear();
Console.Write("Введите число А: ");
int numA = int.Parse(Console.ReadLine()!);

Console.Write("Введите число B: ");
int numB = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {numA} возведенное в степень {numB} = {natDeg(numA, numB)}");


int natDeg(int a, int b){
int res = a;
for (int i = 1; i < b; i++)
    {
        res *= a; 
    }
return res;
}

Console.WriteLine("Проверка " + Math.Pow(numA,numB));