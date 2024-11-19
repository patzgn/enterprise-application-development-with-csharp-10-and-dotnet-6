using LambdaExpression;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// Defining an expression to calculate square of a given number
var square = (int x) => x * x;
Console.WriteLine(square(10));

var sayHello = (string name) => Console.WriteLine($"Hello, {name}");
var sayWelcome = (ref string name) => Console.WriteLine($"Welcome, {name}");

var name = "Suneel";
sayHello(name);
sayWelcome(ref name);

// Expression with return type specified
var createEmployee = Person (bool hasReportees) => hasReportees ? new Manager() : new Employee();
var employee = createEmployee(true);

// Expression with argument attributes
var getEmployeeById = [Authorize] Employee ([FromRoute] int id) => { return new Employee(); };
