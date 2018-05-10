using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveStringSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "8aaaaa dddd r     ";
            string result = SpaceRemover(str);
            Console.WriteLine(result);
        }
        public static string NoSpace(string input)
        {
            var s = new StringBuilder(input.Length); // (input.Length);
            using (var reader = new System.IO.StringReader(input))
            {
                int i = 0;
                char c;
                for (; i < input.Length; i++)
                {
                    c = (char)reader.Read();
                    if (!char.IsWhiteSpace(c))
                    {
                        s.Append(c);
                    }
                }
            }
            return s.ToString();
        }
        public static string SpaceRemover(string input)
        {
            return input.Replace(" ", "");
        }
    }
}
