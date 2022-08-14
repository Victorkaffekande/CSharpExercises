
namespace ClassLibrary1;

public interface IService
{
    /// <summary>
    /// Return the element of some index
    /// </summary>
    /// <param name="data"></param>
    /// <param name="index"></param>
    /// <returns></returns>
    public Object FindElement(IEnumerable<Object> data, int index);

    /// <summary>
    /// String comparison. Return true of characters are the same.
    /// </summary>
    /// <param name="str1"></param>
    /// <param name="str2"></param>
    /// <returns></returns>
    public bool AreTheseStringsEqual(string str1, string str2);

    /// <summary>
    /// Find the nths factorial (n!) = (n * (n - 1) * ...) until n is 1
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Factorial(int n);

    /// <summary>
    /// Find the nths fibonacci number. See: https://www.cuemath.com/algebra/fibonacci-numbers/
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int Fibonacci(int n);

    /// <summary>
    /// Return list of numbers greater than some value from data
    /// </summary>
    /// <param name="data"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public IEnumerable<int> FindValuesGreaterThan(IEnumerable<int> data, int value);

    /// <summary>
    /// Average is sum divided by number of numbers
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public double FindAverage(IEnumerable<int> data);

    /// <summary>
    /// Create a new string where swapA and swapB are switched
    /// </summary>
    /// <param name="testString"></param>
    /// <param name="swapA"></param>
    /// <param name="swapB"></param>
    /// <returns></returns>
    public string SwapCharacters(string testString, char swapA, char swapB);

    /// <summary>
    /// If the string only contains numbers, parse it as an int
    /// </summary>
    /// <param name="testString"></param>
    /// <returns></returns>
    public int ConvertStringToIntIfValidIntegerValue(string testString);
    
    /// <summary>
    /// Make properties with getters and setters. Not to be confuesed with fields. 
    /// </summary>
    /// <returns></returns>
    public object CreateObjectWithPropretyWhichHasAccessors();

    /// <summary>
    /// Return a list that has every number in data along with that number multiplied by itself
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public IEnumerable<object> CreateListWithObjectsContainingIntAndItsSquare(IEnumerable<int> data);

    /// <summary>
    /// A dictionary is a key-value data structure. The key should be the unique ints from data
    /// and the value should be the number of times they occur
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public Dictionary<int, int> CreateDictionrayWithIntsAndTheirFrequency(
        IEnumerable<int> data);
    
    public IEnumerable<int> CreateListOfHighestFiveNumbers(IEnumerable<int> data);

    /// <summary>
    /// Return true if the date inputted is earlier than today
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    public bool IsDateEarlierThanToday(DateTime date);

    /// <summary>
    /// Milliseconds (big int type) is simply number of milliseconds since January 1st 1970.
    /// Return the date that corresponds to the number of milliseconds passing since that date.
    /// </summary>
    /// <param name="milliseconds"></param>
    /// <returns></returns>
    public DateTime CreateDateFromNumberOfMillisecondsSinceUnixEpoch(Int64 milliseconds);
    public List<DateTime> CreateListOfLatestTwoDates(IEnumerable<DateTime> dates);

    /// <summary>
    /// Given two lists of strings, return a string of all the strings in both left and right
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public IEnumerable<string> PerformInMemoryInnerJoin(IEnumerable<string> left, IEnumerable<string> right);


    /// <summary>
    /// An evil number = Non negative number where the binary expansion has an even number of 1's
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public List<int> EvilNumbers(List<int> data);

    /// <summary>
    /// Return the numbers from data where the sums of its divisors(itself not included) are greater than itself.
    /// Example: 12 can be divided by 2, 3, 4 and 6. 1+2+3+4+6 = 16 > 12.
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public List<int> AbundantNumbers(IEnumerable<int> data);
}