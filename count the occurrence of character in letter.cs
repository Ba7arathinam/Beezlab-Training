using System;
public class Demo
{
    public static void Main()
    {
        string str = "balarathinam";
           str = str.ToUpper();
        Console.WriteLine("String: " + str);
        var duplicate = new HashSet<char>(str);
        
        foreach (char st in duplicate) { 
        Console.Write(st);
            
        }

        while (str.Length > 0)
        {
            Console.WriteLine();
            Console.Write(str[0] + " = ");
            int count = 0;
            for (int j = 0; j < str.Length; j++)
            {
                if (str[0] == str[j])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            str = str.Replace(str[0].ToString(), string.Empty);
        }
        Console.ReadLine();
    }
}