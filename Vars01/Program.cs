// integers in different size:
// 1-byte: sbyte, byte
// 2-byte: short, ushort
// 4-byte: int, uint
// 8-byte: long, ulong

namespace Vars01;

class Program
{
    static void Main(string[] args)
    {
        sbyte b1 = SByte.MaxValue;
        byte b2 = Byte.MaxValue;

        Console.WriteLine("signed byte and unsigned byte:");
        Console.Write(b1);
        Console.Write(',');
        Console.WriteLine(b2);

        short short1 = Int16.MaxValue;
        ushort short2 = UInt16.MaxValue;

        Console.WriteLine("signed short and unsigned short:");
        Console.Write(short1);
        Console.Write(',');
        Console.WriteLine(short2);

        int int1 = Int32.MaxValue;
        uint int2 = UInt32.MaxValue;

        Console.WriteLine("signed int and unsigned int:");
        Console.Write(int1);
        Console.Write(',');
        Console.WriteLine(int2);

        long long1 = Int64.MaxValue;
        ulong long2 = UInt64.MaxValue;

        Console.WriteLine("signed long and unsigned long:");
        Console.Write(long1);
        Console.Write(',');
        Console.WriteLine(long2);
    }
}