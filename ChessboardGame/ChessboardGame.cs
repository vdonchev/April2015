using System;

class ChessboardGame
{
    static void Main()
    {
        int matrixSize = int.Parse(Console.ReadLine());
        string inputString = Console.ReadLine();

        int blackTeam = 0;
        int whiteTeam = 0;

        for (int i = 0; i < matrixSize * matrixSize; i++)
        {
            if (i < inputString.Length)
            {
                if (char.IsLetterOrDigit(inputString[i]))
                {
                    if (i % 2 == 0)
                    {
                        // black team   
                        if (char.IsUpper(inputString[i]))
                        {
                            whiteTeam += inputString[i];
                        }
                        else
                        {
                            blackTeam += inputString[i];
                        }
                    }
                    else
                    {
                        // white team
                        if (char.IsUpper(inputString[i]))
                        {
                            blackTeam += inputString[i];
                        }
                        else
                        {
                            whiteTeam += inputString[i];
                        }
                    }
                }
            }
        }

        if (whiteTeam != blackTeam)
        {
            string winner = (whiteTeam > blackTeam) ? "white team" : "black team";
            Console.WriteLine("The winner is: {0}", winner);
            Console.WriteLine(Math.Abs(whiteTeam - blackTeam));
        }
        else
        {
            Console.WriteLine("Equal result: {0}", whiteTeam);
        }
    }
}