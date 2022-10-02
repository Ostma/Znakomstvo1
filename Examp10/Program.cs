void FillArray(int[] coll)
{
    int length = coll.Length;
    int index = 0;
    while (index < length)
    {
       coll[index] = new Random().Next(1, 10);
       index++;
    }
}

void PrintArray(int[] collect)
{
    int count = collect.Length;
    int pos = 0;

    while (pos < count)
    {
        Console.WriteLine(collect[pos]);
        pos++;
    }

}

int [] array = new int[10];
FillArray(array);
PrintArray(array);
