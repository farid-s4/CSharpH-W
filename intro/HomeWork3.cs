

const int size = 3;
string[,] arena = new string[size, size];

void Arena()
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            arena[i, j] = " ";
        }
    }
}

void PrintArena (){
    Arena();
    Console.WriteLine($" {arena[0, 0]} | {arena[0, 1]} | {arena[0, 2]} ");
    Console.WriteLine("-----------");
    Console.WriteLine($" {arena[1, 0]} | {arena[1, 1]} | {arena[1, 2]} ");
    Console.WriteLine("-----------");
    Console.WriteLine($" {arena[2, 0]} | {arena[2, 1]} | {arena[2, 2]} ");
}

int choose = 0;
Console.WriteLine("1. Choose what you want to do: ");
Console.WriteLine("2. Play with computer");
Console.WriteLine("3. Play with friend");
Console.WriteLine("4. Exit");

choose = int.TryParse(Console.ReadLine(), out choose) ? choose : 0;
switch (choose)
{
    case 1:
        {
            while (true)
            {

            }
            break;
        }
}