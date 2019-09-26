using System;
using System.Text;

namespace DailyKata
{
    public class StringCalculatorKata
    {
        public static double Calculate(string input)
        {
            if (input == string.Empty)
            {
                throw new ArgumentException("Not supported empty strings", nameof(input));
            }
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }
            if (isWH(input))
            {
                throw new ArgumentException("String cant contain only whitespaces",nameof(input));
            }
            if (isNegative(input))
            {
                throw new ArgumentException("Negative numbers not supported", nameof(input));              
            }
            double sum = 0;
            string[] separator = new string[] { "," };
            string[] array;
            array = Parsing(input).Split(separator, StringSplitOptions.RemoveEmptyEntries);
            foreach (string c in array)
            {               
                sum += Convert.ToDouble(c);
            }
            return sum;
        }
        public static string Parsing(string input)
        {
            char[] chArr = input.ToCharArray();
            StringBuilder sb = new StringBuilder(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                if ((chArr[i] > 47 && chArr[i] < 58) || chArr[i] == '-' || chArr[i] == '.')
                    sb.Append(chArr[i]);
                else sb.Append(',');
            }
            return sb.ToString();
        }
        public static bool isWH(string input) 
        {
            int index = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                    index++;
            }
            if (index == input.Length)
                return true;
            return false; 
        }
        public static bool isNegative(string input)
        {
           foreach(char c in input)
                if(c=='-')
                {
                    return true;
                }
            return false;
        }
    }
}
