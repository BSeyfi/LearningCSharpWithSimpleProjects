//by Behzad Seyfi github.com/BSeyfi
using BakeryNamespace;

double floor = 10;
double water = 5;
List<Bakery> bakeries = new() {BreadBaking.Lavaashi, BreadBaking.Sangaki};

Console.WriteLine($"\nWith {floor}kg floor and {water}kg water you can bake:\n");
for (var i = 0; i < bakeries.Count; i++)
{
    Console.WriteLine(bakeries[i](floor, water));
    if (i < bakeries.Count - 1)
        Console.WriteLine("OR");
}
