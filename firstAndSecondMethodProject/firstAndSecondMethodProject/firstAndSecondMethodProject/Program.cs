char[] alphabetUpper = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

char[] alphabetLower = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
while (true)
{
    Console.Write("PLS INSERT FIRST TEXT FOR CHANGE TO UPPER CHARS : ");
    string targetText = Console.ReadLine();
    string result = AlphabetChanger(targetText, alphabetUpper, alphabetLower);
    Console.WriteLine($"Your changed name : {result}");

    Console.Write("PLS INSERT SECOND TEXT FOR CHANGE TO LOWER CHARS : ");
    string targetText2 = Console.ReadLine();
    string result2 = AlphabetChanger2(targetText2, alphabetLower, alphabetUpper);
    Console.WriteLine($"Your changed name : {result2}");
}
static string AlphabetChanger(string suitableText, char[] upperAlphabet, char[] lowerAlphabet)
{
    for (int i = 0; i < upperAlphabet.Length; i++)
    {
        suitableText = suitableText.Replace(lowerAlphabet[i], upperAlphabet[i]);
    }
    return suitableText;
}

static string AlphabetChanger2(string suitableText, char[] lowerAlphabet, char[] upperAlphabet)
{
    for (int i = 0; i < lowerAlphabet.Length; i++)
    {
        suitableText = suitableText.Replace(upperAlphabet[i], lowerAlphabet[i]);
    }
    return suitableText;
}