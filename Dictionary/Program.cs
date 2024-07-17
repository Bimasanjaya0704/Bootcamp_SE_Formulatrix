public class Program
{
    static void Main()
    {
        Dictionary<int, string> myDict = new();
        myDict.Add(1, "one");
        myDict.Add(2, "two");
        myDict.Add(3, "Three");

        bool cekKeys = myDict.ContainsKey(1);
        Console.WriteLine(cekKeys);

        bool cekValue = myDict.ContainsValue("four");
        Console.WriteLine(cekValue);

        string results;
        bool status = myDict.TryGetValue(3, out results);
        Console.WriteLine(status);
    }
}