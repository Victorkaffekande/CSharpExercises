using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ClassLibrary1;

public class Service : IService
{
    public object FindElement(IEnumerable<object> data, int index)
    {
        return data.ElementAt(index);
    }

    public bool AreTheseStringsEqual(string str1, string str2)
    {
        return str1 == str2;
    }

    public int Factorial(int n)
    {
        throw new NotImplementedException();
    }

    public int Fibonacci(int n)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<int> FindValuesGreaterThan(IEnumerable<int> data, int value)
    {
        List<int> list = new List<int>();
        foreach (var VARIABLE in data)
        {
            if (VARIABLE > value)
            {
                list.Add(VARIABLE);
            }
        }

        return list;
    }

    public double FindAverage(IEnumerable<int> data)
    {
        return data.Average();
    }
    public string SwapCharacters(string testString, char swapA, char swapB)
    {
        StringBuilder sb = new StringBuilder();
        foreach (var c in testString)
        {
            if (c == swapA)
            {
                sb.Append(swapB);
            }
            else if (c == swapB)
            {
                sb.Append(swapA);
            }
            else
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }

    public int ConvertStringToIntIfValidIntegerValue(string testString)
    {
        return int.Parse(testString);
    }

    private class MyClass
    {
        public int num;
        public int square;

        public int Square => square;

        public int Num
        {
            get => num;
            set => num = value;
        }
    }

    public object CreateObjectWithPropretyWhichHasAccessors()
    {
        return new MyClass();
    }

    public IEnumerable<object> CreateListWithObjectsContainingIntAndItsSquare(IEnumerable<int> data)
    {
        List<MyClass> list = new List<MyClass>();
        foreach (var i in data)
        {
            MyClass mc = new MyClass();
            mc.num = i;
            mc.square = i * i;
            list.Add(mc);
        }

        return list;
    }

    public Dictionary<int, int> CreateDictionrayWithIntsAndTheirFrequency(IEnumerable<int> data)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();

        foreach (var num in data)
        {
            var tmp = data.Select(x=>x);
            
            data.Count();
        }
        return dic;
    }

    public IEnumerable<int> CreateListOfHighestFiveNumbers(IEnumerable<int> data)
    {
        throw new NotImplementedException();
    }

    public bool IsDateEarlierThanToday(DateTime date)
    {
        throw new NotImplementedException();
    }

    public DateTime CreateDateFromNumberOfMillisecondsSinceUnixEpoch(long milliseconds)
    {
        throw new NotImplementedException();
    }

    public List<DateTime> CreateListOfLatestTwoDates(IEnumerable<DateTime> dates)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<string> PerformInMemoryInnerJoin(IEnumerable<string> left, IEnumerable<string> right)
    {
        throw new NotImplementedException();
    }

    public List<int> EvilNumbers(List<int> data)
    {
        throw new NotImplementedException();
    }

    public List<int> AbundantNumbers(IEnumerable<int> data)
    {
        throw new NotImplementedException();
    }
}