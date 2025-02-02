// decimal uses 16-byte to store more precisions (28 to 29).
// The internal fields of decimal are:
// * 4-byte for flags (1 bit for sign and 7 bits preserved, 1-byte for scale, and the next 2-byte preserved),
// * 4-byte for hi,
// * 8-byte for lo,

namespace Vars02;

class Program
{
    static void Main(string[] args)
    {
        decimal max = Decimal.MaxValue;
        Console.WriteLine(max);

        decimal a = 0x1234;
        Console.WriteLine(a);
        decimal a2 = -0x1234;
        Console.WriteLine(a2);

        decimal b = 0x1122334455667700;
        Console.WriteLine(b);

        decimal c = new decimal(0x11112222, 0x33334444, 0x55556666, false, 8);
        Console.WriteLine(c);

        // math
        decimal sum = a + a2;
        Console.WriteLine(sum);
    }
}