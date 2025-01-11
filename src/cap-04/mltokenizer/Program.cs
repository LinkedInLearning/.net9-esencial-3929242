using Microsoft.ML.Tokenizers;

Tokenizer tokenizer = TiktokenTokenizer.CreateForModel("gpt-4o");

string text = ".NET 9 es la versión más reciente de esta plataforma de desarrollo.";

System.Console.WriteLine($"Tokens: {tokenizer.CountTokens(text)}");

var result = tokenizer.EncodeToTokens(text, out string? _);

foreach (var item in result)
{
    System.Console.Write($"{item.Value}".PadRight(10));
}

System.Console.WriteLine();

var ids = tokenizer.EncodeToIds(text);

foreach (var item in ids)
{
    System.Console.Write($"{item}".PadRight(10));
}