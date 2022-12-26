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
