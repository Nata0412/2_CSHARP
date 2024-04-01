int n = 10;
int[] array = { 2, 5, 4, 7, 8, 9, 35, 8, 3, 9 };
int i = 0;
while (i < n)
{
    if (array[i] % 2 == 0)
    {
    //Console.Write(arr[i]);
    //Console.Write(' ');
    Console.Write($"{array[i]} ");
    }
    i = i + 1;

}