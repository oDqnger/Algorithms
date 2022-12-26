// idk how to return this or use slicing properly but it returns the middle of a string.
     // if even, return middle two otherwise, return the middle one
     public static void ReturnMiddleTwoChars(string input) {
          if (input.Length % 2 != 0) { // checks to see if they are even or not
               Console.WriteLine(input[input.Length / 2]); // it just simply divides the string by two and the index positionf of the the middle of the string shows
          } else {
               Console.WriteLine($"{input[input.Length / 2 - 1]}{input[(input.Length / 2 - 1) + 1]}"); // it divides it by 2 and minus by one and joins it by doing the same but adding one at the end
          }
     } // hope that makes sense.
