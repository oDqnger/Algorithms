/ prints out all the uppercase index positions
     // (this was initally meant to be a list)
     public static void IndexOfUpperCase(string input) {
          foreach (char x in input) { // go through string
               if (Char.IsUpper(x)) { // if the char is uppercase, we output the index of it
                    Console.WriteLine(input.IndexOf(x));
               }
          }
     }
