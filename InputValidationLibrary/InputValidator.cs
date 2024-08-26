namespace InputValidationLibrary
{
    public static class InputValidator
    {
        public static bool ValidateInt(string input, out int result)
        {
            return int.TryParse(input, out result);
        }

        public static bool ValidatePositiveInt(string input, out int result)
        {
            if (int.TryParse(input, out result) && result > 0)
            {
                return true;
            }
            result = 0;
            return false;
        }
        public static bool ValidateChar(string input, out char result)
        {
            if (!string.IsNullOrEmpty(input) && input.Length == 1)
            {
                result = input[0];
                return true;
            }
            result = default;
            return false;
        }

        public static bool ValidateInRange(int number, int min, int max)
        {
            return number >= min && number <= max;
        }
        public static bool ValidateDouble(string input, out double result)
        {
            return double.TryParse(input, out result);
        }
    }
}
