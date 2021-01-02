using System;
using System.Linq;
using System.Text;

namespace Automation_Suite.Constant
{
    static class Constant_functions
    {   
        private static  Random randomGenerator;

        public static string emailActivateURL;

        public static string redeemCodeText;

        public static string bankCode;

        public static string tuslaNumber;

        public static string bankName;

        public static string key_IrelandCitizen = "EUCitizen";
        public static string key_EuCitizen = "EUCitizen";
        public static string Key_Asylum_Seeker_RefugeeCitizen = "Asylum_Seeker_RefugeeCitizen";
        public static string key_SW_IC_NR_Citizen = "SW_IC_NR_Citizen";
       
        public static string key_SelfEmployed = "Self_Employed";


        public static string SetDateTimeValue()
        {

           DateTime dt = new DateTime();
           return dt.ToString("dddd, dd MMMM yyyy HH: mm:ss");

        }


       
            public static void randomNumberGeneration(int range)
            {
                Random rng = new Random();

                for (int i = 0; i < range; ++i)
                {
                     Console.Out.WriteLine(rng.Next());

                }
            
            }

        
        public static string RandomNumGeneration(int limit)
        {
            StringBuilder str = new StringBuilder();

            int g_RandomInt = 0;
            Random Ran = new Random();
            for (int i = 0; i < limit; i++)
            {
                g_RandomInt = Ran.Next(0, 9);

                str.Append(g_RandomInt);
                
            }

            Console.WriteLine(str);

            return str.ToString();
            
        }
        public static int GenerateRandomInt(Random rnd)
        {
            return rnd.Next();
        }


        public static string GetRandomAlphaNumeric()
        {
            Random random = new Random();
            var chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(chars.Select(c => chars[random.Next(chars.Length)]).Take(8).ToArray());
        }


       public static string randomString(int length)
        {
            

            // creating a StringBuilder object()
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }

            return str_build.ToString().ToLower();
           
        }
    }
}


 



