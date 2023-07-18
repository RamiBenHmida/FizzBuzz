namespace Aufgabe1
{
    /// <summary>
    /// The FizzBuzz class provides the FizzBuzz Object for a given index and store them in a list.
    /// </summary>
    public class FizzBuzz
    {
        public int Index { get; set; }
        public string Result { get; set; }

        /// <summary>
        /// check if number divisible by 3 and give the result Fizz.
        /// check if number divisible by 5 and give the result Buzz.
        /// for numbers that are both divisible by 3 and 5 they run both conditions
        /// and get the concated result FizzBuzz.
        /// </summary>

        /// <param name="index">The index used for calculating the FizzBuzz result.</param>
        public FizzBuzz(int index)
        {
            Index = index;
            Result = "";

            if (index > 0 && index % 3 == 0)
            {
                Result = "Fizz";
            }

            if (index > 0 && index % 5 == 0)
            {
                Result += "Buzz";
            }
        }
    }
}