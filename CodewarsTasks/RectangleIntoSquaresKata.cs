using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CodewarsTasks
{
    /*https://www.codewars.com/kata/55466989aeecab5aac00003e/train/csharp
     * 
     * The drawing below gives an idea of how to cut a given "true" rectangle into squares ("true" rectangle meaning that the two dimensions are different).
     * Can you translate this drawing into an algorithm?
     * You will be given two dimensions a positive integer length
     * a positive integer width
     * You will return a collection or a string (depending on the language; Shell bash, PowerShell, Pascal and Fortran return a string) with the size of each of the squares.
     * 
     * +--Examples in general form:
     *      sqInRect(5, 3) should return [3, 2, 1, 1]
     *      sqInRect(3, 5) should return [3, 2, 1, 1]
     */

    /*
     * Google Translate:
     * 
     * Рисунок ниже дает представление о том, как разрезать данный «настоящий» прямоугольник на квадраты («настоящий» прямоугольник означает, что два размера различны).
     * Можете ли вы перевести этот рисунок в алгоритм?
     * Вам будут даны два измерения положительной целочисленной длины.
     * положительное целое число ширины
     * Вы вернете коллекцию или строку (в зависимости от языка; Shell bash, PowerShell, Pascal и Fortran возвращают строку) с размером каждого квадрата.
     *
     * +--Примеры в общем виде:
     *      sqInRect(5, 3) должен возвращать [3, 2, 1, 1]
     *      sqInRect(3, 5) должен возвращать [3, 2, 1, 1]
     */


    public class RectangleIntoSquaresKata
    {
        public static List<int> sqInRect(int lng, int wdth)
        {
            // 5, 3

            // 5/2 = 3, 3
            // 5 - 5/2 = 2, 3

            // 2, 3
            // 2, 3/2 = 2
            // 2, 3 - 3/2 = 1, 

            // 2, 1
            // 2/2 = 1,

            var result = new List<int>();

            if (!IsSquarle(lng, wdth))
            {
                var max = Math.Max(lng, wdth);
                var min = Math.Min(lng, wdth);

                int OneShapeLength = (int)Math.Round((double)max/2);
                int OneShapeWidth = min;

                int TwoShapeLength = max - OneShapeLength;
                int TwoShapeWidth = min;

                bool OneShapeIsSquarle = IsSquarle(OneShapeLength, OneShapeWidth);
                bool TwoShapeIsSquarle = IsSquarle(TwoShapeLength, TwoShapeWidth);

                if (OneShapeIsSquarle = TwoShapeIsSquarle)
                {
                    result.Add(OneShapeLength);
                    result.Add(TwoShapeLength);
                }
                else if(OneShapeIsSquarle  == true & TwoShapeIsSquarle == false)
                {
                    result.Add(OneShapeLength);
                    result.AddRange(sqInRect(TwoShapeLength, TwoShapeWidth));
                }
                else
                {
                    result.Add(TwoShapeLength);
                    result.AddRange(sqInRect(OneShapeLength, OneShapeWidth));
                }

                return result;
            }
            else
            {
                result.Add(lng);

                Console.WriteLine(lng);
                return result;
            }
        }

        public static bool IsSquarle(int x, int y)
        {
            return x == y;
        }

    }
}
