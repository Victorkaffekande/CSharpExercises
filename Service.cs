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
        throw new NotImplementedException();
    }

    public Dictionary<int, int> CreateDictionrayWithIntsAndTheirFrequency(IEnumerable<int> data)
    {
        throw new NotImplementedException();
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