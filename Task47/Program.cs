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

for (int i = 0; i < n; i++) {
    Console.Write("[");
    for (int j = 0; j < m; j ++) {
        Console.Write("{0}, ", array[j,i]);
    }
    Console.WriteLine("]");
}