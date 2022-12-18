/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


int m = 3;
int n = 4;
int[,] array = new int[m,n];
Random rnd = new Random();

for (int i = 0; i < n; i++) {
    for (int j = 0; j < m; j ++) {
        int num = rnd.Next(1, 11);
        array[j,i] = num;
    }
}

for (int i = 0; i < n; i++) {
    Console.Write("[");
    for (int j = 0; j < m; j ++) {
        Console.Write("{0}, ", array[j,i]);
    }
    Console.WriteLine("]");
}
Console.WriteLine();
double[] resultArr = new double[m];

for (int i = 0; i < m; i++) {
    var sum = 0;
    for (int j = 0; j < n; j ++) {
        sum = sum + array[i,j];
        Console.WriteLine("sum = {0}, ", sum);
    }
    double res = (double)sum/(double)n;
    resultArr[i] = res;
    Console.WriteLine("n = {0}", n);
    Console.WriteLine(" arifmetic = {0}", res);
    Console.WriteLine();
}

for (int k = 0; k < resultArr.Length; k++) {
    Console.Write("{0} ", resultArr[k]);
}