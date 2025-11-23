using NET_CarRentalSystem.Shared.Pagination;
using System.Linq.Expressions;
using System.Reflection;

namespace NET_CarRentalSystem.Shared.Utilities;

public static class ExpressionBuilder
{
    public static Expression<Func<T, bool>> BuildPredicate<T>(List<FilterCriterion> filters)
    {
        var parameter = Expression.Parameter(typeof(T), "x");
        Expression? combined = null;

        foreach (var filter in filters)
        {
            if (filter.Field == null) continue;
            var property = BuildPropertyExpression(parameter, filter.Field);
            var values = filter.Value?.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            Expression? orExpr = null;

            if (property.Type == typeof(string))
            {
                if (values != null) orExpr = (from val in values let toLower = Expression.Call(property, nameof(string.ToLower), Type.EmptyTypes) let constant = Expression.Constant(val.ToLower()) let containsMethod = typeof(string).GetMethod(nameof(string.Contains), [typeof(string)])! select Expression.Call(toLower, containsMethod, constant)).Aggregate(orExpr, (current, containsExpr) => current == null ? containsExpr : Expression.OrElse(current, containsExpr));
            }
            else
            {
                if (values != null)
                    foreach (var val in values)
                    {
                        var targetType = Nullable.GetUnderlyingType(property.Type) ?? property.Type;

                        object? converted;
                        try
                        {
                            if (targetType == typeof(Guid))
                                converted = Guid.Parse(val);
                            else if (targetType == typeof(DateTime))
                                converted = DateTime.Parse(val);
                            else if (targetType.IsEnum)
                                converted = Enum.Parse(targetType, val, ignoreCase: true);
                            else
                                converted = Convert.ChangeType(val, targetType);
                        }
                        catch (Exception ex)
                        {
                            throw new InvalidOperationException(
                                $"Cannot convert value '{val}' to type '{targetType.Name}' for field '{filter.Field}'.",
                                ex);
                        }

                        var constant = Expression.Constant(converted, property.Type);
                        var equalsExpr = Expression.Equal(property, constant);
                        orExpr = orExpr == null ? equalsExpr : Expression.OrElse(orExpr, equalsExpr);
                    }
            }

            if (orExpr != null)
                combined = combined == null ? orExpr : Expression.AndAlso(combined, orExpr);
        }

        return combined != null
            ? Expression.Lambda<Func<T, bool>>(combined, parameter)
            : x => true;
    }

    private static Expression BuildPropertyExpression(Expression parameter, string field)
    {
        var property = parameter;
        var type = parameter.Type;

        foreach (var member in field.Split('.'))
        {
            var prop = type.GetProperty(member,
                BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);

            if (prop == null)
                throw new InvalidOperationException(
                    $"Property '{member}' not found on type '{type.Name}'. " +
                    $"Check your filter field name: '{field}'.");

            property = Expression.Property(property, prop);
            type = prop.PropertyType;
        }

        return property;
    }
}
