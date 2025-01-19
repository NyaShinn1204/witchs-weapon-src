using System.Collections.Generic;
using System.Reflection;

namespace System
{
	public static class MissingExtensions
	{
		public static bool HasFlag(this Enum enumValue, Enum flag)
		{
			return false;
		}

		public static T GetCustomAttribute<T>(this PropertyInfo prop, bool inherit) where T : Attribute
		{
			return null;
		}

		public static T GetCustomAttribute<T>(this MemberInfo member, bool inherit) where T : Attribute
		{
			return null;
		}

		public static T GetCustomAttribute<T>(this MemberInfo member) where T : Attribute
		{
			return null;
		}

		public static IEnumerable<TResult> Zip<T1, T2, TResult>(this IEnumerable<T1> list1, IEnumerable<T2> list2, Func<T1, T2, TResult> zipper)
		{
			return null;
		}
	}
}
