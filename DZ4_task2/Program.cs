/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
Console.Clear();
Console.Write("Введите целое число: ");
int numA = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма цифр числа {numA} = {sumDigit(numA)}");

int sumDigit (int a){
    int res = 0;

        while(a !=0){
           res += a % 10;
           a /= 10;
        }
    return res;
}
