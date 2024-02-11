namespace RomanNumeralsHelper;
using System;

public class NumLib
{
    public string Roman { get; set; }
    public int Arab { get; set; }
}

public class RomanHelper
{
    public const int Length = 7;
    public NumLib[] Num { get; } = new NumLib[Length]
    {
        new NumLib { Roman = "I", Arab = 1 },
        new NumLib { Roman = "V", Arab = 5 },
        new NumLib { Roman = "X", Arab = 10 },
        new NumLib { Roman = "L", Arab = 50 },
        new NumLib { Roman = "C", Arab = 100 },
        new NumLib { Roman = "D", Arab = 500 },
        new NumLib { Roman = "M", Arab = 1000 }
    };

    public string ToRoman(uint n)
    {
        if (n < 1 || n > 3999)
        {
            throw new ArgumentException("Input value must be between 1 and 3999");
        }

        string answer = "";
        int[] parts = new int[4];

        SplitNumber((int)n, parts);

        for (int c = 3; c >= 0; c--)
        {
            for (int i = Length - 1; i >= 0; i--)
            {
                if (parts[c] == Num[i].Arab)
                {
                    parts[c] -= Num[i].Arab;
                    answer += Num[i].Roman;
                }
                else if (i > 0 && parts[c] == Num[i].Arab - Num[i - 1].Arab)
                {
                    parts[c] -= Num[i].Arab - Num[i - 1].Arab;
                    answer += Num[i - 1].Roman + Num[i].Roman;
                }
                else if (parts[c] >= Num[i].Arab)
                {
                    parts[c] -= Num[i].Arab;
                    answer += Num[i].Roman;
                    i++;  // Перескакиваем через следующий элемент, так как мы уже обработали его
                }
            }
        }

        return answer;
    }

    public int FromRoman(string rn)
    {
        if (string.IsNullOrEmpty(rn))
        {
            throw new ArgumentException("Input string cannot be null or empty");
        }

        for (int n = 1; n <= 3999; n++)
        {
            string answer2 = ToRoman((uint)n);
            if (answer2 == rn)
            {
                return n;
            }
        }

        throw new ArgumentException("Unable to convert Roman numeral to Arabic numeral");
    }

    private void SplitNumber(int number, int[] parts)
    {
        int power = 1;
        for (int i = 0; i < 4; i++)
        {
            parts[i] = (number % 10) * power;
            number /= 10;
            power *= 10;
        }
    }
}

class Program
{
    static void Main() {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        //ApplicationConfiguration.Initialize();
        //Application.Run(new Form1());
        
        RomanHelper romanNumerals = new RomanHelper();
        string romanResult = romanNumerals.ToRoman(123);
        int arabResult = romanNumerals.FromRoman("CXXIII");

        Console.WriteLine($"Roman: {romanResult}");
        Console.WriteLine($"Arabic: {arabResult}");
    }    
}