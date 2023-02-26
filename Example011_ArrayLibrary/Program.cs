﻿void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int pos = collection.Length;
    int count = 0;
    int result = -1;

    while(count < pos)
    {
        if(collection[count] == find)
        {
            result = count;
            break;
        }
        count++;
    }
    return result;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 7);
Console.WriteLine(pos);