using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace ParadoxNotion
{
	public static class ReflectionTools
	{
		private const BindingFlags flagsEverything = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;

		private static Assembly[] _loadedAssemblies;

		private static Dictionary<string, Type> typeMap;

		private static Type[] _allTypes;

		private static Dictionary<Type, FieldInfo[]> _typeFields;

		private static Assembly[] loadedAssemblies
		{
			get
			{
				return null;
			}
		}

		public static Type GetType(string typeFullName, bool fallbackNoNamespace = false, Type fallbackAssignable = null)
		{
			return null;
		}

		private static void LateLog(object logMessage, LogType logType = LogType.Log)
		{
		}

		private static Type GetTypeDirect(string typeFullName)
		{
			return null;
		}

		private static Type TryResolveGenericType(string typeFullName, bool fallbackNoNamespace = false, Type fallbackAssignable = null)
		{
			return null;
		}

		private static Type TryResolveDeserializeFromAttribute(string typeName)
		{
			return null;
		}

		private static Type TryResolveWithoutNamespace(string typeName, Type fallbackAssignable = null)
		{
			return null;
		}

		public static Type[] GetAllTypes()
		{
			return null;
		}

		private static Type[] RTGetExportedTypes(this Assembly asm)
		{
			return null;
		}

		public static string FriendlyName(this Type t, bool trueSignature = false)
		{
			return null;
		}

		public static string SignatureName(this MethodInfo method)
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

		public static bool RTIsAssignableFrom(this Type type, Type second)
		{
			return false;
		}

		public static bool RTIsAbstract(this Type type)
		{
			return false;
		}

		public static bool RTIsValueType(this Type type)
		{
			return false;
		}

		public static bool RTIsArray(this Type type)
		{
			return false;
		}

		public static bool RTIsInterface(this Type type)
		{
			return false;
		}

		public static bool RTIsSubclassOf(this Type type, Type other)
		{
			return false;
		}

		public static bool RTIsGenericParameter(this Type type)
		{
			return false;
		}

		public static bool RTIsGenericType(this Type type)
		{
			return false;
		}

		public static MethodInfo RTGetGetMethod(this PropertyInfo prop)
		{
			return null;
		}

		public static MethodInfo RTGetSetMethod(this PropertyInfo prop)
		{
			return null;
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

		public static MethodInfo RTGetMethod(this Type type, string name, Type[] paramTypes)
		{
			return null;
		}

		public static EventInfo RTGetEvent(this Type type, string name)
		{
			return null;
		}

		public static MethodInfo RTGetDelegateMethodInfo(this Delegate del)
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

		public static MethodInfo[] RTGetMethods(this Type type)
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

		public static Type RTMakeGenericType(this Type type, Type[] typeArgs)
		{
			return null;
		}

		public static Type[] RTGetGenericArguments(this Type type)
		{
			return null;
		}

		public static Type[] RTGetEmptyTypes()
		{
			return null;
		}

		public static T RTCreateDelegate<T>(this MethodInfo method, object instance)
		{
			return default(T);
		}

		public static Delegate RTCreateDelegate(this MethodInfo method, Type type, object instance)
		{
			return null;
		}

		public static bool IsObsolete(this MemberInfo member)
		{
			return false;
		}

		public static bool IsReadOnly(this FieldInfo field)
		{
			return false;
		}

		public static PropertyInfo GetBaseDefinition(this PropertyInfo propertyInfo)
		{
			return null;
		}

		public static FieldInfo GetBaseDefinition(this FieldInfo fieldInfo)
		{
			return null;
		}

		public static Type GetEnumerableElementType(this Type enumType)
		{
			return null;
		}
	}
}
