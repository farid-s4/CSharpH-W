#region Task1
/*interface ICalc
{
    int Less(int valueToCompare);
    int Greater(int valueToCompare);
}

class MyList : ICalc
{
    private int[] _array;
    private int _count;
    public MyList(int size)
    {
        _array = new int[size];
        _count = 0;
    }
    public void Add(int value)
    {
        if (_count < _array.Length)
        {
            _array[_count] = value;
            _count++;
        }
        else
        {
            throw new InvalidOperationException("List is full");
        }
    }
    public int Count => _count;
    public int this[int index]
    {
        get
        {
            if (index < 0 || index >= _count)
                throw new IndexOutOfRangeException();
            return _array[index];
        }
    }
    public int Less(int valueToCompare)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_array[i] > valueToCompare)
            {
                Console.WriteLine($"{_array[i]}, ");
            }
        }
        throw new NotImplementedException();
    }

    public int Greater(int valueToCompare)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_array[i] < valueToCompare)
            {
               Console.WriteLine($"{_array[i]}, ");
            }
        }
        throw new NotImplementedException();
    }
}
*/
#endregion

#region Task2

/*interface IOutput
{
    void ShowEven();
    void ShowOdd();
}
class MyList : IOutput
{
    private int[] _array;
    private int _count;
    public MyList(int size)
    {
        _array = new int[size];
        _count = 0;
    }
    public void Add(int value)
    {
        if (_count < _array.Length)
        {
            _array[_count] = value;
            _count++;
        }
        else
        {
            throw new InvalidOperationException("List is full");
        }
    }
    public int Count => _count;
    public int this[int index]
    {
        get
        {
            if (index < 0 || index >= _count)
                throw new IndexOutOfRangeException();
            return _array[index];
        }
    }

    public void ShowEven() {
        for (int i = 0; i < _count; i++)
        {
            if (_array[i] % 2 == 0)
            {
                Console.WriteLine($"{_array[i]}, ");
            }
        }
    }
    public void ShowOdd() { }

}*/
#endregion
#region Task3


/*interface ICalc
{
    int CountDistinctn();
    int EqualToValue(int valueToCompare);
}
class MyList : ICalc
{
    private int[] _array;
    private int _count;
    public MyList(int size)
    {
        _array = new int[size];
        _count = 0;
    }
    public void Add(int value)
    {
        if (_count < _array.Length)
        {
            _array[_count] = value;
            _count++;
        }
        else
        {
            throw new InvalidOperationException("List is full");
        }
    }
    public int Count => _count;
    public int this[int index]
    {
        get
        {
            if (index < 0 || index >= _count)
                throw new IndexOutOfRangeException();
            return _array[index];
        }
    }

    public int CountDistinctn()
    {
        int result = 0;
        int countUnique = 0;
        int count = 0;
        for (int i = 0; i < _count; i++)
        {
            countUnique++;
            for (int j = i + 1; j < _count; j++)
            {
                if (_array[i] == _array[j])
                {
                    count++;
                    break;
                }
            }
        }
        return result = countUnique - count;
    }
    public int EqualToValue(int valueToCompare) {
        int count = 0;
        for (int i = 0; i < _count; i++)
        {
            if (_array[i] == valueToCompare)
            {
                count++;
                break;
            }
        }
        return count;
    }

}

class Programm
{
    
    static void Main(string[] args)
    {
        MyList list = new MyList(5);
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(3);
        list.Add(3);

        Console.WriteLine(list.CountDistinctn());
        Console.WriteLine(list.EqualToValue(1));
    }
    
}*/
#endregion

#region Task4

/*interface IRemoteControl
{
    void TurnOn();
    void TurnOff();
    bool SetChannel(int channel);
}



class Radio : IRemoteControl
{
    private int _channel;
    private string _channel_name;
    public Radio(int channel, string channel_name)
    {
        _channel = channel;
        _channel_name = channel_name;
    }

    public bool Enabled { get; set; }

    public void TurnOn()
    {
        Enabled = true;
    }
    public void TurnOff() {
        Enabled = false;
    }

    public bool SetChannel(int channel)
    {
        _channel = channel;
        return true;
    }


}

class Television : IRemoteControl
{
    private int _channel;
    private string _brand;
    public bool Enabled { get; set; }

    public Television(int channel, string brand)
    {
        _channel = channel;
        _brand = brand;
    }

    public void TurnOn()
    {
        Enabled = true;
    }

    public void TurnOff()
    {
        Enabled = false;
    }

    public bool SetChannel(int channel)
    {
        _channel = channel;
        return true;
    }
}


class Program
{
    static void Main(string[] args)
    {
        *//*Radio radio = new Radio(1, "first");

        radio.TurnOn();

        if (radio.Enabled)
        {
            Console.WriteLine("enabled");
        }

        radio.TurnOff();

        if (!radio.Enabled)
        {
            Console.WriteLine("disabled");
        }

        int choose = 0;
        Console.WriteLine("Set new channel");
        choose = int.TryParse(Console.ReadLine(), out choose) ? choose : 0;
        if (radio.SetChannel(choose))
        {
            Console.WriteLine("New channel choosed");
        }*//*
        Television tv = new Television(5, "Samsung");

        tv.TurnOn();

        if (tv.Enabled)
        {
            Console.WriteLine("TV is enabled.");
        }

        Console.WriteLine("set new channel:");
        int newChannel;
        if (int.TryParse(Console.ReadLine(), out newChannel))
        {
            if (tv.SetChannel(newChannel))
            {
                Console.WriteLine("channel updated.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }

        tv.TurnOff();

        if (!tv.Enabled)
        {
            Console.WriteLine("TV is disabled.");
        }

    }
}

*/

#endregion

using System.Text.RegularExpressions;

interface IValidator
{
    bool Validate(string password);
}

public class BankAccount : IValidator
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

    public bool Validate(string password)
    {
        if (string.IsNullOrEmpty(password) || password.Length < 8)
            return false;

        bool hasUpper = false;
        bool hasDigit = false;
        bool hasSpecial = false;
        string specialChars = "!@#$%^&*";

        foreach (char c in password)
        {
            if (char.IsUpper(c))
                hasUpper = true;

            if (char.IsDigit(c))
                hasDigit = true;

            for (int i = 0; i < specialChars.Length; i++)
            {
                if (c == specialChars[i])
                {
                    hasSpecial = true;
                    break;
                }
            }

            if (hasUpper && hasDigit && hasSpecial)
                break;
        }

        return hasUpper && hasDigit && hasSpecial;
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();

        Console.Write("Enter your email: ");
        string email = Console.ReadLine();
        account.MyEmail = email;

        Console.Write("Create a password: ");
        string password = Console.ReadLine();

        if (account.Validate(password))
        {
            account.MyPassword = password;
            Console.WriteLine("Password is valid. Account created successfully.");
        }
        else
        {
            Console.WriteLine("Invalid password. Account not created.");
            return;
        }


    }
}