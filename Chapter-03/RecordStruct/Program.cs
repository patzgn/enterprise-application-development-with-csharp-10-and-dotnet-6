using RecordStruct;
using static System.Console;

var employee1 = new Employee("Suneel", "Kunani");
var employee2 = new Employee("Suneel", "Kunani");

// ToString of record struct is overwritten to print the properties of the type
WriteLine(employee1.ToString());
WriteLine(employee2);

// GetHashCode of record struct is overwritten to generate the hash code based on values
WriteLine($"HashCode of s1 is: {employee1.GetHashCode()}");
WriteLine($"HashCode of s2 is: {employee2.GetHashCode()}");

// Equality operator of record type is overwritten to check equality based on the values
WriteLine($"Is s1 equals s2: {employee1 == employee2}");

// Deconstruct the fields from the employee object
string firstName;
(firstName, var lastName) = employee1;

// The previous line has mix declaration of variable, 
// we are declaring lastName during deconstruction where as firstName is declared before deconstruction.
// This is possible only in C# 10 and above.
// In C# 9 we will do something like this
// var (firstname, lastname) = employee1;

WriteLine($"firstName: {firstName}, lastName: {lastName}");
