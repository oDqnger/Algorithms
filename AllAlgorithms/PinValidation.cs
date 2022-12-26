// checks to see if a pin is valid (only containing digits and if its 4 digit or 6 digit)
     public static bool isPinValid(string PIN) {
          // we need to check for 2 conditions: if its a digit and if its length is 4 or 6
          try { // tries if it is possible to convert pin to a num, if no, it returns false
               Convert.ToInt32(PIN);
               return PIN.Length == 4 | PIN.Length == 6 ? true : false; // then it checks to see if its length is 4 or 6
          } catch {
               return false; // returns false if its not a digit
          }
     }
