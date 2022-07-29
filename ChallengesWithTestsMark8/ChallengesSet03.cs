using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            return numbers != null ? numbers.Where(x => x % 2 != 0).Sum() % 2 != 0 ? true : false : false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(ch => char.IsUpper(ch) && 
                password.Any(ch => char.IsLower(ch) && 
                password.Any(ch => char.IsDigit(ch)))))

            {
                return true;

            }
                        
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return dividend == 0 || divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            //var oddsList = new List<int>();
            //int[] myArray = new int[50];
            //int index = 0;
              
            //  for (int i = 0; i < 100; i++)
            //  {
            //    if (i % 2 != 0)
            //     {
            //       myArray[index] = 1;
            //       index++;
            //     }
            //  }


            //for (int i = 1; i < 100; i += 2)
            //{
            //    oddsList.Add(i);
            //}
            //return oddsList.ToArray();

            return Enumerable.Range(1, 100).Where(x => x % 2 != 0).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
