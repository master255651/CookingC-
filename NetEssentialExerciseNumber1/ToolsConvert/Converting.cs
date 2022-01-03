using System;
using System.Collections.Generic;
using System.Text;

namespace NetEssentialExerciseNumber1
{
    class Converting
    {
        public static int StringToInt(string input)
        {
            int enteredNumber;
            bool resultParse = int.TryParse(input, out enteredNumber);

            if (resultParse)
            {
                return enteredNumber;
            }
            else
            {
                Console.WriteLine("\nInvalid value for int!");
                return 0;
            }
        }
    }
}
