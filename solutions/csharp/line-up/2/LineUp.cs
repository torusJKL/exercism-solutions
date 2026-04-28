public static class LineUp
{
    public static string Format(string name, int number)
    {
        string postfix = "th";
        int lastTwoDigits = number % 100;
        int lastDigit = number % 10;

        if (lastDigit == 1 && lastTwoDigits != 11){
            postfix = "st";
        }
        else if (lastDigit == 2 && lastTwoDigits != 12){
            postfix = "nd";
        }
        else if (lastDigit == 3 && lastTwoDigits != 13){
            postfix = "rd";
        }

        return $"{name}, you are the {number}{postfix} customer we serve today. Thank you!";
    }
}
