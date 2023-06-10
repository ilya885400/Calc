public class InputValidator
{
    public static bool IsValidNumber(string input)
    {
        if (string.IsNullOrEmpty(input))
            return false;

        if (input == "∞")
            return false;

        if (char.IsLetter(input[0]))
            return false;

        if (input.IndexOf(",") > 0 && input.Contains(","))
            return false;

        return true;
    }

    public static bool IsValidOperator(string input)
    {
        if (string.IsNullOrEmpty(input))
            return false;

        // Проверка на допустимые операторы

        return true;
    }

    public static bool IsValidInput(string input)
    {
        return IsValidNumber(input) || IsValidOperator(input);
    }
}