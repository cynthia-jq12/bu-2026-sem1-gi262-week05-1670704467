using UnityEngine;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture
        public int[] LCT01_SelectionSortAscending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            { 
                int minIndex = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                (numbers[i], numbers[minIndex]) = (numbers[minIndex], numbers[i]);
            }
            return numbers;
        }

        public int[] LCT02_BubbleSortAscending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                    }
                }
            }
            return numbers;
        }

        public int[] LCT03_InsertionSortAscending(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                int key = numbers[i];
                int j = i - 1;
                while (numbers[j] > key && j > 0)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;
            }
            return numbers;
        }

        #endregion

        #region Assignment

        public int[] AS01_SelectionSortDescending(int[] numbers)
        {
            for (int currentPosition = 0; currentPosition < numbers.Length - 1; currentPosition++)
            {
                int largestValueIndex = currentPosition;

                for (int searchIndex = currentPosition + 1; searchIndex < numbers.Length; searchIndex++)
                {
                    if (numbers[searchIndex] > numbers[largestValueIndex])
                    {
                        largestValueIndex = searchIndex;
                    }
                }

                int temporaryNumber = numbers[currentPosition];
                numbers[currentPosition] = numbers[largestValueIndex];
                numbers[largestValueIndex] = temporaryNumber;
            }

            return numbers;
        }

        public int[] AS02_BubbleSortDescending(int[] numbers)
        {
            int[] sortedNumbers = (int[])numbers.Clone();

            for (int pass = 0; pass < sortedNumbers.Length - 1; pass++)
            {
                for (int currentIndex = 0; currentIndex < sortedNumbers.Length - 1 - pass; currentIndex++)
                {
                    if (sortedNumbers[currentIndex] > sortedNumbers[currentIndex + 1])
                    {
                        int temporaryNumber = sortedNumbers[currentIndex];
                        sortedNumbers[currentIndex] = sortedNumbers[currentIndex + 1];
                        sortedNumbers[currentIndex + 1] = temporaryNumber;
                    }
                }
            }

            foreach (int number in sortedNumbers)
            {
                Debug.Log(number);
            }
            return numbers;
        }

        public int[] AS03_InsertionSortDescending(int[] numbers)
        {
            return numbers;
        }

        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            return 0;
        }

        #endregion

        #region Extra

        public int EX01_FindLongestConsecutiveSequence(int[] numbers)
        {
            return 0;
        }

        #endregion
    }
}
