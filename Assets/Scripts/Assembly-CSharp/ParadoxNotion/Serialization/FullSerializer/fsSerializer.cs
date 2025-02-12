using System;
using System.Collections.Generic;
using ParadoxNotion.Serialization.FullSerializer.Internal;

namespace ParadoxNotion.Serialization.FullSerializer
{
	public class fsSerializer
	{
		internal class fsLazyCycleDefinitionWriter
		{
			private Dictionary<int, fsData> _pendingDefinitions;

			private HashSet<int> _references;

			public void WriteDefinition(int id, fsData data)
			{
			}

			public void WriteReference(int id, Dictionary<string, fsData> dict)
			{
			}

			public void Clear()
			{
			}
		}

		private static HashSet<string> _reservedKeywords;

		private const string Key_ObjectReference = "$ref";

		private const string Key_ObjectDefinition = "$id";

		private const string Key_InstanceType = "$type";

		private const string Key_Version = "$version";

		private const string Key_Content = "$content";

		private Dictionary<Type, fsBaseConverter> _cachedConverterTypeInstances;

		private Dictionary<Type, fsBaseConverter> _cachedConverters;

		private Dictionary<Type, List<fsObjectProcessor>> _cachedProcessors;

		private readonly List<fsConverter> _availableConverters;

		private readonly Dictionary<Type, fsDirectConverter> _availableDirectConverters;

		private readonly List<fsObjectProcessor> _processors;

		private readonly fsCyclicReferenceManager _references;

		private readonly fsLazyCycleDefinitionWriter _lazyReferenceWriter;

		public fsContext Context;

		public fsConfig Config;

		static fsSerializer()
		{
		}

		public static bool IsReservedKeyword(string key)
		{
			return false;
		}

		private static bool IsObjectReference(fsData data)
		{
			return false;
		}

		private static bool IsObjectDefinition(fsData data)
		{
			return false;
		}

		private static bool IsVersioned(fsData data)
		{
			return false;
		}

		private static bool IsTypeSpecified(fsData data)
		{
			return false;
		}

		private static bool IsWrappedData(fsData data)
		{
			return false;
		}

		public static void StripDeserializationMetadata(ref fsData data)
		{
		}

		private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, Type storageType, object instance)
		{
		}

		private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data)
		{
		}

		private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, Type storageType, ref fsData data)
		{
		}

		private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data)
		{
		}

		private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, Type storageType, object instance)
		{
		}

		private static void EnsureDictionary(fsData data)
		{
		}

		public void AddProcessor(fsObjectProcessor processor)
		{
		}

		public void RemoveProcessor<TProcessor>()
		{
		}

		private List<fsObjectProcessor> GetProcessors(Type type)
		{
			return null;
		}

		public void AddConverter(fsBaseConverter converter)
		{
		}

		private fsBaseConverter GetConverter(Type type, Type overrideConverterType)
		{
			return null;
		}

		public fsResult TrySerialize<T>(T instance, out fsData data)
		{
			data = null;
			return default(fsResult);
		}

		public fsResult TryDeserialize<T>(fsData data, ref T instance)
		{
			return default(fsResult);
		}

		public fsResult TrySerialize(Type storageType, object instance, out fsData data)
		{
			data = null;
			return default(fsResult);
		}

		public fsResult TrySerialize(Type storageType, Type overrideConverterType, object instance, out fsData data)
		{
			data = null;
			return default(fsResult);
		}

		private fsResult InternalSerialize_1_ProcessCycles(Type storageType, Type overrideConverterType, object instance, out fsData data)
		{
			data = null;
			return default(fsResult);
		}

		private fsResult InternalSerialize_2_Inheritance(Type storageType, Type overrideConverterType, object instance, out fsData data)
		{
			data = null;
			return default(fsResult);
		}

		private fsResult InternalSerialize_4_Converter(Type overrideConverterType, object instance, out fsData data)
		{
			data = null;
			return default(fsResult);
		}

		public fsResult TryDeserialize(fsData data, Type storageType, ref object result)
		{
			return default(fsResult);
		}

		public fsResult TryDeserialize(fsData data, Type storageType, Type overrideConverterType, ref object result)
		{
			return default(fsResult);
		}

		private fsResult InternalDeserialize_1_CycleReference(Type overrideConverterType, fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors)
		{
			processors = null;
			return default(fsResult);
		}

		private fsResult InternalDeserialize_3_Inheritance(Type overrideConverterType, fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors)
		{
			processors = null;
			return default(fsResult);
		}

		private fsResult InternalDeserialize_4_Cycles(Type overrideConverterType, fsData data, Type resultType, ref object result)
		{
			return default(fsResult);
		}

		private fsResult InternalDeserialize_5_Converter(Type overrideConverterType, fsData data, Type resultType, ref object result)
		{
			return default(fsResult);
		}
	}
}
