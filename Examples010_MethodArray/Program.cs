int[] array = { 5, 17, 2, 4, 10, 25, 47, 2, 6 };
int n = array.Length;
int find = 2;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;
}
