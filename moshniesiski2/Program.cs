ConsoleKeyInfo key =  Console.ReadKey();
while (true)
{
    if (key.Key == ConsoleKey.D7)
    {
        Console.Beep(2616, 500);
    }
    key = Console.ReadKey(true);
}