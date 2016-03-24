using System;

class StringsAndObjects
{
    static void Main(string[] args)
    {
        string word1 = "Hello";
        string word2 = "World";
        object sentence = word1 + " " + word2;
        object castSentence = (string)sentence;
        Console.WriteLine("strng: {0}, string: {1}, object: {2}, string casted: {3}", word1, word2, sentence, castSentence);
    }
}
