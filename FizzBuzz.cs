namespace FizzBuzz
{
    /// <summary>
    /// Klass som med metoder för spelet Fizzbuzz
    /// </summary>
    public class CFizzBuzz
    {
        /// <summary>
        /// Kollar om det är en fizz
        /// </summary>
        /// <param name="tal"></param>
        /// <returns></returns>
        public bool fizz(int tal)
        {

            if ((tal % 3 == 0) && (tal % 5 == 0))
                return false;
            else if (tal % 3 == 0)
                return true;
            else
                return false;   
        }

        public bool buzz(int tal)
        {
            if ((tal % 3 == 0) && (tal % 5 == 0))
                return false;
            else if (tal % 5 == 0)
                return true;
            else
                return false;
        }

        public bool FizzBuzz(int tal)
        {
            if ((tal % 3 == 0) && (tal % 5 == 0))
                return true;
            else
                return false;
        }

    }
}