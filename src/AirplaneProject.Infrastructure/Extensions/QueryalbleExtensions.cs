using AirplaneProject.Domain.Bases;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace AirplaneProject.Infrastructure.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<TEntity> OrderBy<TEntity>(this IQueryable<TEntity> source, SortByDto orderBy)
        {
            string command = orderBy.Desc ? "OrderByDescending" : "OrderBy";
            var type = typeof(TEntity);
            var property = type.GetProperty(orderBy.Property);
            var parameter = Expression.Parameter(type, "p");
            var propertyAccess = Expression.MakeMemberAccess(parameter, property);
            var orderByExpression = Expression.Lambda(propertyAccess, parameter);
            var resultExpression = Expression.Call(typeof(Queryable), command, new Type[] { type, property.PropertyType },
                                          source.Expression, Expression.Quote(orderByExpression));

            return source.Provider.CreateQuery<TEntity>(resultExpression);
        }
    }
}
