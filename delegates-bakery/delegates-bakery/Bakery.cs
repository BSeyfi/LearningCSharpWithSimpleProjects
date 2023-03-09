//by Behzad Seyfi github.com/BSeyfi
namespace BakeryNamespace;

public delegate string Bakery(double floor, double water);

public class BreadBaking
{
    public static string Lavaashi(double floor, double water)
    {
        return $"{(int) Math.Min(floor * 4, water * 2)} Lavaash bread";
    }


    public static string Sangaki(double floor, double water)
    {
        return $"{(int) Math.Min(floor * 2, water * 1)} Sangak bread";
    }
}