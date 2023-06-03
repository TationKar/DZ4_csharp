/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */
Console.Clear();

Console.Write("Введите размер массива Size: ");
int Size = int.Parse(Console.ReadLine()!);
Console.Write("Введите размер максимального числа элемента массива MaxNum: ");
int MaxNum = int.Parse(Console.ReadLine()!);
int[] arrNum = ArrayRand(Size, MaxNum);
Console.WriteLine();
printArr(arrNum);

int[] ArrayRand(int sz, int mxn){
int[] digit = new int[sz];
for (int i = 0; i < sz; i++)
    digit[i] = new Random().Next(mxn+1); 
return digit;
}

void printArr(int []arr){
    // for (int i = 0; i < 8; i++)
    //     Console.Write($"{arr[i]} ");
    Console.WriteLine($"[{String.Join(", ", arr)}]");    
}