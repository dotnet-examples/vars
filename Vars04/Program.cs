// string is an array of chars.
// for better performance,
// string is a struct containing 2 fields:
// * int _stringLength (for fast reading the length of the string)
// * char _firstChar (the first element of the array of chars)
// string is readonly, which means it can not be changed.
// you can only create a new string.

namespace Vars04;

class Program
{
    static void Main(string[] args)
    {
        string name = "dacheng";
        Console.WriteLine(name);

        name = name.ToUpper(); // name is pointed to a new string
        Console.WriteLine(name);
    }
}