int[] array = {11, 12, 325, 346, 18, 64, 23, 53, 33};

int n = array.Length;
int find = 64;
int index = 0;
while(index<n){
    if (array[index]== find)
    {
        Console.WriteLine(index);
    }
    index++;
}