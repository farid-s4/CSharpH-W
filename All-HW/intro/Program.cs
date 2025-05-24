/*
int number = 0;
while (true)
{
    Console.Write("What is your number? ");
    number = int.Parse(Console.ReadLine());
    if (number < 1 || number > 100)
    {
        Console.WriteLine("Please enter a number between 1 and 100.");
        continue;
    }

    if (number % 3 == 0 && number % 5 == 0)
    {
        Console.Write("FizzBuzz");
        break;

    }

    else if (number % 3 == 0)
    {
        Console.Write("Fizz");
        break;
    }

    else if (number % 5 == 0)
    {
        Console.Write("Buzz");
        break;
    }
    else
    {
        Console.Write(number);
        break;
    }
}
*/

//______/Task2/_______//

/*int number = 0;
int percent = 0;
while (true)
{
    Console.Write("Enter a number: ");
    number = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter a percentage: ");
    percent = int.Parse(Console.ReadLine());
    if (percent > 100 && percent < 1)
    {
        Console.WriteLine("You entered a percentage greater than 1 or less than 100");
        continue;
    }
    number = (number * percent) / 100;
    Console.WriteLine($"{percent}% number is : {number}");
}*/

//______/Task3/_______//
/*int number = 0;

Console.WriteLine("Enter first digit");
number +=1000*int.Parse(Console.ReadLine());

Console.WriteLine("Enter second digit");
number += 100*int.Parse(Console.ReadLine());

Console.WriteLine("Enter third digit");
number += 10*int.Parse(Console.ReadLine());

Console.WriteLine("Enter last digit");
number += int.Parse(Console.ReadLine());

Console.WriteLine(number);*/

//______/Task4/_______//

/*int number = 0;

while (true)
{
    Console.WriteLine("Enter a number:");
    number = int.Parse(Console.ReadLine());
    if (number > 99999 && number < 1000000)
    {
        break;
    }
    else
    {
        Console.WriteLine("You entered an invalid number");
        continue;
    }
}

int[] digits = new int[6];


int temp = number;

for (int i = 5; i >= 0 && temp > 0; i--)
{
    digits[i] = temp % 10;
    temp /= 10;
}

Console.WriteLine($"Write first index for reverse");
int fIndex = int.Parse(Console.ReadLine()) - 1;

Console.WriteLine($"Write second index for reverse");
int lIndex = int.Parse(Console.ReadLine()) - 1;

int tmp = digits[fIndex];
digits[fIndex] = digits[lIndex];
digits[lIndex] = tmp;

foreach (var item in digits)
{
    Console.Write(item);
}*/

//______/Task5/_______//

/*Console.WriteLine("Enter date: ");
DateTime date;
date = DateTime.Parse(Console.ReadLine());
Console.WriteLine(date.DayOfWeek);
if (date.Month == 1 || date.Month == 2 || date.Month == 12)
{
    Console.WriteLine("Winter");
}
else if (date.Month == 3 || date.Month == 4 || date.Month == 5)
{
    Console.WriteLine("Spring");
}
else if (date.Month == 6 || date.Month == 7 || date.Month == 8)
{
    Console.WriteLine("Summer");
}
else
{
    Console.WriteLine("Autumn");
}*/

//______/Task6/_______//

/*double temperature;
Console.WriteLine("Enter temperature:");
temperature = double.Parse(Console.ReadLine());
Console.WriteLine("Enter choose, 1- Farengeyt, 2 - Celcium");
int choose = 0;
choose = Convert.ToInt32(Console.ReadLine());
switch (choose)
{
    case 1:
    {
        temperature = temperature* 9 / 5 + 32;
        Console.WriteLine(temperature);
        break;
    }
    case 2:
    {
        temperature = (temperature-32)*5/9;
        Console.WriteLine(temperature);
        break;
    }
    default:
    {
        Console.WriteLine("Invalid choice");
        break;
    }
}*/

//______/Task7/_______//


/*
int fPoint = 0;
int lPoint = 0;
Console.WriteLine("Enter first point: ");
fPoint = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second point: ");
lPoint = Convert.ToInt32(Console.ReadLine());

if (fPoint > lPoint)
{
    int temp = fPoint;
    fPoint = lPoint;
    lPoint = temp;
}
int size = lPoint - fPoint + 1;
int[] mass = new int[size];
for (int i = 0; i < size; i++)
{
    mass[i] = fPoint + i;
}

for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] % 2 == 0)
    {
        Console.WriteLine(mass[i]);
    }
}
*/


//______/Task8/_______//
/*Console.WriteLine("Enter your number");
int number = int.Parse(Console.ReadLine());

int temp = number;
int length = 0;
while (temp > 0)
{
    length++;
    temp /= 10;
}

int[] digits = new int[length];


temp = number;
for (int i = digits.Length - 1; i >= 0 && temp > 0; i--)
{
    digits[i] = temp % 10;
    temp /= 10;
}
int result = 0;
for (int i = 0; i < digits.Length; i++)
{
    result += (int)Math.Pow(digits[i], digits.Length);
}
Console.WriteLine(result);
if (result == number)
{
    Console.WriteLine("Yay");
}
else
{
    Console.WriteLine("Nay");
}*/

//______/Task9/_______//
/*int number = 0;
Console.Write("Enter your number: ");
number = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 1; i <= number / 2; i++)
{
    if (number % i == 0)
    {
        sum += i;
    }
}

if (sum == number)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}*/