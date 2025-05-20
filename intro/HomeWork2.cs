/*
Задание 1
Создайте приложение калькулятор для перевода числа из одной системы исчисления в другую. 
Пользователь с помощью меню выбирает направление перевода. Например, из десятичной в двоичную. 
После выбора направления, пользователь вводит число в исходной системе исчисления. 
Приложение должно перевести число в требуемую систему.
Предусмотреть случай выхода за границы диапазона, определяемого типом int, неправильный ввод.

Задание 2
Пользователь вводит словами цифру от 0 до 9.
Приложение должно перевести слово в цифру. 
Например, если пользователь ввёл five, приложение должно вывести на экран 5.

Задание 3
Создайте класс «Заграничный паспорт». 
Вам необходимо хранить информацию о номере паспорта, ФИО владельца, дате выдачи и т.д. 
Предусмотреть механизмы для инициализации полей класса. 
Если значение для инициализации неверное, генерируйте исключение.

Задание 4
Пользователь вводит в строку с клавиатуры логическое выражение. 
Например, 3>2 или 7<3. Программа должна посчитать результат введенного выражения и дать результат true или false.
В строке могут быть только целые числа и операторы: <, >, <=, >=, ==, !=.
Для обработки ошибок ввода используйте механизм исключений.

Задание 5
Создайте класс «Банковский аккаунт». 
Реализуйте методы для открытия счёта с определённым балансом, внесения и снятия средств. 
Добавьте проверку на недостаток средств при попытке снятия и выброс исключений при некорректных операциях.
*/



//task1

/*Console.WriteLine("Enter to number for translate: ");
int number = 0;
number = int.TryParse(Console.ReadLine(), out number) ? number : 0;
try
{
    checked
    {
        number = number + 1; 
    }
}
catch (OverflowException)
{
    Console.WriteLine("error int!");
}
int choose = 0;
Console.WriteLine("Enter to choose: 1. translate to 2 // 2. translate:  to 4  3. translate to 6 // 4. translate to 8:" );
choose = int.TryParse(Console.ReadLine(), out choose) ? choose : 0;

switch (choose)
{
    case 1:
    {
        string binary = Convert.ToString(number, 2);
        Console.WriteLine(binary);
        break;
    }
    case 2:
    {
        string binary = Convert.ToString(number, 4);
        Console.WriteLine(binary);
        break;
    }
    case 3:
    {
        string binary = Convert.ToString(number, 6);
        Console.WriteLine(binary);
        break;
    }
    case 4:
    {
        string binary = Convert.ToString(number, 8);
        Console.WriteLine(binary);
        break;
    }
    
}
*/

//task2
/*int number = 0;
Console.WriteLine("Enter to number for translate: ");
number = int.TryParse(Console.ReadLine(), out number) ? number : 0;
switch (number)
{
    case 1:
        {
            Console.WriteLine("one");
            break;
        }
    case 2:
        {
            Console.WriteLine("two");
            break;
        }
    case 3:
        {
            Console.WriteLine("three");
            break;
        }
    case 4:
        {
            Console.WriteLine("four");
            break;
        }
    case 5:
        {
            Console.WriteLine("five");
            break;
        }
    case 6:
        {
            Console.WriteLine("six");
            break;
        }
    case 7:
        {
            Console.WriteLine("seven");
            break;
        }
    case 8:
        {
            Console.WriteLine("eight");
            break;
        }
    case 9:
        {
            Console.WriteLine("nine");
            break;
        }
    case 10:
        {
            Console.WriteLine("ten");
            break;
        }
    default:
        {
            Console.WriteLine("error!");
            break;
        }
}
*/


//task3

/*public class MyPassport
{
    private string _id;
    private string _name;
    private string _surname;
    private DateTime _passportTime;

    public MyPassport(string name, string surname)
    {
        _name = name;
        _surname = surname;
        _passportTime = DateTime.Now;
        _id = Guid.NewGuid().ToString();
    }

    public string Name { get; set; }
    public DateTime PassportTime { get; set; }
    public string Id { get; }
    public string Surname { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_surname);
        Console.WriteLine(_passportTime);
    }
}

class HomeWork2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your surname: ");
        string surname = Console.ReadLine();
        MyPassport passport = new MyPassport(name, surname);
        passport.PrintInfo();
    }
}*/

//task4
/*using System.Text.RegularExpressions;
string expression;
int index = 0;
Console.WriteLine("Write expressions for comparison");
expression = Console.ReadLine();

int before = 0;
int after = 0;
try
{
    string[] parts = Regex.Split(expression, @"(<=|>=|==|!=|<|>)");

    before = int.TryParse(parts[0], out before) ? before : 0;
    after = int.TryParse(parts[2], out after) ? after : 0;

    if (expression.Contains("<"))
    {
        Console.WriteLine(before < after);
    }
    else if (expression.Contains(">"))
    {
        Console.WriteLine(before > after);
    }
    else if (expression.Contains("=="))
    {
        Console.WriteLine(before == after);
    }
    else if (expression.Contains("!="))
    {
        Console.WriteLine(before != after);
    }
    else if (expression.Contains("<="))
    {
        Console.WriteLine(before <= after);
    }
    else if (expression.Contains(">="))
    {
        Console.WriteLine(before >= after);
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
*/



//task5//

using System.Text.RegularExpressions;

public class BankAccount
{
    private string _email;
    private string _password;
    private decimal _balance;

    public BankAccount()
    {
        _email = string.Empty;
        _password = string.Empty;
        _balance = 0;
    }

    public string MyEmail { get; set; }
    public string MyPassword { get; set; }
    public decimal MyBalance { get; set; }

    public bool Withdrawal(decimal value)
    {
        
        if (value > 0 && MyBalance >= value)
        {
            MyBalance -= value;
            return true;
        }
        return false;
    }
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            MyBalance += amount;
        }
    }
}

class HomeWork2
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();
        while (true) {

            int choose = 0;

            Console.WriteLine("Choose what you want to do: ");
            Console.WriteLine("1. Create acc");
            Console.WriteLine("2. Deposite");
            Console.WriteLine("3. Withdrawal");
            Console.WriteLine("4. Exit");
            choose = int.TryParse(Console.ReadLine(), out choose) ? choose : 0;
            
            switch (choose)
            {
                case 1:
                    {
                        string input;
                       
                        Console.WriteLine("Write email for you bank account: ");

                        input = Console.ReadLine();


                        if (Regex.IsMatch(input, @"\w+@\w+\.\w+"))
                        {
                            Console.WriteLine("Email correct");
                            account.MyEmail = input;
                        }
                        else
                        {
                            Console.WriteLine("Try again");
                            break;
                        }

                        Console.WriteLine("Write you password: ");
                        input = Console.ReadLine();
                        account.MyPassword = input;
                        break;
                    }
                case 2: {
                        decimal input;
                        Console.WriteLine("Write new deposite: ");
                        input = decimal.TryParse(Console.ReadLine(), out input) ? input : 0;

                        account.Deposit(input);
                        Console.WriteLine(account.MyBalance);
                        break;
                    }
                case 3:
                    {
                        decimal input;
                        Console.WriteLine("How much money do you want withdrawal ?: ");
                        input = decimal.TryParse(Console.ReadLine(),out input) ? input : 0;
                        if (account.Withdrawal(input))
                        {
                            Console.WriteLine("Correct operation.\n You balance: ");
                            Console.WriteLine(account.MyBalance);
                        }
                        else
                        {
                            Console.WriteLine("Invaid operation");
                        }
                        break ;
                    }
                case 4:
                    {
                        return;
                    }
            }
        }
        

    }
}