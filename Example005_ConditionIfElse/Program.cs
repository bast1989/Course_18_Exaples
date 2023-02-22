Console.WriteLine("Введите имя пользователяя: ");
string user_name = Console.ReadLine();

if (user_name.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!!!");
}
else
{
    Console.WriteLine("Привет " + user_name);
}