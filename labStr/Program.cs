Console.WriteLine("Введите предложение:");
string inputSentence = Console.ReadLine();
string[] words = inputSentence.Split(' ');
Console.WriteLine("Предложение в обратном порядке слов:");
for (int i = words.Length - 1; i >= 0; i--)
{
    Console.Write(words[i] + " ");
}
Console.ReadLine();
