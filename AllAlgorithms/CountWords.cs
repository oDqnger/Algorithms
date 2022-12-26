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
