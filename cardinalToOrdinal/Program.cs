﻿using System;

namespace cardinalToOrdinal
{
    class Program
    {

        static string cardinalToOrdinal(int number)
        {
            switch (number)
            {
                case 11:
                case 12:
                case 13:
                    return $"{number}th";
                default:
                    string numberAsText = number.ToString();
                    char lastDigit = numberAsText[numberAsText.Length - 1];
                    string suffix = string.Empty;
                    switch (lastDigit)
                    {
                        case '1':
                            suffix = "st";
                            break;
                        case '2':
                            suffix = "nd";
                            break;
                        case '3':
                            suffix = "rd";
                            break;
                        default:
                            suffix = "th";
                            break;

                    }

                    return $"{number}{suffix}";
            }

            
        }




        static void Main(string[] args)
        {
            for(int i = 0; i <= 40; i++)
            {
                Console.WriteLine($"{cardinalToOrdinal(i)} ");
            }
        }
    }
}
