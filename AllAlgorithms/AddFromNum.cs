// Create a function that takes a number as an argument. Add up all the numbers from 1 to the number you passed to the function. For example, if the input is 4 then your function should return 10 because 1 + 2 + 3 + 4 = 10.
     // dont mind the copy paste xd but do please read it

     public static int AddFromNum(int num) {
          int ans = 0; // answer set to 0
          for (int x = 1; x<=num; x++) { // goes through 0 to num
               ans+=x; // adds to x
          }

          return ans; // returns ans
     }
