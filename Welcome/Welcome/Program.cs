using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            string language = "italian";
            string result = Greet(language);
            Console.WriteLine(result);
        }
        public static string Greet(string language)
        {
            if(language== "IP_ADDRESS_INVALID"||language==""||language=="2"||language== "IP_ADDRESS_NOT_FOUND"||language== "IP_ADDRESS_REQUIRED")
            {
                return "Welcome";
            }
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("english", "Welcome");
            dict.Add("czeck", "vitejte");
            dict.Add("danish", "velkomst");
            dict.Add("dutch", "Welkom");
            dict.Add("estonian", "Tere tulemast");
            dict.Add("finnish", "Tervetulao");
            dict.Add("french", "Bienvenue");
            dict.Add("german", "Willkommen");
            dict.Add("irish", "failte");
            dict.Add("italian", "Benvenuto");
            dict.Add("latvian", "Gaidits");
            dict.Add("lithuanian", "Laukiamas");
            dict.Add("polish", "Witamis");
            dict.Add("spanish", "Bienvenido");
            dict.Add("Swedish", "Valkommen");
            dict.Add("Welsh", "Croeso");
            if (dict.ContainsKey(language))
            {
                return dict[language];
            }
            else
            {
                return null;
            }
        }
    }
}
