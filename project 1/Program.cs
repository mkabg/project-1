using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Program

    {
       
        static bool checkArgs(string[] args)
        {
            if (getNumberOfElements(args) >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void requierdInput()
        {
            print("please enter 3 positive numbers");
        }
        static void print(string message)
        {
            Console.WriteLine(message);
        }

        static void getSeries(int[] input)
        {
            print("the series you entered is " + input);
        }

        static string[] splitInput(string input)
        {
            return input.Split(' ');
        }
        static string getUserInput()
        {
            string userInput = Console.ReadLine();
            return userInput;
        }

        static bool isValidate(string[] input)
        {
            if (getNumberOfElements(input) < 3)
            {
                print("the number of element you enter is less than three");
                //requierdInput();
                return false;
            }
            foreach (string ch in input)
            {
                if (!int.TryParse(ch, out int result))
                {
                    print("the string " + ch + " is not an integer.");
                    //requierdInput();
                    return false;
                }
            }
            return true;
        }

        static void showMenue()
        {
            print("Choose one of the options\n" +
                "press 1 to Input a Series. (Replace the current series)\n" +
                "press 2 to Display the series in the order it was entered.\n" +
                "press 3 to Display the series in the reversed order it was\r\nentered.\n" +
                "press 4 to Display the series in sorted order (from low to\r\nhigh).\n" +
                "press 5 to Display the Max value of the series.\n" +
                "press 6 to Display the Min value of the series.\n" +
                "press 7 to Display the Average of the series.\n" +
                "press 8 to Display the Number of elements in the series.\n" +
                "press 9 to Display the Sum of the series.\n" +
                "press 10 to Exit.");
        }

        static List <int> convertToInt(string[] input)
        {
            List<int> converted = new List<int>();
            foreach (string ch in input)
            {
                converted.Add(int.Parse(ch));
            }
            return converted;
        }

        static List <int> reverseTheSeries(int[] input)
        {
            List<int> reversed = new List<int>();
            for (int i = input.Length; i <= 0; i--)
            {
                reversed.Add(input[i]);
            }
            return reversed;
        }

        static int[] getSortedList(int[] input)
        {
            List<int> sorted = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i] > input[j])
                    {
                        int temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input;
        }

        static int getMax(int[] input)
        {
            int max = 0;
            foreach (int ch in input)
            {
                if (ch > max)
                {
                    max = ch;
                }
            }
            return max;
        }

        static int getMin(int[] input)
        {
            int min = getMax(input);
            foreach (int ch in input)
            {
                if (ch < min)
                {
                    min = ch;
                }
            }
            return min;
        }

        static int getAverage(int[] input)
        {
            int sum = getSum(input);
            int counter = 0;
            foreach (int ch in input)
            {
                sum += ch;
                counter++;
            }
            return sum / counter;
        }

        static void chosenMenue(int input)
        {
            switch(input)
            {
                case 1:
                    

                    
            }
            
        }
        

        static int getNumberOfElements(string[] input)
        {
            int counter = 0;
            foreach (string ch in input)
            {
                counter++;
            }
            return counter;
        }

        static int getSum(int[] input)
        {
            int sum = 0;
            foreach (int ch in input)
            {
                sum += ch;
            }
            return sum;
        }

        static bool checkIfArgs(string[] startInput);

        static bool isValidCoice(string input)
        {
            if (int.TryParse(input, out int result))
            {
                if (result >= 1 && result <= 10)
                {
                    return true;
                }
                else
                {
                    print("the number you entered is not in the range of 1 to 10");
                    return false;
                }
            }
            else
            {
                print("the string you entered is not an integer");
                return false;
            }
        }

        static void Main(string[] args)
        {
            string[] listUserInput = { };
            bool isValidInput = false;
            while (!isValidInput)
            {
                requierdInput();
                string userInput = getUserInput();
                listUserInput = splitInput(userInput);
                isValidInput = isValidate(listUserInput);
            }
            List<int> convertedList = convertToInt(listUserInput);

            string userChoice = "";
            bool validChoice = false;
            while (!validChoice)
            {
                showMenue();
                userChoice = getUserInput();
                validChoice = isValidCoice(userChoice);
            }
            int choice = int.Parse(userChoice);

        }
    }
}
