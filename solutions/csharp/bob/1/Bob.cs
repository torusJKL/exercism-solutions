public static class Bob
{
    public static string Response(string statement)
    {
        if (String.IsNullOrWhiteSpace(statement)){
            return "Fine. Be that way!";            
        }

        var trimmedStatement = statement.Trim();
        var hasLetters = trimmedStatement.Any(char.IsLetter);
        var allCaps = hasLetters && statement.ToUpper() == statement;
        var isQuestion = trimmedStatement.Substring(trimmedStatement.Length - 1) == "?";
        
        if (isQuestion && !allCaps){
            return "Sure.";
        }

        if (isQuestion && allCaps){
            return "Calm down, I know what I'm doing!";
        }

        if (!isQuestion && allCaps){
            return "Whoa, chill out!";
        }

        return "Whatever.";
    }
}