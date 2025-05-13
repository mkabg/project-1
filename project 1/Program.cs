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
       
        //static bool checkArgs(string[] args)
        //{
        //    if (getNumberOfElementsString(args) >= 3)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

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
            if (getNumberOfElementsString(input) < 3)
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

        static List <int> reverseTheSeries(List<int> input)
        {
            List<int> reversed = new List<int>();
            for (int i = getNumberOfElementsInt(input); i <= 0; i--)
            {
                reversed.Add(input[i]);
            }
            return reversed;
        }

        static List<int> getSortedList(List<int> input)
        {
            List<int> sorted = new List<int>();
            for (int i = 0; i < getNumberOfElementsInt(input); i++)
            {
                for (int j = 0; j < getNumberOfElementsInt(input); j++)
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

        static int getMax(List<int> input)
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

        static int getMin(List<int> input)
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

        static int getAverage(List<int> input)
        {
            int sum = getSum(input);
            int counter = getNumberOfElementsInt(input);
            foreach (int ch in input)
            {
                sum += ch;
                counter++;
            }
            return sum / counter;
        }

        static void choosingOption(int input, List<int> converted)
        {
            switch(input)
            {
                case 1:
                    requierdInput();
                    string userInput = getUserInput();
                    string[] listUserInput = splitInput(userInput);
                    if (isValidate(listUserInput))
                    {
                        List<int> convertedList = convertToInt(listUserInput);
                        print("the series you entered is " + convertedList);
                    }
                    break;

                case 2:
                    print("the series you entered is " + converted);
                    break;

                case 3:
                    List<int> reversedList = reverseTheSeries(converted);
                    print("the series you entered at reverse is " + reversedList);
                    break;

                case 4:
                    List<int> sortedList = getSortedList(converted);
                    print("the series you entered at sorted is " + sortedList);
                    break;

                case 5:
                    int max = getMax(converted);
                    print("the max value of the series is " + max);
                    break;

                case 6:
                    int min = getMin(converted);
                    print("the min value of the series is " + min);
                    break;

                case 7:
                    int average = getAverage(converted);
                    print("the average of the series is " + average);
                    break;

                case 8:
                    int numberOfElements = getNumberOfElementsInt(converted);
                    print("the number of elements in the series is " + numberOfElements);
                    break;

                case 9:
                    int sum = getSum(converted);
                    print("the sum of the series is " + sum);
                    break;

                case 10:
                    print("🙏🙏🙏 you for using the program 👋👋👋");
                    break;
            }
            
        }
        

        static int getNumberOfElementsString(string[] input)
        {
            int counter = 0;
            foreach (string ch in input)
            {
                counter++;
            }
            return counter;
        }

        static int getNumberOfElementsInt(List<int> input)
        {
            int counter = 0;
            foreach (int ch in input)
            {
                counter++;
            }
            return counter;
        }
        static int getSum(List<int> input)
        {
            int sum = 0;
            foreach (int ch in input)
            {
                sum += ch;
            }
            return sum;
        }

        //static bool checkIfArgs(string[] startInput);

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
            choosingOption(choice, convertedList);

        }
    }
}
