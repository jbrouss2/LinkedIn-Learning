// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

var word = "";
(bool b, int l) result;
Console.WriteLine("Let's Begin:");

while (word != "exit")
{
    word = Console.ReadLine();
    if(word != "exit")
    {
        result = isPalidrome(word);
        Console.WriteLine($"Palindrome: {result.b}, Length: {result.l}");
    }
}

(bool, int) isPalidrome (string checkFor)
{
    string testStr;

    testStr = checkFor.ToUpper();

    var sb = new StringBuilder();
    foreach (char c in testStr)
    {
        if(!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
        {
            sb.Append(c);
        }
    }

    testStr = sb.ToString();

    int i=0, j=testStr.Length-1;

    while(i <= j)
    {
        if(testStr[i] != testStr[j])
        {
            return(false, 0);
        }
        i++;
        j--;
    }
    return(true, testStr.Length);
}