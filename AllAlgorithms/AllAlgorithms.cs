using System;
using System.Collections.Generic;
using System.Linq;

public class AllAlgorithms {
     // Fizz Buzz
     public static void FizzBuzz() {
          for (int x = 1; x<=100; x++) {
               if (x % 3 == 0 && x % 5 == 0) { // this will check to see if the number is both a multiple of 3 and 5.
                    Console.WriteLine("FizzBuzz");
               } else if (x % 3 == 0) {
                    Console.WriteLine("Fizz"); // this will check to see if the number is a multiple of 3
               } else if (x % 5 == 0) {
                    Console.WriteLine("Buzz"); // this will check to see if the number is a multiple of 5
               } else {
                    Console.WriteLine(x); // this prints the number when all conditions are false
               }
          }
     }

     // Reverses a string
     public static string ReverseString(string input) {
          string ans = ""; // makes an empty variable.
          for (int x = input.Length - 1; x>=0; x--) { // this goes from the back of the string to the beginning
               ans = ans + input[x]; // this will store letters from the last to the beginning of this string (if that makes sense)
          }

          return ans; // returns ans using 'return'
     }

     public static bool IsPalindrome(string input) {
          string ans = ""; // makes an empty variable.
          for (int x = input.Length - 1; x>=0; x--) { // this goes from the back of the string to the beginning
               ans = ans + input[x]; // this will store letters from the last to the beginning of this string (if that makes sense)
          }

          return input == ans ? true : false; // makes a ternary statement and checks to see if the input is the same as the reversed string
     }

     // counts the vowels in a string (a,e,i,o,u)
     public static int CountVowels(string input) {
          int count = 0; // answer var set to 0
          input = input.ToLower(); // redefines input to only have lowercase letters, otherwise we can have extra lines of code
          for (int x = 0; x<input.Length; x++) { // goes through string

               // checks to see if input is equal top: a,e,i,o,u
               switch(input[x]) {
                    case 'a':
                         count++;
                         break;
                    case 'e':
                         count++;
                         break;
                    case 'i':
                         count++;
                         break;
                    case 'o':
                         count++;
                         break;
                    case 'u':
                         count++;
                         break;
               }
          }

          return count; // returns ans (count)
     }

     // counts the letters of a string (only letters, no spaces)
     public static int CountWords(string text) {
          int count = 0; // variable answer set to 0
          for (int x = 0; x<text.Length; x++) { //  goes through the string
               if (x!=' ') { // if it is not a space, increment answer
                    count++;
               }

               // otherwise, do nothing
          }

          return count;
     }

     // coin flip simulation
     public static void CoinFlipSimulation(string numTimes) {
          // creating random number
          Random rd = new Random();
          int randomNumber = rd.Next(1,3);
          // converting input to int
          int nt = Convert.ToInt32(numTimes);
          
          // stores heads and tails
          int heads = 0;
          int tails = 0;

          // does it for n times
          for (int x = 0; x<nt; x++) {
               switch(randomNumber) {
                    case 1: // if randomnumber == 1, then it increments heads
                         heads++;
                         break;
                    case 2: // otherwise tails
                         tails++;
                         break;
               }
               randomNumber = rd.Next(1,3); // regenerates number
          }
               

          Console.WriteLine($"Heads landed: {heads} and tails landed: {tails}"); // prints out in this format
     }

     // finds perimeter of a rectangle (only given l and w)
     public static float returnPerimeter (float length, float width) {
          return length * 2 + width * 2; // perimeter of rect is just all sides added. Since it's only given l and width, we just multiple each of them by 2.
     }

     // converts an age to day (ignores leap years)
     public static int AgeToDays(int years) { 
          return years * 360; // a year is 360 days (ignore leap years) and you multiply that by years to get days
     }

     // converts minutes into seconds
     public static float MinToSec(float minutes) {
          return minutes * 60; // to find minutes to second, you simply multiple minutes by 60 because a minute has 60 seconds.
     }

     // Create a function that takes a number as an argument. Add up all the numbers from 1 to the number you passed to the function. For example, if the input is 4 then your function should return 10 because 1 + 2 + 3 + 4 = 10.
     // dont mind the copy paste xd but do please read it

     public static int AddFromNum(int num) {
          int ans = 0; // answer set to 0
          for (int x = 1; x<=num; x++) { // goes through 0 to num
               ans+=x; // adds to x
          }

          return ans; // returns ans
     }

     // forumla: num1 * 2^num2.
     // left shift operator is <<
     public static float LeftShiftByPow2(float num1, float num2) {
          return (int)num1 * MathF.Pow(2f, num2);
     }

     // returns the multiples of a num
     public static void ArrayOfMultiples(int num, int length) {
          int[] ans = new int[length]; // answer as a list with length of int lenght (also the reason why I'm using a list is because the problem was asking for a list to be printed but c# does not accept that)
          int count = 0; // count to store the index position of ans

          for (int x = 1; x<=length; x++) { // goes from 1 - length
               ans[count] = num * x; // ans[count] = num (number we need to find multiple of) * x (factors)
               Console.WriteLine(ans[count]); // prints out answer (if c# accepted return for lists, id not not console.writeline that)
               count++; // increments count
          }
     }

     // function that lower cases the upper case and upper case the lower case :) (useful af)
     public static string ReverseCase(string input) {
          string ans = ""; // stores empty string var
          foreach (char x in input) // go through input
          {
               if (Char.IsLower(x)) { // check to see if char is lowercase
                    ans += Char.ToUpper(x); // we add to the ans variable 'x' and uppercase the lowercase
               } else {
                    ans += Char.ToLower(x); // if it is not uppercase, it lowercases instead
               }
          }

          return ans; // returns ans
     }

     // prints out all the uppercase index positions
     // (this was initally meant to be a list)
     public static void IndexOfUpperCase(string input) {
          foreach (char x in input) { // go through string
               if (Char.IsUpper(x)) { // if the char is uppercase, we output the index of it
                    Console.WriteLine(input.IndexOf(x));
               }
          }
     }

     // checks to see if the word 'bomb' is in input. (no functions used)
     public static string FindBomb(string input) {
          string temp = ""; // stores a temp var (going to be temporary)
          bool isBomb = false; // stores isBomb var to false
          foreach (char x in input) // go through input
          {    
               if (x != ' ') {  // checks to see if it has no space, if no, we know it is a word or a letter and is not seperated.
                    temp += x; // stores that word in a var
               } else { // if there is a space, we check to see if that word is equal to "bomb", if yes it breaks out of loop and sets isBomb to true and if false, it resets the temp variable
                    if (temp == "bomb") {
                         isBomb = true;
                         temp = "";
                         break;
                    } else {
                         isBomb = false;
                         temp = "";
                    }    
               }

               // even if there is no space, we still check to see if it is equal to bomb, cause sometimes there might be substrings like, "bomb!" and it detects '!' in the upper part of the code and returns the wrong output
               if (temp == "bomb") {
                    isBomb = true;
                    break;
               } else {
                    isBomb = false;
               }
          }

          return isBomb ? "Duck!!!" : "There is no bomb, relax."; // if isBomb == true (there is a bomb in the word), it returns the output
     } // tell if there is another soltuion for this :moyai: 

     // checks to see if a pin is valid (only containing digits and if its 4 digit or 6 digit)
     public static bool isPinValid(string PIN) {
          // we need to check for 2 conditions: if its a digit and if its length is 4 or 6
          try { // tries if it is possible to convert pin to a num, if no, it returns false
               Convert.ToInt32(PIN);
               return PIN.Length == 4 | PIN.Length == 6 ? true : false; // then it checks to see if its length is 4 or 6
          } catch {
               return false; // returns false if its not a digit
          }
     }

     // idk how to return this or use slicing properly but it returns the middle of a string.
     public static void ReturnMiddleTwoChars(string input) {
          if (input.Length % 2 != 0) { // checks to see if they are even or not
               Console.WriteLine(input[input.Length / 2]); // here is the formula
          } else {
               Console.WriteLine($"{input[input.Length / 2 - 1]}{input[(input.Length / 2 - 1) + 1]}"); // same formula but just adding one
          }
     }

     // scottish screaming challenge :moyai: lmaoo but you need to replace every word in this sentence to be "scottish"
     // so basically replace every word that has a vowel with e
     public static string ScottishScreaming(string input) {
          input = input.ToLower(); // lowercase input so that it's more easier to check vowels without worrying about casing
          for (int x = 0; x<input.Length; x++) { // goes through string
               // this for loop checkls to see if it is a vowel, if yes, it replaces that vowel with an e.
               if (input[x] == 'a') { 
                    input = input.Replace('a', 'e');
               } else if (input[x] == 'e') {
                    input = input.Replace('e', 'e');
               } else if (input[x] == 'i') {
                    input = input.Replace('i', 'e');
               } else if (input[x] == 'o') {
                    input = input.Replace('o', 'e');
               } else if (input[x] == 'u') {
                    input = input.Replace('u', 'e');
               }
          }

          // returns the edited input to upper case cause its supposed to be scream bruh
          return input.ToUpper();
     }

     // returns the highest and lowest number in a string format (input also in a string format)
     // code doesn't work because of char and int conversion.
     public static string HighLow(string input) {
          int high = 0;
          for (int x = 0; x<input.Length; x+=2) {
               Console.WriteLine((int)Char.GetNumericValue(input[x]));
               if (high < (int)Char.GetNumericValue(input[x])) {
                    high = (int)Char.GetNumericValue(input[x]);
               }
          }
          // IGNORE THIS
          int low = high;

          for (int x = 0; x<input.Length; x+=2) {
               if (low >= (int)Char.GetNumericValue(input[x])) {
                    low = (int)Char.GetNumericValue(input[x]);
               }
          }

          return $"{high} and {low}";
     }

     // truncate s​​​​​​ such that it contains only the first k​​​​​​ words. (challenge taken from leetcode)
     public string TruncateSentence(string s, int k) {
        string ans = ""; // stores an empty var called ans (string)
        int count = 0; // stores an empty var called count (int)
        for (int x = 0; x<s.Length; x++) { // goes through the string
            if (s[x] != ' ') { // checks to see if there is an empty string
                ans = ans + s[x]; // adds s[x] to ans.
            } else { // if it hits a space, it means that it has gone through one word, so in that case we want to increment the count var
                count++; 
                if (count == k) { // we check to see if count == k (which is how much we need to trucate to)
                    break; // we break the loop once it does
                }
                ans = ans + s[x]; // adds a space to s[x]
            }
        }

        return ans;
     }

     // this was all the tests run inside the Main function. (ignore this)
     static void Main(string[] args) {
          // FizzBuzz();
          // Console.WriteLine(ReverseString(Console.ReadLine()));
          // Console.WriteLine(CountVowels(Console.ReadLine()));
          // Console.WriteLine(CountWords("hello"));
          // CoinFlipSimulation(Console.ReadLine());
          // Console.WriteLine(LeftShiftByPow2(46, 6));
          // ArrayOfMultiples(12, 10);
          // Console.WriteLine(ReverseCase("sPoNtAnEoUs"));
          // IndexOfUpperCase("hElLo");
          // Console.WriteLine(FindBomb("This goes boom!!!"));
          // Console.WriteLine(isPinValid("%234"));
          // ReturnMiddleTwoChars("fresh");
          // Console.WriteLine(ScottishScreaming("Butterflies are beautiful!"));
          // Console.WriteLine(HighLow("1345 1 3 4 6 2 3"));
     }
}
