using static System.Console;
class Program
{
    static void Main()
    {
        WriteLine("(1) {0} x {1:D3}[end]", 3, 24, 3 * 24);
        WriteLine("(2) {0:F}, {1:F10}[end]", 0.123456789, 0.123456789);
        WriteLine("(3) {0}, {1, 3}[end]", (char)97, (char)65);
        WriteLine("(4) {0}, {1, 10}, {2, -10}[end]", "string", "right", "left");
        WriteLine("(5) {0} x {1} + {2} = {3}", 10, 0b1010, 010, 0x6e);
    }
}