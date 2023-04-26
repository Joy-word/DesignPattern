// See https://aka.ms/new-console-template for more information

using Decorator.Final;


MyStream myStream = new BufferStream(new CryptoStream(new MyFileStream()));
myStream.Read(3);
Console.WriteLine("Hello, World!");
