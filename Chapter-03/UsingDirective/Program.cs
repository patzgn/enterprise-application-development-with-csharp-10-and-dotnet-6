using System;
using UsingDirective;

Console.WriteLine("Hello World!");

var s1 = new Employee("Suneel", "Kunani");
var s2 = new Employee("Suneel", "Kunani");

// ToString of record is overwritten to print the properties of the type
Console.WriteLine(s1);

// GetHashCode of record is overwritten to generate the hash code based on values
Console.WriteLine($"HashCode of s1 is: {s1.GetHashCode()}");
Console.WriteLine($"HashCode of s2 is: {s2.GetHashCode()}");
// Equality operator of record type is overwritten to check equality based on the values
Console.WriteLine($"Is s1 equals s2: {s1 == s2}");

var s3 = new EmployeeNormalStruct
{
    FirstName = "Suneel",
    LastName = "Kunani"
};

var s4 = new EmployeeNormalStruct
{
    FirstName = "Suneel",
    LastName = "Kunani"
};

Console.WriteLine(s3.ToString());

Console.WriteLine($"HashCode of s3 is: {s3.GetHashCode()}");
Console.WriteLine($"HashCode of s4 is: {s4.GetHashCode()}");

// Console.WriteLine($"Is s3 equals s4: {s3 == s4}");
