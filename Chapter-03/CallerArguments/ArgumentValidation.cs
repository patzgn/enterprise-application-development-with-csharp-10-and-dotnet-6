using System.Runtime.CompilerServices;

namespace CallerArguments;

/// <summary>
/// Helper class to validate the arguments passed to a method using CallerArgumentExpression
/// </summary>
public class ArgumentValidation
{
    /// <summary>
    /// Helper method that throws null if the passed in object is null
    /// </summary>
    /// <typeparam name="T">Argument type</typeparam>
    /// <param name="value">Value passed in</param>
    /// <param name="expression">Parameter name.</param>
    public static void ThrowIfNull<T>(T? value, [CallerArgumentExpression("value")] string? expression = null)
        where T : class
    {
        if (value is null)
        {
            Throw(expression);
        }
    }

    /// <summary>
    /// Helper method to validate the given string is null or an empty string
    /// </summary>
    /// <param name="value">Argument value.</param>
    /// <param name="expression">Parameter name</param>
    public static void ThrowIfNullOrEmpty(string? value, [CallerArgumentExpression("value")] string? expression = null)
    {
        if (string.IsNullOrEmpty(value))
        {
            Throw(expression);
        }
    }

    private static void Throw(string? expression) => throw new ArgumentException($"Argument {expression} is empty.");
}

public static class Verify
{
    public static void IsTrue(this bool value, [CallerArgumentExpression("value")] string? expression = null)
    {
        if (!value)
        {
            Throw(expression);
        }
    }

    private static void Throw(string? expression) => throw new ArgumentException($"{expression} must be True.");
}
