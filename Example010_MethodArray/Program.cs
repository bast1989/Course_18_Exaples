int[] array = { 1, 12, 31, 4, 15, 16, 4, 17, 18 };
int n = array.Length;

Console.WriteLine("Введите чило для поиска его позиции в массиве: ");

int find = int.Parse(Console.ReadLine()!);
int index = 0;

while(index < n) 
{
    if(array[index] == find)
    {
        Console.WriteLine("Введёное вами число находится на пизиции: " + index);
        break;
    }
    index++;
}