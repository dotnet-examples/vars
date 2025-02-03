// char is used to store single character,
// it is 2-byte long, from \u0000 (\0) to \uffff.

namespace Vars03;

class Program
{
    static void Main(string[] args)
    {
        char ch = 'g';
        char ch2 = '高';
        char ch3 = '\u1234';

        Console.WriteLine(ch);
        Console.WriteLine(ch2);
        Console.WriteLine(ch3);
    }
}