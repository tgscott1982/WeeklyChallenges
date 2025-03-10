﻿using System;

namespace ChallengesWithTestsMark8  //adding comment to test new laptop
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2) //could also do a ternary
                                                             // if (num1 == num2 ? true : false)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Add(int number1, int number2)
        {
           return number1 + number2;
        }

        public int GetSmallestNumber(int number1, int number2) //ternary option
                                                               // if (number 1 < number2 ? number1 : number2;
        {
            if (number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson) // also case for ternary
        {
            if (nameOfPerson == "")
            {
                return "Hello!";
            }
            else
            {
                return $"Hello, {nameOfPerson}!";
            }
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
