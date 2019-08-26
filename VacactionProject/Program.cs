using System;
using System.Collections.Generic;

namespace VacactionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var testString = "aabbccddeeffggaa";
            Console.WriteLine(RemoveDuplicates2(testString));
            Console.WriteLine(ReverseASenctence("Hello, my dudes"));

            var testArr = new int[] { 1, 2, 3, 4, 5};

            FindTheArraySection(testArr, 3);

            Console.ReadLine();
        }



        static public HashSet<char> RemoveDuplicates(dynamic input)
        {
            var myString = Convert.ToString(input);


            var mySet = new HashSet<char>();

            foreach (var character in myString)
            {
                mySet.Add(character);
            }
            return mySet;

            //String.IndexOf(char) != String.LastIndexOf(char)
            //this is a fun way to check if only one element of this type exists in a grouping
        }

        static public string RemoveDuplicates2(string input)
        {
            string answer = "";
            HashSet<char> SeenSet = new HashSet<char>();
            for (var i = 0; i < input.Length; i++)
            {
                if (input.LastIndexOf(input[i]) == input.IndexOf(input[i]))
                {
                    answer = String.Format(answer + input[i]);
                }
                else if (!SeenSet.Contains(input[i]))
                {
                    answer = String.Format(answer + input[i]);
                    SeenSet.Add(input[i]);
                }
            }
            return answer;
        }
        static public List<string> RemoveDuplicates3(string[] inputarr)
        {
            var answer = new List<string>();
            var myString = "";


            for (var i = 0; i < inputarr.Length; i++)
            {
                var letter = inputarr[i];
                bool seen = false;

                for (var j = i + 1; j < inputarr.Length; j++)
                {
                    if (inputarr[j] == letter)
                    {
                        seen = true;
                    }
                }
                while (seen == false)
                {
                    answer.Add(letter);
                    seen = false;
                }
            }
            return answer;
        }

        static public string ReverseASenctence(string input)
        {
            var splitInput = input.Split(" ");

            string answer = "";

            for (var i = splitInput.Length - 1; i >= 0; i--)
            {
                if (i != 0)
                {
                    answer += splitInput[i] + " ";
                }
                else
                {
                    answer += splitInput[i];
                }
            }

            return answer;
        }


        //Question 3
        /* Question 3:Inside an array, find a partial array that has a specific sum, write a function
         * that takes an array andan integer (the sum), and returns two indexes representing the start
         * and the end of the partial array that has this sum.
         * 
         * Examples :Input: arr[] = {1, 4, 20, 3, 10, 5}, 
         * sum = 33
         * Ouptut: Sum found between indexes 2 and 4
         * 
         * Input: arr[] = {1, 4, 0, 0, 3, 10, 5}, 
         * sum = 7Ouptut: 
         * Sum found between indexes 1 and 4Input:
         * 
         * arr[] = {1, 4}, 
         * sum = 0Output: 
         * No subarray found */

        public static void FindTheArraySection(int[] inputArr, int sum)
        {
            var counter = 0;
            bool sumFound = false;
            bool endReached = false;

            while (sumFound == false && endReached == false)
            {
                var loopIteration = 0;

                for (var i = loopIteration; i < inputArr.Length; i++)
                {
                    counter += inputArr[i];

                    if (counter == sum)
                    {
                        var index1 = loopIteration;
                        var index2 = i;
                        sumFound = true;
                        Console.WriteLine("Answer found for sum {0} between the indices of {1} and {2}", sum, index1, index2);
                        break;
                    }
                    else if(loopIteration == inputArr.Length - 1)
                    {
                        
                        
                        endReached = true;
                    }
                    else if (counter > sum)
                    {
                        counter = 0;
                        loopIteration += 1;
                        continue;
                    }

                }
            }
        }
    }
}
