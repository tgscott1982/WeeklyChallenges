using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            startNumber += 1;
            while (startNumber % n != 0)
            {
                startNumber++;
            }
            return startNumber;

           //return ((startNumber / n) + 1) * n;

        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var biz in businesses)
            {
                if (biz.TotalRevenue == 0)
                {
                    biz.Name = "CLOSED";
                }
            }

            //for (int i = 0; i < businesses.Length; i++)
            //{
            //    if (businesses[i].TotalRevenue == 0)
            //    {
            //        businesses[i].Name = "CLOSED";
            //    }
            //}
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var sum = 0;
            if (numbers == null)
            {
                return sum;
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
            }
            return sum;

            //if (numbers == null || numbers.Length == 0)
            //{
            //    return 0;
            //}

            //int sum = 0;

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i - 1] % 2 == 0)
            //    {
            //        sum += numbers[i];
            //    }
            //}

            //return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }
            var r = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != "" && words[i] != " ")
                {
                    r += words[i].Trim();
                    if (i < words.Length - 1)
                    {
                        if (r[r.Length - 1] != ' ')
                        {
                            r += " ";
                        }
                    }
                    else
                    {
                        r += ".";
                    }
                }
            }
            return r;

            //if (words == null || words.Length == 0)
            //{
            //    return "";
            //}

            //string sentence = "";

            //foreach (string word in words)
            //{
            //    if (word.Trim().Length > 0)
            //    {
            //        sentence += word.Trim() + " ";
            //    }
            //}

            //if (sentence.Length == 0)
            //{
            //    return "";
            //}

            //sentence = sentence.Substring(0, sentence.Length - 1);
            //sentence += ".";
            //return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var rList = new List<double>();
            if (elements == null)
            {
                return rList.ToArray();
            }
            for (int i = 3; i < elements.Count; i += 4)
            {
                rList.Add(elements[i]);
            }
            return rList.ToArray();

            //if (elements == null || elements.Count == 0)
            //{
            //    return new double[0];
            //}

            //List<double> everyFourth = new List<double>();

            //for (int i = 3; i < elements.Count; i += 4)
            //{
            //    everyFourth.Add(elements[i]);
            //}

            //return everyFourth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int u = i + 1; u < nums.Length; u++)
                {
                    if (nums[i] + nums[u] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
