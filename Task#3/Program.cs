// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру дня недели: ");
int num = int.Parse(Console.ReadLine());
if ( 0 < num & num < 8 )
{
    if (5 < num & num < 8)
    {
        Console.WriteLine("Да, это выходной день");
    }
    else
    {
        Console.WriteLine(" Нет, это будний день");
    }
}
else
{
    Console.WriteLine("Нет такого дня недели");
}