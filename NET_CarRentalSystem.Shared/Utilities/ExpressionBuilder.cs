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
            if (filter.Field != null)
            {
                var property = BuildPropertyExpression(parameter, filter.Field);
                var values = filter.Value?.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

                Expression? orExpr = null;

                if (property.Type == typeof(string))
                {
                    if (values != null)
                        foreach (var val in values)
                        {
                            var toLower = Expression.Call(property, nameof(string.ToLower), Type.EmptyTypes);
                            var constant = Expression.Constant(val.ToLower());
                            var containsMethod = typeof(string).GetMethod(nameof(string.Contains), [typeof(string)])!;
                            var containsExpr = Expression.Call(toLower, containsMethod, constant);

                            orExpr = orExpr == null ? containsExpr : Expression.OrElse(orExpr, containsExpr);
                        }
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
        }

        return combined != null
            ? Expression.Lambda<Func<T, bool>>(combined, parameter)
            : x => true;
    }

    private static Expression BuildPropertyExpression(Expression parameter, string field)
    {
        Expression property = parameter;
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
