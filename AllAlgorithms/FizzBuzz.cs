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
