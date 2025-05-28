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


interface ICalc
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
            for (int j = i+1; j < _count; j++)
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
        MyList list = new MyList(4);
        list.Add(1);
        list.Add(2);
        list.Add(4);
        list.Add(4);


        Console.WriteLine(list.CountDistinctn());
        Console.WriteLine(list.EqualToValue(3));
    }
    
}
#endregion