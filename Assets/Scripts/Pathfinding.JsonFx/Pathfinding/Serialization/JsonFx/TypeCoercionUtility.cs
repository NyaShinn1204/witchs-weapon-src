using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Pathfinding.Serialization.JsonFx
{
	internal class TypeCoercionUtility
	{
		private Dictionary<Type, Dictionary<string, MemberInfo>> memberMapCache;

		private bool allowNullValueTypes;

		private Dictionary<Type, Dictionary<string, MemberInfo>> MemberMapCache
		{
			get
			{
				return null;
			}
		}

		internal object ProcessTypeHint(IDictionary result, string typeInfo, out Type objectType, out Dictionary<string, MemberInfo> memberMap)
		{
			objectType = null;
			memberMap = null;
			return null;
		}

		internal object InstantiateObject(Type objectType, out Dictionary<string, MemberInfo> memberMap)
		{
			memberMap = null;
			return null;
		}

		public Dictionary<string, MemberInfo> GetMemberMap(Type objectType)
		{
			return null;
		}

		private Dictionary<string, MemberInfo> CreateMemberMap(Type objectType)
		{
			return null;
		}

		internal static Type GetMemberInfo(Dictionary<string, MemberInfo> memberMap, string memberName, out MemberInfo memberInfo)
		{
			memberInfo = null;
			return null;
		}

		internal void SetMemberValue(object result, Type memberType, MemberInfo memberInfo, object value)
		{
		}

		internal object CoerceType(Type targetType, object value)
		{
			return null;
		}

		private object CoerceType(Type targetType, IDictionary value, out Dictionary<string, MemberInfo> memberMap)
		{
			memberMap = null;
			return null;
		}

		private object CoerceList(Type targetType, Type arrayType, IEnumerable value)
		{
			return null;
		}

		private Array CoerceArray(Type elementType, IEnumerable value)
		{
			return null;
		}

		private static bool IsNullable(Type type)
		{
			return false;
		}
	}
}
