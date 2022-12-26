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
