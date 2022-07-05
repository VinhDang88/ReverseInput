using System.Collections;

Console.WriteLine("Please enter a word you would like to reverse:");
string normalWord = Console.ReadLine();
Console.WriteLine(ReverseWord(normalWord));
static string ReverseWord(string str)
{
    char[] c = str.ToCharArray();
    int index = c.Length;
    Stack myStack = new Stack();
    for (int i = 0; i < index; i++)
    {
        myStack.Push(c[i]);
    }
    for (int i = 0; i < index; i++)
    {
        c[i] = (char)myStack.Pop();
    }
    return string.Join("", c);
}

//string newWord = Console.ReadLine();
//int size = charArr.Length;
//char[] charArr = newWord.ToCharArray();
//Stack myStack = new Stack();
//for (int i = 0; i < size; i++)
//{
//    myStack.Push(charArr[i]);
//}
//for (int i = 0; i < size; i++)
//{
//    charArr[i] = (char)Stack.Pop();
//}
