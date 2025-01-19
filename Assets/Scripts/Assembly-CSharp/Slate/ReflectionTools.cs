using System;
using System.Collections.Generic;
using System.Reflection;

namespace Slate
{
	public static class ReflectionTools
	{
		private const BindingFlags flagsEverything = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

		private static List<Assembly> _loadedAssemblies;

		private static Dictionary<string, Type> typeMap;

		private static List<Assembly> loadedAssemblies
		{
			get
			{
				return null;
			}
		}

		public static Type GetType(string typeName)
		{
			return null;
		}

		public static Type[] GetAllTypes()
		{
			return null;
		}

		public static Type[] GetDerivedTypesOf(Type baseType)
		{
			return null;
		}

		private static Type[] RTGetExportedTypes(this Assembly asm)
		{
			return null;
		}

		public static string FriendlyName(this Type type)
		{
			return null;
		}

		public static bool RTIsStatic(this PropertyInfo propertyInfo)
		{
			return false;
		}

		public static bool RTIsAbstract(this Type type)
		{
			return false;
		}

		public static bool RTIsSubclassOf(this Type type, Type other)
		{
			return false;
		}

		public static bool RTIsAssignableFrom(this Type type, Type second)
		{
			return false;
		}

		public static FieldInfo RTGetField(this Type type, string name)
		{
			return null;
		}

		public static PropertyInfo RTGetProperty(this Type type, string name)
		{
			return null;
		}

		public static MethodInfo RTGetMethod(this Type type, string name)
		{
			return null;
		}

		public static FieldInfo[] RTGetFields(this Type type)
		{
			return null;
		}

		public static PropertyInfo[] RTGetProperties(this Type type)
		{
			return null;
		}

		public static MemberInfo[] RTGetPropsAndFields(this Type type)
		{
			return null;
		}

		public static MethodInfo RTGetGetMethod(this PropertyInfo prop)
		{
			return null;
		}

		public static MethodInfo RTGetSetMethod(this PropertyInfo prop)
		{
			return null;
		}

		public static Type RTReflectedType(this Type type)
		{
			return null;
		}

		public static Type RTReflectedType(this MemberInfo member)
		{
			return null;
		}

		public static T RTGetAttribute<T>(this Type type, bool inherited) where T : Attribute
		{
			return null;
		}

		public static T RTGetAttribute<T>(this MemberInfo member, bool inherited) where T : Attribute
		{
			return null;
		}

		public static T RTCreateDelegate<T>(this MethodInfo method, object instance)
		{
			return default(T);
		}
	}
}
