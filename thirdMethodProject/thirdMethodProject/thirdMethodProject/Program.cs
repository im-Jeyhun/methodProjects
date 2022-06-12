while (true)
{
    Console.WriteLine("Whould u like to continue with default mode ? press yes or no");
    string targetForm = Console.ReadLine();
    bool isCaseSensetive = false;
    
    if (targetForm == "yes")
    {
        isCaseSensetive = true;
    }
    else if (targetForm == "no")
    {
        isCaseSensetive = false;
    }
    else
    {
        Console.WriteLine("COMMAND NOT FOUND...");
        continue;
    }
    

    Console.Write("INSERT TARGET TEXT : ");
    string targetText = Console.ReadLine();

    Console.Write("Insert target char : ");
    string targetChar = Console.ReadLine();

    bool result = CharChecker(targetText, targetChar, isCaseSensetive);
    Console.WriteLine(result);
}

static bool CharChecker(string targetText, string targetChar, bool isCaseSensetive)
{
    for (int i = 0; i < targetText.Length; i++)
    {
        if (isCaseSensetive == false)
        {
            targetText = targetText.ToLower();
            targetChar = targetChar.ToLower();
            if ($"{targetText[i]}" == targetChar)
            {
                return true;
            }

        }
        else if (isCaseSensetive == true)
        {
            if ($"{targetText[i]}" == targetChar)
            {
                return true;
            }

        }
    }
    return false;
}