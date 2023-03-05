/*
//Вид 1 - Не возвращают, не принимают

void Method1()
{
    Console.WriteLine("Автор: ...");
}

Method1();

Console.WriteLine();





//Вид 2 - Не возвращают, принимают

void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Hello world!");

Console.WriteLine();

void Method3(string strA, string strB, int num)
{
    Console.WriteLine(strA + strB);
    Console.WriteLine(num * num);
}

Method3("Hello ", "world!", 2);
Method3(strB: "Hello ", strA: "world!", num: 2); // Явное указание значений именованных аргументов, порядок аргументов не важен

Console.WriteLine();





//Вид 3 - Возвращают, не принимают

string Method4()
{
    DateTime now = DateTime.Now;
    return $"Текущие дата и время: {now.Day}.{now.Month}.{now.Year} - {now.Hour}:{now.Minute}";
}

string nowDate = Method4();
Console.WriteLine(nowDate);

Console.WriteLine();





//Вид 4 - Возвращают, принимают

string Method5(int count, string c)
{
    int i = 0;
    string result = "";
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string strC = Method5(5, "Hello world!");
Console.WriteLine(strC);
Console.WriteLine();





// Цикл for

string Method6(string strD, int count)
{
    string result = "";
    for (int i = 0; i < count; i++)
    {
        result += strD;
    }
    return result;
}

Console.WriteLine(Method6("WoW", 6));
Console.WriteLine();





//Таблица умножения

void multiTab()
{
    for (int i = 2; i <= 9; i++)
    {
        Console.WriteLine($"Таблица умножения на {i}: ");
        for (int j = 1; j <= 9; j++)
        {
            Console.WriteLine($"{i} * {j} = {i * j}");
        }
        Console.WriteLine();
    }
}

multiTab();







//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.

// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что," +
                "ежели бы вас послали вместо нашего милого Винценгероде," +
                "вы бы взяли приступом согласие прусского короля." +
                "Вы так красноречивы. Вы дадите мне чаю?";

string Method7(string str, char charA, char charB)
{
    string result = "";
    for(int i = 0; i < text.Length; i++)
    {
        if(str[i] == charA) result += charB;
        else result += str[i];
    }
    return result;
}

string newText = Method7(text, ' ', '|');
Console.WriteLine(newText);

*/

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}



void SortArray(int[] arr)
{
    for (int i = 0; i < arr.Length -1; i++)        
    {
        int minPos = i;

        for (int j = i + 1; j < arr.Length; j++)
        {
            if(arr[j] < arr[minPos]) minPos = j;
        }
        
        int temp = arr[i];
        arr[i] = arr[minPos];
        arr[minPos] = temp;
    }
}

PrintArray(arr);
SortArray(arr);
PrintArray(arr);
