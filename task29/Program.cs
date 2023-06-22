int[] createArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        
        if (i == array.Length - 1)
        {
            Console.Write(array[i] + ".");
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
}

int[] array = createArray();
printArray(array);
