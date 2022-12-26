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
