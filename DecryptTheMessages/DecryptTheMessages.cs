using System;

class DecryptTheMessages
{
    static void Main()
    {
        string command = Console.ReadLine();

        while (command.ToLower() != "start")
        {
            command = Console.ReadLine();
        }

        command = Console.ReadLine();

        string messages = string.Empty;
        int totalMessages = 0;

        while (command.ToLower() != "end")
        {
            if (command.Length > 0)
            {
                for (int i = command.Length - 1; i >= 0; i--)
                {
                    if ((command[i] >= 'A' && command[i] <= 'M') || (command[i] >= 'a' && command[i] <= 'm'))
                    {
                        messages += (char)(command[i] + 13);
                    }
                    else if ((command[i] >= 'N' && command[i] <= 'Z') || (command[i] >= 'n' && command[i] <= 'z'))
                    {
                        messages += (char)(command[i] - 13); 
                    }
                    else if (command[i] >= '0' && command[i] <= '9')
                    {
                        messages += command[i];
                    }
                    else
                    {
                        switch (command[i])
                        {
                            case '+':
                                messages += ' ';
                                break;
                            case '%':
                                messages += ',';
                                break;
                            case '&':
                                messages += '.';
                                break;
                            case '#':
                                messages += '?';
                                break;
                            case '$':
                                messages += '!';
                                break;
                        }
                    }
                }

                messages += Environment.NewLine;
                totalMessages++;
            }

            command = Console.ReadLine();
        }

        if (totalMessages == 0)
        {
            Console.WriteLine("No message received.");
        }
        else
        {
            Console.WriteLine("Total number of messages: {0}", totalMessages);
            Console.WriteLine(messages);
        }
    }
}