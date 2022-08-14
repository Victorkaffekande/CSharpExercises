
using System.Runtime.InteropServices;
using Xunit;

namespace ClassLibrary1;

public class ServiceTests
{
    private IService _service;

    
    public ServiceTests()
    {
        //swap comment to other line if you wanna run the example solutions
        //_service = new ServiceExampleSolutions();
        _service = new Service();
    }

    [Theory]
    [InlineData(new object[] { 1, 2, 6 }, 2, 6)]
    public void FindElement(IEnumerable<object> data, int index, int expected)
    {
        var result = _service.FindElement(data, index);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("aba", "aba", true)]
    [InlineData("aba", "bab", false)]
    public void AreTheseStringsEqual(string str1, string str2, bool expected)
    {
        var result = _service.AreTheseStringsEqual(str1, str2);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 1)]
    [InlineData(8, 40320)]
    public void Factorial(int input, int exp)
    {
        var res = _service.Factorial(input);
        Assert.Equal(exp, res);
    }
    
    [Theory]
    [InlineData(2, 1)]
    [InlineData(9, 34)]
    public void Fibonacci(int input, int exp)
    {
        var res = _service.Fibonacci(input);
        Assert.Equal(exp, res);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 5, new int[] { 6, 7 })]
    public void FindGreaterThan(IEnumerable<int> data, int value, IEnumerable<int> expected)
    {
        var result = _service.FindValuesGreaterThan(data, value);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 2)]
    [InlineData(new int[] { -12, 0, 12 }, 0)]
    public void FindAverage(IEnumerable<int> data, double expected)
    {
        var result = _service.FindAverage(data);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("aba", 'a', 'b', "bab")]
    [InlineData("SDP & C# Is Awesome", 'w', 'e', "SDP & C# Is Aewsomw")]
    public void SwapCharacters(string testString, char swapA, char swapB, string expected)
    {
        var result = _service.SwapCharacters(testString, swapA, swapB);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1", 1)]
    public void ParseInt(string intString, int expected)
    {
        var result = _service.ConvertStringToIntIfValidIntegerValue(intString);
        Assert.Equal(result, expected);
    }

    [Theory]
    [InlineData("a")]
    public void ParseIntErr(string intString)
    {
        Assert.Throws<FormatException>(() => _service.ConvertStringToIntIfValidIntegerValue(intString));
    }

    [Fact]
    public void CreateObjectWithFieldAndProperty()
    {
        var obj = _service.CreateObjectWithPropretyWhichHasAccessors();
        var isTrue = obj.GetType().GetFields().Length > 0 && obj.GetType().GetProperties().Length > 0;
        Assert.True(isTrue);
    }

    [Theory]
    [InlineData(new int[] { -10, 0, 2 })]
    public void CreateObjectWithIntPropertyAndItsSquare(IEnumerable<int> data)
    {
        var arr = _service.CreateListWithObjectsContainingIntAndItsSquare(data);
        var isTrue = false;
        foreach (var obj in arr)
        {
            var prop0 = Convert.ToInt32(obj.GetType().GetProperties()[0].GetValue(obj, null));
            var prop1 = Convert.ToInt32(obj.GetType().GetProperties()[1].GetValue(obj, null));

            if (prop0 * prop0 == prop1 || prop1 * prop1 == prop0)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }
        }

        Assert.True(isTrue);
    }


    [Theory]
    [InlineData(new int[] {1,2,4,15,15})]
    public void CreateListWithObjectsContainingUniqueIntsAndTheirFrequency(IEnumerable<int> data)
    {
        var exp = new Dictionary<int, int>()
        {
            {1, 1},
            {2,1},
            {4,1},
            {15, 2}
        };
        var actual = _service.CreateDictionrayWithIntsAndTheirFrequency(data);
        Assert.Equal(exp, actual);
    }

    [Theory]
    [InlineData(new int[] { 1, 3, 6, 2, 7, 8, 3 }, new int[] {8,7,6,3,3})]
    public void CreateListOfHighestFiveNumbers(IEnumerable<int> data, IEnumerable<int> expected)
    {
        var actual = _service.CreateListOfHighestFiveNumbers(data);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CreateListOfLatestDates()
    {
        List<DateTime> dates = new List<DateTime>
            { new DateTime(2022,7,28,1,1,1), new DateTime(2023, 1, 1, 1, 1, 1), new DateTime(2021, 1, 1, 1, 1, 1) };
        List<DateTime> exp = new List<DateTime> { new DateTime(2023, 1, 1, 1, 1, 1), new DateTime(2022,7,28,1,1,1) };
        var actual = _service.CreateListOfLatestTwoDates(dates);
        Assert.Equal(exp, actual);
    }

    [Fact]
    public void IsDateEarlierThanToday()
    {
        var date = new DateTime(2021, 1, 1, 1, 1, 1);
        var actual = _service.IsDateEarlierThanToday(date);
        Assert.True(actual);
    }

    [Theory]
    [InlineData("43425345062", 1971, 05, 18)]
    public void CreateDateFromNumberOfMillisecondsSinceUnixEpoch(string millistring, int year, int month, int day)
    {
        var exp = new DateTime(year, month, day);
        Int64 l = Int64.Parse(millistring);
        var result = _service.CreateDateFromNumberOfMillisecondsSinceUnixEpoch(l);
        var compare = exp.CompareTo(result);
        Assert.Equal(0, compare);
    }

    [Theory]
    [InlineData(new string[] { "hello", "world", "sdp", "spam" }, new string[] { "hello", "sdp", "cs" }, new string[] {"hello", "sdp"})]
    public void PerformInMemoryInnerJoin(string[] left, string[] right, string[] expected)
    {
        var result = _service.PerformInMemoryInnerJoin(left, right);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[] {0,1,2,3,4,5,6,7}, new int[] {0,3,5,6})]
    public void Evils(IEnumerable<int> input, IEnumerable<int> expected)
    {
        List<int> data = new List<int>(input);
        var res = _service.EvilNumbers(data);
        Assert.Equal(expected, res);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 5, 6, 12, 24, 23 }, new int[] { 12, 24})]
    public void Abundants(IEnumerable<int> input, IEnumerable<int> expected)
    {
        var res = _service.AbundantNumbers(input);
        Assert.Equal(expected, res);
    }

    public static bool Validate<T>(T @this, params Func<T, bool>[] predicates) => predicates.All(x => x(@this));

    [Fact]
    public void Test()
    {
        
    }
}