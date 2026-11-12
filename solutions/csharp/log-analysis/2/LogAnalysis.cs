public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string separator){
        int index = str.IndexOf(separator);
        return index == -1 ? str : str.Substring(index + separator.Length);
    }

    
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string before, string after){
        int startIndex = str.IndexOf(before);

        if(startIndex == -1)
            return "";

        startIndex += before.Length;

        int endIndex = str.IndexOf(after,startIndex);

        if(endIndex == -1)
            return "";

        return str.Substring(startIndex, endIndex - startIndex);
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str) => str.SubstringAfter(": ");
    
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str) => str.SubstringBetween("[","]");
    
}