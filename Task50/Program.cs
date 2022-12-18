/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

int m = 3;
int n = 4;
int[,] array = new int[m,n];
Random rnd = new Random();

for (int i = 0; i < n; i++) {
    for (int j = 0; j < m; j ++) {
        int num = rnd.Next(-100, 101);
        array[j,i] = num;
    }
}

Console.WriteLine("Введите позицию элемента i:");
int k = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите позицию элемента j:");
int l = Convert.ToInt32(Console.ReadLine());

if (k < n && l < m) {
    Console.WriteLine("Ваш элемент = {0}:", array[k,l]);
} else {
    Console.WriteLine("Нет такого элемента");
}