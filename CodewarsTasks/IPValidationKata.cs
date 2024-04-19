using System.Text.RegularExpressions;

namespace CodewarsTasks
{
    public class IPValidationKata
    {
        /*
         * Write an algorithm that will identify valid IPv4 addresses in dot-decimal format. IPs should be considered valid if they consist of four octets, with values between 0 and 255, inclusive.
         */

        /*
         * Google Translate:
         * 
         * Напишите алгоритм, который будет определять действительные адреса IPv4 в десятичном формате. IP-адреса следует считать действительными, если они состоят из четырех октетов со значениями от 0 до 255 включительно.
         */

        /*
         * Valid inputs examples:
         * 
         *  +--Examples of valid inputs:
         *      1.2.3.4
         *      123.45.67.89
         * 
         *  +--Invalid input examples:
         *      1.2.3
         *      1.2.3.4.5
         *      123.456.78.90
         *      123.045.067.089
         */

        public static bool IsValidIp(string ipAddres)
        {
            foreach (string octet in ipAddres.Split('.'))
            {
                if (octet.Length > 1 && octet.StartsWith("0"))
                {
                    return false;
                }
            }

            string pattern = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";


            return Regex.IsMatch(ipAddres, pattern);
        }
    }
}
