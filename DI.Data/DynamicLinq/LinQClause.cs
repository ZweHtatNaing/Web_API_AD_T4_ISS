using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DI.Data.DynamicLinq
{
    static class LinQClause
    {

        public static Func<TSource, bool> SingleWhere<TSource>(string property, object value, string expression)
        {

            var type = typeof(TSource);
            var pe = Expression.Parameter(type, "p");
            var propertyReference = Expression.Property(pe, property);
            var constantReference = Expression.Constant(value);
            MethodInfo containsMethod = typeof(string).GetMethod("Contains");
            MethodInfo startsWithMethod = typeof(string).GetMethod("StartsWith", new Type[] { typeof(string) });
            MethodInfo endsWithMethod = typeof(string).GetMethod("EndsWith", new Type[] { typeof(string) });

            switch (expression)
            {
                case "Equal":
                    return Expression.Lambda<Func<TSource, bool>>(Expression.Equal(propertyReference, constantReference), new[] { pe }).Compile();
                    break;
                case "NotEqual":
                    return Expression.Lambda<Func<TSource, bool>>(Expression.NotEqual(propertyReference, constantReference), new[] { pe }).Compile();
                    break;
                case "VGT":
                    return Expression.Lambda<Func<TSource, bool>>(Expression.GreaterThan(propertyReference, constantReference), new[] { pe }).Compile();
                    break;
                case "PGT":
                    var twoPropertyGT = Expression.Property(pe, property);
                    return Expression.Lambda<Func<TSource, bool>>(Expression.GreaterThan(propertyReference, twoPropertyGT), new[] { pe }).Compile();
                    break;
                case "VGTE":
                    return Expression.Lambda<Func<TSource, bool>>(Expression.GreaterThanOrEqual(propertyReference, constantReference), new[] { pe }).Compile();
                    break;
                case "PGTE":
                    var twoPropertyGTE = Expression.Property(pe, property);
                    return Expression.Lambda<Func<TSource, bool>>(Expression.GreaterThanOrEqual(propertyReference, twoPropertyGTE), new[] { pe }).Compile();
                    break;
                case "VLT":
                    return Expression.Lambda<Func<TSource, bool>>(Expression.LessThan(propertyReference, constantReference), new[] { pe }).Compile();
                    break;
                case "PLT":
                    var twoPropertyLT = Expression.Property(pe, property);
                    return Expression.Lambda<Func<TSource, bool>>(Expression.LessThan(propertyReference, twoPropertyLT), new[] { pe }).Compile();
                    break;
                case "VLTE":
                    return Expression.Lambda<Func<TSource, bool>>(Expression.LessThanOrEqual(propertyReference, constantReference), new[] { pe }).Compile();
                    break;
                case "PLTE":
                    var twoPropertyLTE = Expression.Property(pe, property);
                    return Expression.Lambda<Func<TSource, bool>>(Expression.LessThanOrEqual(propertyReference, twoPropertyLTE), new[] { pe }).Compile();
                    break;
                case "Cointain":
                    return Expression.Lambda<Func<TSource, bool>>(Expression.Call(propertyReference, containsMethod, constantReference), new[] { pe }).Compile();
                    break;
                case "StartsWith":
                    return Expression.Lambda<Func<TSource, bool>>(Expression.Call(propertyReference, startsWithMethod, constantReference), new[] { pe }).Compile();
                    break;
                case "EndsWith":
                    return Expression.Lambda<Func<TSource, bool>>(Expression.Call(propertyReference, endsWithMethod, constantReference), new[] { pe }).Compile();
                    break;

            }
            return null;




        }

        public static IQueryable<T> OrderByField<T>(this IQueryable<T> query, string fieldName, string method)
        {


            var sourceExpr = Expression.Parameter(typeof(T), "source");
            var propExpr = Expression.Property(sourceExpr, fieldName);
            var selectorExpr = Expression.Lambda(propExpr, sourceExpr);

            Type[] types = new Type[] { query.ElementType, selectorExpr.Body.Type };
            switch (method)
            {
                case "OrderBy":
                    var orderBy = Expression.Call(typeof(Queryable), "OrderBy", types, query.Expression, selectorExpr);
                    return query.Provider.CreateQuery<T>(orderBy);
                    break;
                case "OrderByDescending":
                    var OrderByDescending = Expression.Call(typeof(Queryable), "OrderByDescending", types, query.Expression, selectorExpr);
                    return query.Provider.CreateQuery<T>(OrderByDescending);
                    break;

            }
            return null;
        }

    }
   
}
