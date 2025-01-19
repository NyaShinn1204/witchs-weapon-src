using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace LeanCloud
{
	public static class AVQueryExtensions
	{
		private class ObjectNormalizer : ExpressionVisitor
		{
			protected override Expression VisitIndex(IndexExpression node)
			{
				return null;
			}

			protected override Expression VisitMember(MemberExpression node)
			{
				return null;
			}

			protected override Expression VisitUnary(UnaryExpression node)
			{
				return null;
			}

			protected override Expression VisitMethodCall(MethodCallExpression node)
			{
				return null;
			}
		}

		private class WhereNormalizer : ExpressionVisitor
		{
			protected override Expression VisitBinary(BinaryExpression node)
			{
				return null;
			}

			protected override Expression VisitUnary(UnaryExpression node)
			{
				return null;
			}

			protected override Expression VisitMethodCall(MethodCallExpression node)
			{
				return null;
			}
		}

		private static readonly MethodInfo getMethod;

		private static readonly MethodInfo stringContains;

		private static readonly MethodInfo stringStartsWith;

		private static readonly MethodInfo stringEndsWith;

		private static readonly MethodInfo containsMethod;

		private static readonly MethodInfo notContainsMethod;

		private static readonly MethodInfo containsKeyMethod;

		private static readonly MethodInfo notContainsKeyMethod;

		private static readonly Dictionary<MethodInfo, MethodInfo> functionMappings;

		static AVQueryExtensions()
		{
		}

		private static MethodInfo GetMethod<T>(Expression<Action<T>> expression)
		{
			return null;
		}

		private static bool ContainsStub<T>(object collection, T value)
		{
			return false;
		}

		private static bool NotContainsStub<T>(object collection, T value)
		{
			return false;
		}

		private static bool ContainsKeyStub(AVObject obj, string key)
		{
			return false;
		}

		private static bool NotContainsKeyStub(AVObject obj, string key)
		{
			return false;
		}

		private static object GetValue(Expression exp)
		{
			return null;
		}

		private static bool IsParseObjectGet(MethodCallExpression node)
		{
			return false;
		}

		private static AVQuery<T> WhereMethodCall<T>(this AVQuery<T> source, Expression<Func<T, bool>> expression, MethodCallExpression node) where T : AVObject
		{
			return null;
		}

		private static AVQuery<T> WhereBinaryExpression<T>(this AVQuery<T> source, Expression<Func<T, bool>> expression, BinaryExpression node) where T : AVObject
		{
			return null;
		}

		public static AVQuery<TSource> Where<TSource>(this AVQuery<TSource> source, Expression<Func<TSource, bool>> predicate) where TSource : AVObject
		{
			return null;
		}

		private static string GetOrderByPath<TSource, TSelector>(Expression<Func<TSource, TSelector>> keySelector)
		{
			return null;
		}

		public static AVQuery<TSource> OrderBy<TSource, TSelector>(this AVQuery<TSource> source, Expression<Func<TSource, TSelector>> keySelector) where TSource : AVObject
		{
			return null;
		}

		public static AVQuery<TSource> OrderByDescending<TSource, TSelector>(this AVQuery<TSource> source, Expression<Func<TSource, TSelector>> keySelector) where TSource : AVObject
		{
			return null;
		}

		public static AVQuery<TSource> ThenBy<TSource, TSelector>(this AVQuery<TSource> source, Expression<Func<TSource, TSelector>> keySelector) where TSource : AVObject
		{
			return null;
		}

		public static AVQuery<TSource> ThenByDescending<TSource, TSelector>(this AVQuery<TSource> source, Expression<Func<TSource, TSelector>> keySelector) where TSource : AVObject
		{
			return null;
		}

		public static AVQuery<TResult> Join<TOuter, TInner, TKey, TResult>(this AVQuery<TOuter> outer, AVQuery<TInner> inner, Expression<Func<TOuter, TKey>> outerKeySelector, Expression<Func<TInner, TKey>> innerKeySelector, Expression<Func<TOuter, TInner, TResult>> resultSelector) where TOuter : AVObject where TInner : AVObject where TResult : AVObject
		{
			return null;
		}
	}
}
