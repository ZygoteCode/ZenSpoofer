using System.Security.Cryptography;
using System.Text;
using System;

public static class Utils
{
    private static ProtoRandom.ProtoRandom _random = new ProtoRandom.ProtoRandom(5);
    internal static readonly char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    internal static readonly char[] numbers = "123456789".ToCharArray();
    internal static readonly char[] everything = "abcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();
    internal static readonly char[] lower = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    internal static readonly char[] lowerNumbers = "abcdefghijklmnopqrstuvwxyz123456789".ToCharArray();
    internal static readonly char[] upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    internal static readonly char[] upperNumbers = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789".ToCharArray();

    public static string RandomUpperNumbers(int size)
    {
        return _random.GetRandomString(upperNumbers, size);
    }

    public static string RandomUpper(int size)
    {
        return _random.GetRandomString(upper, size);
    }

    public static string RandomLowerNumbers(int size)
    {
        return _random.GetRandomString(lowerNumbers, size);
    }

    public static string RandomLower(int size)
    {
        return _random.GetRandomString(lower, size);
    }

    public static string RandomAlpha(int size)
    {
        return _random.GetRandomString(chars, size);
    }

    public static string RandomAlphaNumeric(int size)
    {
        return _random.GetRandomString(everything, size);
    }

    public static int RandomInt(int size)
    {
        return int.Parse(_random.GetRandomString(numbers, size));
    }

    public static long RandomLong(int size)
    {
        return long.Parse(_random.GetRandomString(numbers, size));
    }
}