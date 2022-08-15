namespace ClassLibrary1;

public class Service: IService
{
    public object FindElement(IEnumerable<object> data, int index)
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }

    public double FindAverage(IEnumerable<int> data)
    {
        throw new NotImplementedException();
    }

    public string SwapCharacters(string testString, char swapA, char swapB)
    {
        throw new NotImplementedException();
    }

    public int ConvertStringToIntIfValidIntegerValue(string testString)
    {
        throw new NotImplementedException();
    }

    public object CreateObjectWithPropretyWhichHasAccessors()
    {
        throw new NotImplementedException();
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