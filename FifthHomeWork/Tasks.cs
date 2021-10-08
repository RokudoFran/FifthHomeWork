using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthHomeWork
{
    class Tasks
    {
        //Найти минимальный элемент массива
        public static string Еxercise1(int[,] array)
        {

            int i = 0;
            int j = 0;

            int line = array.GetLength(0);
            int column = array.GetLength(1);

            int minValue = array[i, j];

            string message = "";


            for (i = 0; i < line; i++)
            {
                for (j = 0; j < column; j++)
                {
                    if (array[i, j] < minValue)
                    {
                        minValue = array[i, j];
                    }
                }
            }

            message = $"Минимальный элемент массива равен {minValue}";

            return message;
        }

        //Найти максимальный элемент массива
        public static string Еxercise2(int[,] array)
        {
            int i = 0;
            int j = 0;

            int line = array.GetLength(0);
            int column = array.GetLength(1);

            int maxValue = array[i, j];

            string message = "";

            for (i = 0; i < line; i++)
            {
                for (j = 0; j < column; j++)
                {
                    if (array[i, j] > maxValue)
                    {
                        maxValue = array[i, j];
                    }

                }
            }

            message = $"Максимальный элемент массива равен {maxValue}";

            return message;
        }

        //Найти индекс минимального элемента массива
        public static string Еxercise3(int[,] array)
        {
            int i = 0;
            int j = 0;

            int line = array.GetLength(0);
            int column = array.GetLength(1);

            string minIndex = "";
            int minValue = array[i, j];

            string message = "";


            for (i = 0; i < line; i++)
            {
                for (j = 0; j < column; j++)
                {
                    if (array[i, j] < minValue)
                    {
                        minValue = array[i, j];
                        minIndex = $"[ {i};{j} ]";
                    }
                }
            }

            message = $" Индекс минимального элемента массива равен {minIndex}";

            return message;
        }

        //Найти индекс максимального элемента массива
        public static string Еxercise4(int[,] array)
        {
            int i = 0;
            int j = 0;

            int line = array.GetLength(0);
            int column = array.GetLength(1);

            string maxIndex = "";
            int maxValue = array[i, j];

            string message = "";

            for (i = 0; i < line; i++)
            {
                for (j = 0; j < column; j++)
                {
                    if (array[i, j] > maxValue)
                    {
                        maxValue = array[i, j];
                        maxIndex = $"[ {i};{j} ]";
                    }
                }
            }

            message = $" Индекс максимальный элемент массива равен {maxIndex}";

            return message;
        }

        //Найти количество элементов массива, которые больше всех своих соседей одновременно
        public static string Еxercise5(int[,] array)
        {
            int i = 0;
            int j = 0;

            int line = array.GetLength(0);
            int column = array.GetLength(1);

            int tmp = 0;

            string message = "";

            for (i = 0; i < line; i++)
            {
                for (j = 0; j < column; j++)
                {
                    if (
                            ((j == column - 1) || (array[i, j] > array[i, j + 1])) &&
                            ((j == 0) || (array[i, j] > array[i, j - 1])) &&
                            ((i == 0) || (array[i, j] > array[i - 1, j])) &&
                            ((i == line - 1) || (array[i, j] > array[i + 1, j]))
                        )
                    {
                        tmp++;
                    }
                }
            }

            message = $" Количество элементов массива, которые больше всех своих соседей одновременно равно {tmp}";

            return message;
        }

        //Отразите массив относительно его главной диагонали
        public static int[,] Еxercise6(int[,] array)
        {
            int i = 0;
            int j = 0;

            int line = array.GetLength(0);
            int column = array.GetLength(1);

            int tmp = 0;

            if (line == column)
            {
                for (i = 0; i < line; i++)
                {
                    for (j = 1+i; j < column; j++)
                    {
                        tmp = array[i, j];
                        array[i, j] = array[j, i];
                        array[j, i] = tmp;
                    }
                }
            }
            else
            {
                throw new IndexOutOfRangeException("Требуется квадратный массив");
            }


            return array;

        }
    }
}
