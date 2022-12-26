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
