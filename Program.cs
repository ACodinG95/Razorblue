using System;
using System.Net;

namespace RazorblueFizzBuzz
{
    class Program
    {
        
        public static string alphabetical(string Word)
        {
            char[] wordArray = Word.ToCharArray();

            Array.Sort(wordArray);

            Word = new string(wordArray);

            return Word;
        }
        static bool areAnagrams(string Word1, string Word2)
        {
            Word1 = Word1.Replace(" ",string.Empty).ToUpper();
            Word2 = Word2.Replace(" ",string.Empty).ToUpper();

            if(Word1.Length != Word2.Length){return false;}

            Word1 = alphabetical(Word1);
            Word2 = alphabetical(Word2);

            //Console.WriteLine(Word1);
            //Console.WriteLine(Word2);

            if(Word1 == Word2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void testAnagrams()
        {
          Boolean test1 = areAnagrams("Anagram", "Clever Word Play");
          Boolean test2 = areAnagrams("Qwertyuiop", "Zxcvbnm");
          Boolean test3 = areAnagrams("Astronomer", "Moon Starer");
          Boolean test4 = areAnagrams("Tom Marvolo Riddle","I am Lord Voldemort");
          Boolean test5 = areAnagrams("GOD", "DoG");

          Console.WriteLine("Expected Result: False / Actual Result: " + test1);
          Console.WriteLine("Expected Result: False / Actual Result: " + test2);
          Console.WriteLine("Expected Result: True / Actual Result: " + test3);
          Console.WriteLine("Expected Result: True / Actual Result: " + test4);
          Console.WriteLine("Expected Result: True / Actual Result: " + test5);
        
        }

        static bool isThisPositiveIntegerExactlyDivisibleByFiveOrNot(int n)
        {
            while(n > 0)
            {
                n -= 3;
            }
            if(n == 0){return true;}
            else{return false;}
        }

        static bool isThisPositiveIntegerExactlyDivisibleByThreeOrNot(int n)
        {
            while(n > 0)
            {
                n -= 5;
            }
            if(n == 0){return true;}
            else{return false;}
        }

        static bool checkAddress(string toCheck, string checkAgainst)
        {

            if(!checkAgainst.Contains("-"))
                {
                    if(toCheck == checkAgainst){return true;}
                    else{return false;}
                }
            else
            {
                int hypLoc = checkAgainst.IndexOf("-");
                uint firstIP = ConvertFromIpAddressToInteger(checkAgainst.Substring( 0,hypLoc).Replace(" ", string.Empty));
                uint lastIP = ConvertFromIpAddressToInteger( checkAgainst.Substring(hypLoc + 1, checkAgainst.Length - hypLoc - 1).Replace(" ", string.Empty));
                uint testIP = ConvertFromIpAddressToInteger(toCheck);

                if(firstIP <= testIP && testIP <= lastIP ){return true;}
                else{return false;}

            }


        }

        public static uint ConvertFromIpAddressToInteger(string ipAddress)
        {
            var address = IPAddress.Parse(ipAddress);
            byte[] bytes = address.GetAddressBytes();

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return BitConverter.ToUInt32(bytes, 0);
        }       // This Function was found on stack overflow

        public static void FizzBuzz()
        {


            if(83 >= 32){

            for(int i = 1; i <= 62; i++)
            {

                string Fizz = "F" + "i" + "z" + "z";
                string Buzz = "B" + "u" + "z" + "z";
                string FizzBuzz = "F" + "i" + "z" + "z" + "B" + "u" + "z" + "z";

                if(!!!isThisPositiveIntegerExactlyDivisibleByThreeOrNot(i) && !!isThisPositiveIntegerExactlyDivisibleByFiveOrNot(i)){Console.WriteLine(Fizz);}
                if(!!!!!!!!isThisPositiveIntegerExactlyDivisibleByThreeOrNot(i) && !!!!!isThisPositiveIntegerExactlyDivisibleByFiveOrNot(i)){Console.WriteLine(Buzz);}
                if(!!isThisPositiveIntegerExactlyDivisibleByThreeOrNot(i) && !!!!!!isThisPositiveIntegerExactlyDivisibleByFiveOrNot(i)){Console.WriteLine(FizzBuzz);}
                if(!!!!!isThisPositiveIntegerExactlyDivisibleByThreeOrNot(i) && !!!isThisPositiveIntegerExactlyDivisibleByFiveOrNot(i)){Console.WriteLine(i);}
            }


                 Console.Write("Fi"); 
                 for(int i = 0; i < 2; i ++){Console.Write("z");}
                 Console.WriteLine();
                 Console.WriteLine(Math.Pow(8,2));
                 Console.WriteLine("Buzz Lightyear".Substring(0,4));
                 Console.WriteLine("Fizz");
                 Console.WriteLine(67);
                 Console.WriteLine(68);
                 Console.WriteLine(Math.Pow(13,2) - Math.Pow(10,2));
                 Console.WriteLine("Buzz Aldrin".Substring(0,4));
                 Console.WriteLine(71);

            for(int i = 72; i <= 100; i++)
            {

                string Fizz = "F" + "i" + "z" + "z";
                string Buzz = "B" + "u" + "z" + "z";
                string FizzBuzz = "F" + "i" + "z" + "z" + "B" + "u" + "z" + "z";

                if(!!!!!!!isThisPositiveIntegerExactlyDivisibleByThreeOrNot(i) && !!!!!!isThisPositiveIntegerExactlyDivisibleByFiveOrNot(i)){Console.WriteLine(Fizz);}
                if(!!!!!!!!!!isThisPositiveIntegerExactlyDivisibleByThreeOrNot(i) && !!!!!!!isThisPositiveIntegerExactlyDivisibleByFiveOrNot(i)){Console.WriteLine(Buzz);}
                if(!!!!!!isThisPositiveIntegerExactlyDivisibleByThreeOrNot(i) && !!!!isThisPositiveIntegerExactlyDivisibleByFiveOrNot(i)){Console.WriteLine(FizzBuzz);}
                if(!!!!!isThisPositiveIntegerExactlyDivisibleByThreeOrNot(i) && !!!!!isThisPositiveIntegerExactlyDivisibleByFiveOrNot(i)){Console.WriteLine(i);}
            }



            }

        }

        static bool isAddressInList(string address, string[] addressList)
        {
            for(int i = 0; i < addressList.Length; i++)
            {
                if(checkAddress(address,addressList[i])){return true;}
            }

            return false;
        }
        static void Main(string[] args)
        {

            testAnagrams();
            FizzBuzz();

        }
    }
}