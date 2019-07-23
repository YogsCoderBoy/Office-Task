using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("\t STRING FUNCTION");
            Console.WriteLine("****************************************");

            string Continue;
            string myName;
            string myname1 = "parmar";
         
            do {

                Console.WriteLine("Enter 1 For ToLower():");
                Console.WriteLine("Enter 2 For ToUpper(): ");
                Console.WriteLine("Enter 3 For Trim(): ");
                Console.WriteLine("Enter 4 For Contains(): ");
                Console.WriteLine("Enter 5 For ToCharArray(): ");
                Console.WriteLine("Enter 6 For clone(): ");
                Console.WriteLine("Enter 7 For Substring(): ");
                Console.WriteLine("Enter 8 For Startwith(): ");
                Console.WriteLine("Enter 9 For Split(): ");
                Console.WriteLine("Enter 10 For Endwith(): ");
                Console.WriteLine("Enter 11 For IndexOf(): ");
                Console.WriteLine("Enter 12 For IsNormalized(): ");
                Console.WriteLine("Enter 13 For Insert(): ");
                Console.WriteLine("Enter 14 For LastIndexOf(): ");
                Console.WriteLine("Enter 15 For Length(): ");
                Console.WriteLine("Enter 16 For Remove(): ");
                Console.WriteLine("Enter 17 For Replace(): ");
                Console.WriteLine("Enter 18 For Equals(): ");
                Console.WriteLine("Enter 19 For GetHashCode(): ");
                Console.WriteLine("Enter 20 For GetType(): ");
                Console.WriteLine("Enter 21 For GetTypeCode(): ");
                Console.WriteLine("****************************************");
                Console.WriteLine();
                Console.Write("Enter your  choice:");
                myName = Console.ReadLine();
                Console.WriteLine();
                switch (myName)
                {
                    case "1":
                        //String.ToUpper() - ToUpper function converts string to upper case.
                        Console.Write("Enter Your String:");
                        myName = Console.ReadLine();
                        myName = myName.ToLower();
                        Console.WriteLine("Your String Result: " + myName);
                        break;
                    case "2":
                        //String.ToLower() - ToLower converts string to lower case.
                        Console.Write("Enter Your String:");
                        myName = Console.ReadLine();
                        myName = myName.ToUpper();
                        Console.WriteLine("Your String Result: " + myName);
                        break;
                    case "3":
                        //String.Trim() - Trim function removes extra spaces from the beginning and the ending of string.
                        Console.Write("Enter Your String:");
                        myName = Console.ReadLine();
                        myName = myName.Trim();
                        Console.WriteLine("Your String Result: " + myName);
                        break;
                    case "4":
                        //String.Contains() - Contains method return bool value, it checks whether specified string or character exist in string or not.
                        Console.Write("Enter Your String:");
                        myName = Console.ReadLine();
                        bool iscontain = myName.Contains("");
                        Console.WriteLine("Your String Result: " + iscontain);
                        break;
                    case "5":
                        //String.ToCharArray() - Convert a string to array of character.
                        Console.Write("Enter Your String:");
                        myName = Console.ReadLine();
                        char[] charArray = myName.ToCharArray();
                        foreach (char c in charArray)
                        {
                            Console.WriteLine(c);
                        }

                        break;
                    case "6":
                        Console.Write("Enter Your String:");
                        myName = Console.ReadLine();
                        Console.WriteLine(myName.Clone());
                        break;
                    case "7":
                        //String.Substring() - substring method returns substring of a string.
                        Console.Write("Enter Your String:");
                         myName = Console.ReadLine();
                        myName = myName.Substring(0,5);
                        Console.WriteLine("Your String Result: " + myName);
                        break;
                    
                    case "8":
                        //String.StartsWith()It checks whether the first character of string is same as specified character.
                        Console.Write("Enter Your String:");
                        myName = Console.ReadLine();
                        bool isstring = myName.StartsWith("my");
                        Console.WriteLine("Your String Result: " + isstring);
                        break;
                    case "9":
                        //String.Split() - Split function splits the string on the supplied value.It return the array of string.
                         Console.Write("Enter Your String:");
                        myName = Console.ReadLine();
                        string[] charA = myName.Split(' ');
                        foreach (string c in charA)
                        {   
                            Console.WriteLine(c);
                        }
                        break;
                    case "10":
                        //String.EndsWith() - Startswith method checks whether the last character of a string is same as specified character
                        Console.Write("Enter Your String:");
                        myName = Console.ReadLine();
                        bool isstring1 = myName.EndsWith("sh");
                        Console.WriteLine("Your String Result: " + isstring1);
                        break;
                    case "11":
                        //Returns the first index position of specified value
                        Console.Write("Enter Your String:");
                        myName = Console.ReadLine();
                 
                        Console.WriteLine(myName.IndexOf("y"));
                        break;
                    case "12":
                        //Check Whether string is in Unicode normalization
                        Console.Write("Enter Your String:");
                        myName = Console.ReadLine();

                        Console.WriteLine(myName.IsNormalized());
                        Console.WriteLine("firstname:"+ myName + "lastname:" + myname1);
                        break;

                    case "13":
                        //Insert substring into string
                        Console.Write("Enter Your String:");
                        myName = Console.ReadLine();
                        Console.WriteLine(myName.Insert(0,"hello "));
                        break;
                    case "14":
                        //Returns the last index position of specified value
                        Console.Write("Enter Your String:");
                        myName = Console.ReadLine();
                        Console.WriteLine(myName.LastIndexOf(""));
                        break;

                    case "15":
                        //Returns the Length of String
                        Console.Write("Enter Your String:");
                        myName = Console.ReadLine();
                        Console.WriteLine(myName.Length);
                        break;
                    case "16":
                        //Deletes all the characters from begining to specified index.               
                        Console.Write("Enter Your String:");
                        myName = Console.ReadLine();
                        Console.WriteLine(myName.Remove(2));
                        break;
                    case "17":
                        // Replace the character            
                        Console.Write("Enter Your String:");
                        myName = Console.ReadLine();
                        Console.WriteLine(myName.Replace('e', 'i'));
                        break;

                    case "18":
                        //Compare two string and returns true and false               
                        Console.Write("Enter Your String:");
                        myName = Console.ReadLine();
                        Console.WriteLine(myName.Equals(myname1));
                        break;
                    case "19":
                        // Returns HashCode of String
                        Console.Write("Enter Your String:");
                        myName = Console.ReadLine();
                        Console.WriteLine(myName.GetHashCode());
                        break;

                    case "20":
                        //Returns type of string
                        Console.Write("Enter Your String:");
                        myName = Console.ReadLine();
                        Console.WriteLine(myName.GetType());
                        break;

                    case "21":
                        //Returns type of string
                        Console.Write("Enter Your String:");
                        myName = Console.ReadLine();
                        Console.WriteLine(myName.GetTypeCode());
                        break;
                    default:
                        Console.WriteLine("Enter Invalid Choise..");
                        break;
                }
                Console.WriteLine("Do You Want To Continue(Y / N)");
                Continue = Console.ReadLine();
            } while (Continue != "N" && Continue != "n");

            

        }
       
    }
}

