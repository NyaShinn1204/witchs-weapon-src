using System;
using System.Collections.Generic;
using System.Reflection;
using ParadoxNotion.Serialization.FullSerializer.Internal;

namespace ParadoxNotion.Serialization.FullSerializer
{
	public class fsMetaType
	{
		private static Dictionary<fsConfig, Dictionary<Type, fsMetaType>> _configMetaTypes;

		public Type ReflectedType;

		private bool _hasEmittedAotData;

		private bool? _hasDefaultConstructorCache;

		private bool _isDefaultConstructorPublic;

		public fsMetaProperty[] Properties { get; private set; }

		public bool HasDefaultConstructor
		{
			get
			{
				return false;
			}
		}

		private fsMetaType(fsConfig config, Type reflectedType)
		{
		}

		public static fsMetaType Get(fsConfig config, Type type)
		{
			return null;
		}

		public static void ClearCache()
		{
		}

		private static void CollectProperties(fsConfig config, List<fsMetaProperty> properties, Type reflectedType)
		{
		}

		private static bool IsAutoProperty(PropertyInfo property, MemberInfo[] members)
		{
			return false;
		}

		private static bool CanSerializeProperty(fsConfig config, PropertyInfo property, MemberInfo[] members, bool annotationFreeValue)
		{
			return false;
		}

		private static bool CanSerializeField(fsConfig config, FieldInfo field, bool annotationFreeValue)
		{
			return false;
		}

		public bool EmitAotData()
		{
			return false;
		}

		public object CreateInstance()
		{
			return null;
		}
	}
}
