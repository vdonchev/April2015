using System;

public class KingOfThieves
{
    public static void Main()
    {
        int gemSize = int.Parse(Console.ReadLine());
        char gemChar = char.Parse(Console.ReadLine());

        int gemInner = 1;
        int gemOutter = gemSize / 2;

        for (int i = 0; i <= gemSize / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', gemOutter), new string(gemChar, gemInner));
            gemInner += 2;
            gemOutter--;
        }

        gemInner = gemSize - 2;
        gemOutter = 1;

        for (int i = 0; i < gemSize / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', gemOutter), new string(gemChar, gemInner));
            gemInner -= 2;
            gemOutter++;
        }
    }
}