// See https://aka.ms/new-console-template for more information

    string input;
Console.WriteLine("E = Excellent");
Console.WriteLine("V = Very Good");
Console.WriteLine("G = Good");
Console.WriteLine("A = Average");
Console.WriteLine("F = Fail");
Console.WriteLine("Input the grade:");
input = Console.ReadLine();
if(input == "E")
{
    Console.WriteLine("Excellent");
}
else if(input == "V"||input =="v")
{
    Console.WriteLine("Very Good");
}
else if(input == "G"|| input=="g")
{
    Console.WriteLine("Good");
}
else if(input == "A"||input=="a")
{
    Console.WriteLine("Average");
}
else if(input == "F"||input=="f")
{
    Console.WriteLine("Fail");
}
else
{
    Console.WriteLine("Invalid input");
}
Console.ReadLine();
