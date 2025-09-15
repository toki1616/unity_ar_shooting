using System;
using System.Reflection;

public static class EnumExtensions
{
    public static string GetValueString(this Enum value)
    {
        return value.ToString();
    }
}
