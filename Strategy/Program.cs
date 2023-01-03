// See https://aka.ms/new-console-template for more information
using Strategy;

Console.WriteLine("Hello, World!");
StategyTextProcesser stategyTextProcesser = new StategyTextProcesser(new MarkdownTextFormater());
var result = stategyTextProcesser.AppendList("*111", new List<string>() { "222", "333" });
Console.WriteLine(result);

Console.ReadLine();