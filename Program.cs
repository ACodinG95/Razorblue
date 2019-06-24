using System;
using System.Net;

namespace Razorblue
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
        public static uint ConvertFromIpAddressToInteger(string ipAddress)
        {
            var address = IPAddress.Parse(ipAddress);   // converts string into an ip address object
            byte[] bytes = address.GetAddressBytes();   // makes an arrays of the bytes in that address

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);           // ensures the bytes are ordered with the maost significant byte at the end so they convert properly
            }

            return BitConverter.ToUInt32(bytes, 0);     //Converts the bytes into an intger value
        }       // This Function was found on stack overflow 

       /*  static bool checkAddress(string toCheck, string checkAgainst)
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


        } */

        static bool checkAddress(string toCheck, string checkAgainst)
        {
            
            if(!checkAgainst.Contains("/"))
                {
                    if(toCheck == checkAgainst){return true;}
                    else{return false;}
                }
            else{

                string[] checkAgainstParts = checkAgainst.Split("/");

                int suffix = Convert.ToInt32(checkAgainstParts[1]);



                /*uint range = Convert.ToUInt32( Math.Pow(2,int.Parse(checkAgainstParts[1])));

                


                uint lowerBound = ConvertFromIpAddressToInteger(checkAgainstParts[0]);
                uint upperBound = lowerBound + range - 1;
                uint checkNumber = ConvertFromIpAddressToInteger(toCheck);

                if(lowerBound <= checkNumber && checkNumber <= upperBound){return true;}*/
            }


            return false;
        }
        static bool isAddressInList(string address, string[] addressList)
        {
            for(int i = 0; i < addressList.Length; i++)
            {
                if(checkAddress(address,addressList[i])){return true;}
            }

            return false;
        }

        static void testIPcheck()
        {

            string[] exampleList = {"127.0.0.0/24",
                                    "172.16.0.0"
                                    
                                    };

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

        public static void FizzBuzz()
        {


            if(83 >= 32){

            int timesRan = 0;

            while(timesRan < 1){

            for(int i = 1; i <= 62;)
            {

                string Fizz = "F" + "i" + "z" + "z";
                string Buzz = "B" + "u" + "z" + "z";
                string FizzBuzz = "F" + "i" + "z" + "z" + "B" + "u" + "z" + "z";

                if(!!!isThisPositiveIntegerExactlyDivisibleByThreeOrNot(i) && !!isThisPositiveIntegerExactlyDivisibleByFiveOrNot(i)){Console.WriteLine(Fizz);}
                if(!!!!!!!!isThisPositiveIntegerExactlyDivisibleByThreeOrNot(i) && !!!!!isThisPositiveIntegerExactlyDivisibleByFiveOrNot(i)){Console.WriteLine(Buzz);}
                if(!!isThisPositiveIntegerExactlyDivisibleByThreeOrNot(i) && !!!!!!isThisPositiveIntegerExactlyDivisibleByFiveOrNot(i)){Console.WriteLine(FizzBuzz);}
                if(!!!!!isThisPositiveIntegerExactlyDivisibleByThreeOrNot(i) && !!!isThisPositiveIntegerExactlyDivisibleByFiveOrNot(i)){Console.WriteLine(i);}

                i++;

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

            timesRan += 1;

            }

            }

        }

        static void Main(string[] args)
        {

            //testAnagrams();
            //FizzBuzz();

            string checkAgainst = "192.168.60.55/12";
            string toCheck = "127.0.0.140";

            string[] checkAgainstParts = checkAgainst.Split("/");

            Byte[] checkAgainstBytes = IPAddress.Parse(checkAgainstParts[0]).GetAddressBytes();
            Byte[] lowerBound = {0,0,0,0};
            Byte[] upperBound = {0,0,0,0};

            int suffix = Convert.ToInt32(checkAgainstParts[1]);

            int octet = 0;

            if(suffix >= 1 && suffix <= 8){octet = 1;}
            if(suffix >= 9 && suffix <= 16){octet = 2;}
            if(suffix >= 17 && suffix <= 24){octet = 3;}
            if(suffix >= 25 && suffix <= 32){octet = 4;}

            switch (octet)
            {
                case 1:
                    lowerBound[1] = 0;
                    upperBound[1] = 255;
                    lowerBound[2] = 0;
                    upperBound[2] = 255;
                    lowerBound[3] = 0;
                    upperBound[3] = 255;

                    string addressBinary1 = Convert.ToString(checkAgainstBytes[0], 2).PadLeft(8, '0');
                    string octetBinary1 = new string('1',8 - 8 + suffix).PadRight(8,'0');
             
                    int byteNumber1 = 0;
                    for(int i = 0; i < 8;i++){
                        if(addressBinary1[i] == '1' && octetBinary1[i] == '1'){byteNumber1 += Convert.ToInt32(Math.Pow(2,7-i));}
                    }
                    lowerBound[0] = Convert.ToByte(byteNumber1);
                    byteNumber1 += Convert.ToInt32( Math.Pow(2,(8 - suffix))) - 1;
                    upperBound[0] = Convert.ToByte(byteNumber1);
                    break;
                case 2:
                    lowerBound[0] = checkAgainstBytes[0];
                    upperBound[0] = checkAgainstBytes[0];
                    lowerBound[2] = 0;
                    upperBound[2] = 255;
                    lowerBound[3] = 0;
                    upperBound[3] = 255;

                    string addressBinary2 = Convert.ToString(checkAgainstBytes[1], 2).PadLeft(8, '0');
                    string octetBinary2 = new string('1',8 - 16 + suffix).PadRight(8,'0');
             
                    int byteNumber2 = 0;
                    for(int i = 0; i < 8;i++){
                        if(addressBinary2[i] == '1' && octetBinary2[i] == '1'){byteNumber2 += Convert.ToInt32(Math.Pow(2,7-i));}
                    }
                    lowerBound[1] = Convert.ToByte(byteNumber2);
                    byteNumber2 += Convert.ToInt32( Math.Pow(2,(16 - suffix))) - 1;
                    upperBound[1] = Convert.ToByte(byteNumber2);
             
                    break;

                case 3:
                    lowerBound[0] = checkAgainstBytes[0];
                    upperBound[0] = checkAgainstBytes[0];
                    lowerBound[1] = checkAgainstBytes[1];
                    upperBound[1] = checkAgainstBytes[1];
                    lowerBound[3] = 0;
                    upperBound[3] = 255;

                    string addressBinary3 = Convert.ToString(checkAgainstBytes[2], 2).PadLeft(8, '0');
                    string octetBinary3 = new string('1',8 - 24 + suffix).PadRight(8,'0');
             
                    int byteNumber3 = 0;
                    for(int i = 0; i < 8;i++){
                        if(addressBinary3[i] == '1' && octetBinary3[i] == '1'){byteNumber3 += Convert.ToInt32(Math.Pow(2,7-i));}
                    }
                    lowerBound[2] = Convert.ToByte(byteNumber3);
                    byteNumber3 += Convert.ToInt32( Math.Pow(2,(24 - suffix))) - 1;
                    upperBound[2] = Convert.ToByte(byteNumber3);


                    break;
                case 4:
                    lowerBound[0] = checkAgainstBytes[0];
                    upperBound[0] = checkAgainstBytes[0];
                    lowerBound[1] = checkAgainstBytes[1];
                    upperBound[1] = checkAgainstBytes[1];
                    lowerBound[2] = checkAgainstBytes[2];
                    upperBound[2] = checkAgainstBytes[2];

                    string addressBinary4 = Convert.ToString(checkAgainstBytes[3], 2).PadLeft(8, '0');
                    string octetBinary4 = new string('1',8 - 32 + suffix).PadRight(8,'0');
             
                    int byteNumber4 = 0;
                    for(int i = 0; i < 8;i++){
                        if(addressBinary4[i] == '1' && octetBinary4[i] == '1'){byteNumber4 += Convert.ToInt32(Math.Pow(2,7-i));}
                    }
                    lowerBound[3] = Convert.ToByte(byteNumber4);
                    byteNumber4 += Convert.ToInt32( Math.Pow(2,(32 - suffix))) - 1;
                    upperBound[3] = Convert.ToByte(byteNumber4);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }



        foreach(Byte j in lowerBound){Console.WriteLine(j);}
        foreach(Byte j in upperBound){Console.WriteLine(j);}





        }
    }
}