// int saleAmount = 1001;
// // int discount = saleAmount > 1000 ? 100 : 50;

// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

// COIN FLIP EXERCISE

// Random coin = new Random();
// int flip = coin.Next(0, 2);
// Console.WriteLine((flip == 0) ? "heads" : "tails");

// ADMIN USER CLEARANCE EXERCISE

// string permission = "Admin|Manager";
// int level = 56;

// if (permission.Contains("Admin"))
// {
//     if (level > 55)
//     {
//       Console.WriteLine("Welcome, Super Admin user.");
//     }
//     else
//     {
//       Console.WriteLine("Welcome, Admin user.");
//     }
// }
// else if (permission.Contains("Manager"))
// {
//     if (level >= 20)
//     {
//       Console.WriteLine("Contact an Admin for access.");
//     }
//     else
//     {
//       Console.WriteLine("You do not have sufficient privileges.");
//     }
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }


// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int   : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long  : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte    : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort  : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint  : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");


// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float   : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double  : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");


// int[] data;
// data = new int[3];


// SayHello();

// void SayHello()
// {
//   Console.WriteLine("Hello World!");
// }


// int[] a = {1,2,3,4,5};

// Console.WriteLine("Contents of Array:");
// PrintArray();

// void PrintArray()
// {
//     foreach (int x in a)
//     {
//         Console.Write($"{x} ");
//     }
//     Console.WriteLine();
// }


// Console.WriteLine("Before calling a method");
// SayHello();
// Console.WriteLine("After calling a method");

// void SayHello()
// {
//     Console.WriteLine("Hello World!");
// }


// void ShowData(string a, int b, int c);
// void DisplayDate(string month, int day, int year);


void DisplayRandomNumbers()
{
    Random random = new Random();

    for (int i = 0; i < 5; i++)
    {
        Console.Write($"{random.Next(1, 100)} ");
    }

    Console.WriteLine();
}
