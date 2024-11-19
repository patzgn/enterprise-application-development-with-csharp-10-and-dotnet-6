// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var greeting = "Hello";
var language = "C#";
var version = 10;
var message = $"{greeting}, {language}!";
var messageWithVersion = $"{greeting}, {language} {version}!";

var test = new Span<char>();
ReadOnlySpan<char> a;
var messageX = $"{greeting}, {language} {test}!";
