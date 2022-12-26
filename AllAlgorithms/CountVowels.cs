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
