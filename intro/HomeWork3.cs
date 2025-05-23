const int size = 3;
string[,] arena = new string[size, size];

void PrintArena (){
    Console.WriteLine($" {arena[0, 0]} | {arena[0, 1]} | {arena[0, 2]} ");
    Console.WriteLine("---------");
    Console.WriteLine($" {arena[1, 0]} | {arena[1, 1]} | {arena[1, 2]} ");
    Console.WriteLine("---------");
    Console.WriteLine($" {arena[2, 0]} | {arena[2, 1]} | {arena[2, 2]} ");
    Console.WriteLine('\n');
}

bool ChangeArena(int x, int y, string player)
{
    x -= 1;
    y -= 1;
    if (x < 0 || x >= size || y < 0 || y >= size)
    {
        return false;
    }
    if (arena[x, y] == "x" || arena[x, y] == "0")
    {
        return false;
    }
    arena[x, y] = player;
    
    return true;

}

bool AIplayer()
{
    Random random = new Random();
    string player = "0";

    int x, y;

    do
    {
        x = random.Next(0, size);
        y = random.Next(0, size);
    } while (!ChangeArena(x + 1, y + 1, player)); 

    return true;
}

int CheckWinner()
{
    
    for (int i = 0; i < size; i++)
    {
        if (arena[i, 0] == arena[i, 1] && arena[i, 1] == arena[i, 2] && arena[i, 0] != null)
        {
            return 1;
        }
    }
   
    for (int i = 0; i < size; i++)
    {
        if (arena[0, i] == arena[1, i] && arena[1, i] == arena[2, i] && arena[0, i] != null)
        {
            return 1;
        }
    }
    
    if (arena[0, 0] == arena[1, 1] && arena[1, 1] == arena[2, 2] && arena[0, 0] != null)
    {
        return 1;
    }
    if (arena[0, 2] == arena[1, 1] && arena[1, 1] == arena[2, 0] && arena[0, 2] != null)
    { 
        return 1;
    }

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if (arena[i, j] == null)
            {
                return 0;
            }
        }
    }
    
    return -1;
}

int choose = 0;
Console.WriteLine(" Choose what you want to do: ");
Console.WriteLine("1. Play with computer");
Console.WriteLine("2. Play with friend");
Console.WriteLine("3. Exit");
choose = int.TryParse(Console.ReadLine(), out choose) ? choose : 0;
switch (choose)
{
    case 1:
        {
            string player;
            Console.WriteLine("X/0");
            player = Console.ReadLine();
            while (true)
            {
                if (CheckWinner() == 1)
                {
                    Console.WriteLine("Game over");
                    return;
                }
                
                if (CheckWinner() == -1)
                {
                    Console.WriteLine("Draw");
                    return;
                }
                int firstPosition = 0;
                int secondPosition = 0;

                Console.WriteLine("First position");
                firstPosition = int.TryParse(Console.ReadLine(), out firstPosition) ? firstPosition : 0;
                Console.WriteLine("Second position");
                secondPosition = int.TryParse(Console.ReadLine(), out secondPosition) ? secondPosition : 0;
                

                if (player != "x" && player != "0")
                {
                    Console.WriteLine("Invalid player");
                    return;
                }

                

                if (player == "x")
                {
                   
                    if (ChangeArena(firstPosition, secondPosition, player))
                    {
                        PrintArena();
                        AIplayer();
                        PrintArena();
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid position");
                        continue;
                    }
                    

                }
            }
            

            break;
        }
    case 2:
        {
            
            break;
        }
    case 3:
        {
            Console.WriteLine("You chose to exit");
            break;
        }


        default:
        {
            Console.WriteLine("Invalid choice, please try again");
            break;
        }


}