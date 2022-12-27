// converts binary to decimal
     public static float BinaryToDecimal(long binary) { 
          string binaryString = binary.ToString(); // converts binary num to string so that we can iterate through it, making operations.
          int index = 1; // index is one (used for calculating each digit) and is multiplied by 2 everytime we go
          float ans = 0; // answer var set to 0
          for (int x = binaryString.Length - 1; x>=0; x--) { // go from the last part of the string to the beginning
               ans += (float)Char.GetNumericValue(binaryString[x]) * index; // add to the ans var by converting the string digit of the binary number to a digit and multiplying the index
               index*=2; // multiply it by 2 everytime we go through the binary num
          }

          return ans; // return ans
     }
