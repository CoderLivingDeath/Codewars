using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsTasks
{
    // https://www.codewars.com/kata/513e08acc600c94f01000001/train/csharp

    /*
     * The rgb function is incomplete.
     * Complete it so that passing in RGB decimal values will result in a hexadecimal representation being returned.
     * Valid decimal values for RGB are 0 - 255. Any values that fall out of that range must be rounded to the closest valid value.
     * 
     * Note: Your answer should always be 6 characters long, the shorthand with 3 will not work here.
     */

    /*
     * Google Translate:
     * 
     * Функция RGB неполная.
     * Завершите его так, чтобы передача десятичных значений RGB приводила к возврату шестнадцатеричного представления.
     * Допустимые десятичные значения для RGB: 0–255. Любые значения, выходящие за пределы этого диапазона, должны быть округлены до ближайшего допустимого значения.
     * 
     * Примечание: Ваш ответ всегда должен состоять из 6 символов, сокращение из 3 здесь не подойдет.
     */

    /*
     * Examples (input --> output):
     * 
     * 255, 255, 255 --> "FFFFFF"
     * 255, 255, 300 --> "FFFFFF"
     * 0, 0, 0       --> "000000"
     * 148, 0, 211   --> "9400D3"
     */

    public static class RGBToHexConversionKata
    {

        public static string Rgb(int r, int g, int b)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Math.Clamp(r, 0, 255).ToString("X2"));
            stringBuilder.Append(Math.Clamp(g, 0, 255).ToString("X2"));
            stringBuilder.Append(Math.Clamp(b, 0, 255).ToString("X2"));

            return stringBuilder.ToString();
        }
    }

}
