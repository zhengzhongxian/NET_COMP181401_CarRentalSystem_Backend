using System.Linq.Expressions;
using System.Text;

namespace NET_CarRentalSystem.Shared.Utilities;

public class IncludeBuilder<TEntity> where TEntity : class
{
    private readonly List<string> _paths = [];
    
    public IncludeBuilder<TEntity> Include<TProperty>(Expression<Func<TEntity, TProperty>> navigationPropertyPath)
    {
        var path = GetPath(navigationPropertyPath.Body);
        if (!string.IsNullOrEmpty(path))
        {
            _paths.Add(path);
        }
        return this;
    }
    
    public string Build()
    {
        return string.Join(",", _paths);
    }
    
    private static string GetPath(Expression expression)
    {
        var pathBuilder = new StringBuilder();
        var memberExpression = GetMemberExpression(expression);

        while (memberExpression != null)
        {
            if (pathBuilder.Length > 0)
            {
                pathBuilder.Insert(0, ".");
            }
            pathBuilder.Insert(0, memberExpression.Member.Name);
            memberExpression = GetMemberExpression(memberExpression.Expression);
        }

        return pathBuilder.ToString();
    }

    private static MemberExpression? GetMemberExpression(Expression? expression)
    {
        return expression switch
        {
            MemberExpression memberExpression => memberExpression,
            UnaryExpression { Operand: MemberExpression member } => member,
            _ => null
        };
    }
}
