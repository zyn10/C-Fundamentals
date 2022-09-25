using System;
using System.Text;

namespace stringy
{
    class striw
    {
    public static void Main(string[] args)
    {
       
        string str1 = "Haider";
        string str2 = "abad";
        StringBuilder sb = new StringBuilder();
        sb.Append(str1);

        sb.Append(str2);

        Console.WriteLine(sb);
    }
}
}
