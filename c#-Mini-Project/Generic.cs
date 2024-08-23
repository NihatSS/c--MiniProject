using System;

namespace c__Mini_Project;

internal class Generic<T>
{
    T[] _datas;
    int _count;
    public int capacity { get; set; }
    public int count => _count; 


    public Generic(int cap = 5)
    {
        capacity = cap;
        _datas = new T[cap];
        _count = 0;
    }


    public void Add(T value)
    {
        if (_datas.Length == _count)
        {
            Resize();
        }
        _datas[_count++] = value;

    }
    private void Resize()
    {
        Array.Resize(ref _datas, _datas.Length + capacity);
    }



    public void AddRange(params T[] values)
    {
        foreach (var value in values)
        {
            Add(value);
        }
    }




    public bool Contains(T value)
    {
        foreach (var data in _datas)
        {
            if (data.Equals(value))
            {
                return true;
            }
        }
        return false;
    }





    public void Remove(T value)
    {
        List<T> list = new List<T>();
        for (int i = 0; i < count; i++)
        {
            if (!_datas[i].Equals(value))
            {
                list.Add(value);
            }
        }
        _datas = list.ToArray();
    }




    public void RemoveAt(int index)
    {
        List<T> list = new List<T>();
        for (int i = 0; i < index; i++)
        {
            list.Add(_datas[i]);
        }
        for (int i = index+1; i < count; i++)
        {
            list.Add(_datas[i]);
        }
        
        Console.WriteLine($"Deleted value: {_datas[index]}");
        _datas = list.ToArray();
    }





    public int IndexOf(T value)
    {
        for (int i = 0; i < count; i++)
        {
            if (_datas[i].Equals(value))
            {
                return i;  
            }
        }
        return -1;
    }

    public int LastIndexOf(T value)
    {
        for (int i = count-1; i > 0; i--)
        {
            if (_datas[i].Equals(value))
            {
                return i;
            }
        }
        return -1;
    }


    public void Reverse()
    {
        List<T> list = new List<T>();
        for (int i = count-1; i >= 0; i--)
        {
            list.Add(_datas[i]);
        }
        _datas = list.ToArray();
    }

    public void Insert(int index, T value)
    {
        List<T> values = new List<T>();
        for (int i = 0; i < index; i++)
        {
            values.Add(_datas[i]);
        }
        var item = _datas[index];
        values.Add(value);
        values.Add(item);
        for (int i = index+1; i <= count-1; i++)
        {
            values.Add(_datas[i]);
        }
        _datas = values.ToArray();
        
    }


    public T this[int index]
    {
        get
        {
            if (index >= count)
            {
                throw new Exception();
            }
            return _datas[index];
        }
        set
        {
            if (index >= count)
            {
                throw new Exception();
            }
            _datas[index] = value;
        }
    }

    public override string ToString()
    {
        string result = string.Empty;
        for (int i = 0; i < count; i++)
        {
            result += _datas[i].ToString() + " ";
        }
        return result;
    }
}
