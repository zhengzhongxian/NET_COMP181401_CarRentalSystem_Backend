using System.Reflection;

namespace NET_CarRentalSystem.Shared.Utilities;

public static class ReflectionHelper
{
    public static List<TValue> GetConstants<TValue>(Type classType)
    {
        return [.. classType
            .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
            .Where(fi => fi.IsLiteral && !fi.IsInitOnly && fi.FieldType == typeof(TValue))
            .Select(fi => (TValue)fi.GetRawConstantValue()!)];
    }

    public static List<TFieldType> GetConstants<TClass, TFieldType>()
    {
        return GetConstants<TFieldType>(typeof(TClass));
    }

    public static Dictionary<string, object> GetAllConstants(Type classType)
    {
        return classType
            .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
            .Where(fi => fi.IsLiteral && !fi.IsInitOnly)
            .ToDictionary(fi => fi.Name, fi => fi.GetRawConstantValue()!);
    }
}
