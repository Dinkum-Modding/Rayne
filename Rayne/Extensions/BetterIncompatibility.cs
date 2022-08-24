using System;
using System.Reflection;

namespace Rayne.Extensions;

// @TODO
[AttributeUsage(AttributeTargets.Class)]
public class BetterIncompatibility : Attribute
{
    public string Name { get; }
    public string Reason { get; }

    public BetterIncompatibility(string name, string reason)
    {
        Name = name;
        Reason = reason;
    }

    public static string GetName(Type type)
    {
        var attribute = type.GetCustomAttribute<BetterIncompatibility>();
        return attribute?.Name;
    }

    public static string GetReason(Type type)
    {
        var attribute = type.GetCustomAttribute<BetterIncompatibility>();
        return attribute?.Reason;
    }
}